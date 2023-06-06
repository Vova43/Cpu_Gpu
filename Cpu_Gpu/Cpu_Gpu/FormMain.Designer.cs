namespace Cpu_Gpu
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel_main = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_main = new System.Windows.Forms.TableLayoutPanel();
            this.chart_cpu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_gpu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_ram_using = new System.Windows.Forms.Label();
            this.chart_disk = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_gpu_using = new System.Windows.Forms.Label();
            this.chart_ram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_cpu_using = new System.Windows.Forms.Label();
            this.label_disk_using = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            this.tableLayoutPanel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_gpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_disk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ram)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel_main.Controls.Add(this.tableLayoutPanel_main);
            this.panel_main.Location = new System.Drawing.Point(2, 2);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(376, 82);
            this.panel_main.TabIndex = 0;
            // 
            // tableLayoutPanel_main
            // 
            this.tableLayoutPanel_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_main.ColumnCount = 4;
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_main.Controls.Add(this.chart_cpu, 0, 0);
            this.tableLayoutPanel_main.Controls.Add(this.chart_gpu, 1, 0);
            this.tableLayoutPanel_main.Controls.Add(this.label_ram_using, 2, 1);
            this.tableLayoutPanel_main.Controls.Add(this.chart_disk, 3, 0);
            this.tableLayoutPanel_main.Controls.Add(this.label_gpu_using, 1, 1);
            this.tableLayoutPanel_main.Controls.Add(this.chart_ram, 2, 0);
            this.tableLayoutPanel_main.Controls.Add(this.label_cpu_using, 0, 1);
            this.tableLayoutPanel_main.Controls.Add(this.label_disk_using, 3, 1);
            this.tableLayoutPanel_main.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel_main.Name = "tableLayoutPanel_main";
            this.tableLayoutPanel_main.RowCount = 2;
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.14285F));
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85715F));
            this.tableLayoutPanel_main.Size = new System.Drawing.Size(369, 72);
            this.tableLayoutPanel_main.TabIndex = 11;
            // 
            // chart_cpu
            // 
            this.chart_cpu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_cpu.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            chartArea1.Name = "ChartArea1";
            this.chart_cpu.ChartAreas.Add(chartArea1);
            this.chart_cpu.Location = new System.Drawing.Point(3, 3);
            this.chart_cpu.Name = "chart_cpu";
            this.chart_cpu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Lime;
            series1.Name = "Series1";
            this.chart_cpu.Series.Add(series1);
            this.chart_cpu.Size = new System.Drawing.Size(86, 35);
            this.chart_cpu.TabIndex = 0;
            this.chart_cpu.Text = "chart1";
            // 
            // chart_gpu
            // 
            this.chart_gpu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_gpu.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            chartArea2.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            chartArea2.Name = "ChartArea1";
            this.chart_gpu.ChartAreas.Add(chartArea2);
            this.chart_gpu.Location = new System.Drawing.Point(95, 3);
            this.chart_gpu.Name = "chart_gpu";
            this.chart_gpu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Lime;
            series2.Name = "Series1";
            this.chart_gpu.Series.Add(series2);
            this.chart_gpu.Size = new System.Drawing.Size(86, 35);
            this.chart_gpu.TabIndex = 5;
            this.chart_gpu.Text = "chart2";
            // 
            // label_ram_using
            // 
            this.label_ram_using.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ram_using.AutoSize = true;
            this.label_ram_using.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ram_using.ForeColor = System.Drawing.SystemColors.Window;
            this.label_ram_using.Location = new System.Drawing.Point(187, 41);
            this.label_ram_using.Name = "label_ram_using";
            this.label_ram_using.Size = new System.Drawing.Size(86, 31);
            this.label_ram_using.TabIndex = 8;
            this.label_ram_using.Text = "RAM: 0%\r\ntC°: 0";
            // 
            // chart_disk
            // 
            this.chart_disk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_disk.BackColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.BackColor = System.Drawing.Color.Black;
            chartArea3.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            chartArea3.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            chartArea3.Name = "ChartArea1";
            this.chart_disk.ChartAreas.Add(chartArea3);
            this.chart_disk.Location = new System.Drawing.Point(279, 3);
            this.chart_disk.Name = "chart_disk";
            this.chart_disk.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Lime;
            series3.Name = "Series1";
            this.chart_disk.Series.Add(series3);
            this.chart_disk.Size = new System.Drawing.Size(87, 35);
            this.chart_disk.TabIndex = 9;
            this.chart_disk.Text = "chart4";
            // 
            // label_gpu_using
            // 
            this.label_gpu_using.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_gpu_using.AutoSize = true;
            this.label_gpu_using.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_gpu_using.ForeColor = System.Drawing.SystemColors.Window;
            this.label_gpu_using.Location = new System.Drawing.Point(95, 41);
            this.label_gpu_using.Name = "label_gpu_using";
            this.label_gpu_using.Size = new System.Drawing.Size(86, 31);
            this.label_gpu_using.TabIndex = 6;
            this.label_gpu_using.Text = "GPU: 0%\r\ntC°: 0";
            // 
            // chart_ram
            // 
            this.chart_ram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_ram.BackColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.BackColor = System.Drawing.Color.Black;
            chartArea4.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            chartArea4.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            chartArea4.Name = "ChartArea1";
            this.chart_ram.ChartAreas.Add(chartArea4);
            this.chart_ram.Location = new System.Drawing.Point(187, 3);
            this.chart_ram.Name = "chart_ram";
            this.chart_ram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Lime;
            series4.Name = "Series1";
            this.chart_ram.Series.Add(series4);
            this.chart_ram.Size = new System.Drawing.Size(86, 35);
            this.chart_ram.TabIndex = 7;
            this.chart_ram.Text = "chart3";
            // 
            // label_cpu_using
            // 
            this.label_cpu_using.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_cpu_using.AutoSize = true;
            this.label_cpu_using.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cpu_using.ForeColor = System.Drawing.SystemColors.Window;
            this.label_cpu_using.Location = new System.Drawing.Point(3, 41);
            this.label_cpu_using.Name = "label_cpu_using";
            this.label_cpu_using.Size = new System.Drawing.Size(86, 31);
            this.label_cpu_using.TabIndex = 4;
            this.label_cpu_using.Text = "CPU: 0%\r\ntC°: 0\r\n";
            // 
            // label_disk_using
            // 
            this.label_disk_using.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_disk_using.AutoSize = true;
            this.label_disk_using.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_disk_using.ForeColor = System.Drawing.SystemColors.Window;
            this.label_disk_using.Location = new System.Drawing.Point(279, 41);
            this.label_disk_using.Name = "label_disk_using";
            this.label_disk_using.Size = new System.Drawing.Size(87, 31);
            this.label_disk_using.TabIndex = 10;
            this.label_disk_using.Text = "DISK: 0%\r\ntC°: 0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(380, 86);
            this.Controls.Add(this.panel_main);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(356, 86);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel_main.ResumeLayout(false);
            this.tableLayoutPanel_main.ResumeLayout(false);
            this.tableLayoutPanel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_gpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_disk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_cpu;
        private System.Windows.Forms.Label label_disk_using;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_disk;
        private System.Windows.Forms.Label label_ram_using;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ram;
        private System.Windows.Forms.Label label_gpu_using;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_gpu;
        private System.Windows.Forms.Label label_cpu_using;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_main;
    }
}

