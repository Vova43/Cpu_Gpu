using Cpu_Gpu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cpu_Gpu
{
    public partial class FormMain : Form
    {
        public string FileConfig = "Config.properties";
        public PropertiesFile Properties_File = new PropertiesFile();
        public Point mousePos { get; set; }
        public FormMain()
        {
            InitializeComponent();

            // Графики >> Graphs ->
            chart_cpu.ChartAreas[0].AxisX.Minimum = 1;
            chart_cpu.ChartAreas[0].AxisX.Maximum = 60;

            chart_cpu.ChartAreas[0].AxisY.Minimum = -1;
            chart_cpu.ChartAreas[0].AxisY.Maximum = 101;
            //
            chart_gpu.ChartAreas[0].AxisX.Minimum = 1;
            chart_gpu.ChartAreas[0].AxisX.Maximum = 60;

            chart_gpu.ChartAreas[0].AxisY.Minimum = -1;
            chart_gpu.ChartAreas[0].AxisY.Maximum = 101;
            //
            chart_ram.ChartAreas[0].AxisX.Minimum = 1;
            chart_ram.ChartAreas[0].AxisX.Maximum = 60;

            chart_ram.ChartAreas[0].AxisY.Minimum = -1;
            chart_ram.ChartAreas[0].AxisY.Maximum = 101;
            //
            chart_disk.ChartAreas[0].AxisX.Minimum = 1;
            chart_disk.ChartAreas[0].AxisX.Maximum = 60;

            chart_disk.ChartAreas[0].AxisY.Minimum = -1;
            chart_disk.ChartAreas[0].AxisY.Maximum = 101;
            // <-

            UsingTest();
        }

        private void MauseMove()
        {
            panel_main.MouseDown += (ss, ee) => { mousePos = ee.Location; };
            panel_main.MouseMove += (ss, ee) =>
            {
                if (ee.Button == MouseButtons.Left)
                {
                    int dx = ee.X - mousePos.X;
                    int dy = ee.Y - mousePos.Y;
                    this.Location = new Point(this.Left + dx, this.Top + dy);
                }
            };
            panel_main.MouseUp += (ss, ee) => SavePosition();

            tableLayoutPanel_main.MouseDown += (ss, ee) => { mousePos = ee.Location; };
            tableLayoutPanel_main.MouseMove += (ss, ee) =>
            {
                if (ee.Button == MouseButtons.Left)
                {
                    int dx = ee.X - mousePos.X;
                    int dy = ee.Y - mousePos.Y;
                    this.Location = new Point(this.Left + dx, this.Top + dy);
                }
            };
            tableLayoutPanel_main.MouseUp += (ss, ee) => SavePosition();

            foreach (Control item in this.tableLayoutPanel_main.Controls)
            {
                item.MouseDown += (ss, ee) => { mousePos = ee.Location; };
                item.MouseMove += (ss, ee) =>
                {
                    if (ee.Button == MouseButtons.Left)
                    {
                        int dx = ee.X - mousePos.X;
                        int dy = ee.Y - mousePos.Y;
                        this.Location = new Point(this.Left + dx, this.Top + dy);
                    }
                };
                item.MouseUp += (ss, ee) => SavePosition();
            }
        }

        private void SavePosition()
        {
            Dictionary<string, string> KeyValue = Properties_File.LoadDictionary(FileConfig);
            KeyValue["Form.Point.Top"] = this.Top + "";
            KeyValue["Form.Point.Left"] = this.Left + "";
            Properties_File.SaveDictionary();
        }

        private void LoadPosition()
        {
            if (!File.Exists(FileConfig))
            {
                File.Create(FileConfig).Close();
                CenterToScreen();
                SavePosition();
            }
            else
            {
                Dictionary<string, string> KeyValue = Properties_File.LoadDictionary(FileConfig);
                this.Top = Convert.ToInt32(KeyValue["Form.Point.Top"]);
                this.Left = Convert.ToInt32(KeyValue["Form.Point.Left"]);
                //MessageBox.Show(KeyValue["Form.Point.Top"] + "=" + Convert.ToInt32(KeyValue["Form.Point.Top"]) + " / " + KeyValue["Form.Point.Left"]+"="+Convert.ToInt32(KeyValue["Form.Point.Left"]));
            }
        }


        //Запросы для получения данных ПК >> Requests to get PC data ->
        public static PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        public static PerformanceCounter gpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        public static PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
        public static ManagementObjectSearcher ramMonitor = new ManagementObjectSearcher("SELECT TotalVisibleMemorySize,FreePhysicalMemory FROM Win32_OperatingSystem");
        public static ManagementObjectSearcher cpuTemp = new ManagementObjectSearcher(@"root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature");
        // <-
        public static float getCurrentCpuUsage() { return cpuCounter.NextValue(); } // Получить ЦП >> Get CPU %
        public static float getCurrentCpuTemp() // Получить ЦП >> Get CPU C^
        {
            float Temp = 0;
            foreach (ManagementObject obj in cpuTemp.Get())
                Temp = (float)(Convert.ToDouble(obj["CurrentTemperature"].ToString()) - 2732) / 10.0F;
            return Temp;
        }
        // <-
        // Получить оперативную память >> Get RAM % ->
        public static float getAvailableRAM() { return ramCounter.NextValue(); }
        public static float getUsingRAM()
        {
            float memory = 0;
            foreach (ManagementObject objram in ramMonitor.Get())
            {
                ulong totalRam = Convert.ToUInt64(objram["TotalVisibleMemorySize"]);       //общая память ОЗУ
                ulong busyRam = totalRam - Convert.ToUInt64(objram["FreePhysicalMemory"]); //занятная память = (total-free)
                memory = ((busyRam * 100) / totalRam);
            }
            return memory;
        }
        // <-
        // Получить графический процессор >> Get GPU % ->
        public static float GetGPUUsage()
        {
            PerformanceCounterCategory category = new PerformanceCounterCategory("GPU Engine");
            List<PerformanceCounter> gpuCounters = category.GetInstanceNames()
                                .Where(counterName => counterName.EndsWith("engtype_3D"))
                                .SelectMany(counterName => category.GetCounters(counterName))
                                .Where(counter => counter.CounterName.Equals("Utilization Percentage"))
                                .ToList();
            gpuCounters.ForEach(x => x.NextValue());
            Thread.Sleep(1000);
            //Task.Delay(1000);
            return gpuCounters.Sum(x => x.NextValue());
        }
        // <-

        // График использования >> Usage Schedule
        private async void UsingTest()
        {
            await Task.Run(() =>
            {
                try
                {
                    float usingCPU = getCurrentCpuUsage();
                    float tempCPU = 0;
                    float availableRAM = getAvailableRAM();
                    float usingRAM = getUsingRAM();
                    label_cpu_using.Invoke(new Action(() => label_cpu_using.Text = "CPU: " + Math.Round(usingCPU, 2) + "% \ntC°: " + Math.Round(tempCPU, 2)));
                    label_ram_using.Invoke(new Action(() => label_ram_using.Text = "RAM: " + usingRAM + "% \ntC°: 0"));

                    float usingGPU = 0F;
                    try
                    {
                        usingGPU = GetGPUUsage();
                    }
                    catch { }
                    label_gpu_using.Invoke(new Action(() => label_gpu_using.Text = "GPU: " + Math.Round(usingGPU, 2) + "% \ntC°: 0"));

                    // грифики
                    try
                    {
                        chart_cpu.Invoke(new Action(() =>
                        {
                            if (chart_cpu.Series[0].Points.Count >= 60)
                                chart_cpu.Series[0].Points.Clear();
                            chart_cpu.Series[0].Points.AddY(usingCPU);
                        }));

                        chart_ram.Invoke(new Action(() =>
                        {
                            if (chart_ram.Series[0].Points.Count >= 60)
                                chart_ram.Series[0].Points.Clear();
                            chart_ram.Series[0].Points.AddY(usingRAM);
                        }));

                        chart_gpu.Invoke(new Action(() =>
                        {
                            if (chart_gpu.Series[0].Points.Count >= 60)
                                chart_gpu.Series[0].Points.Clear();
                            chart_gpu.Series[0].Points.AddY(usingGPU);
                        }));
                    }
                    catch { }
                }
                catch { }
            });
            await Task.Delay(1000);
            UsingTest();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadPosition();
            MauseMove();
        }
    }
}
