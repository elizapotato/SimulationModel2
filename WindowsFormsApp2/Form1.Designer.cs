namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxHight = new System.Windows.Forms.NumericUpDown();
            this.boxAngle = new System.Windows.Forms.NumericUpDown();
            this.boxSpeed = new System.Windows.Forms.NumericUpDown();
            this.startB = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labX = new System.Windows.Forms.Label();
            this.labY = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxHight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labTime);
            this.panel1.Controls.Add(this.labY);
            this.panel1.Controls.Add(this.labX);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.startB);
            this.panel1.Controls.Add(this.boxSpeed);
            this.panel1.Controls.Add(this.boxAngle);
            this.panel1.Controls.Add(this.boxHight);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Высота:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Угол:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Скорость:";
            // 
            // boxHight
            // 
            this.boxHight.Location = new System.Drawing.Point(91, 7);
            this.boxHight.Name = "boxHight";
            this.boxHight.Size = new System.Drawing.Size(120, 22);
            this.boxHight.TabIndex = 3;
            // 
            // boxAngle
            // 
            this.boxAngle.Location = new System.Drawing.Point(91, 35);
            this.boxAngle.Name = "boxAngle";
            this.boxAngle.Size = new System.Drawing.Size(120, 22);
            this.boxAngle.TabIndex = 4;
            this.boxAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // boxSpeed
            // 
            this.boxSpeed.Location = new System.Drawing.Point(91, 63);
            this.boxSpeed.Name = "boxSpeed";
            this.boxSpeed.Size = new System.Drawing.Size(120, 22);
            this.boxSpeed.TabIndex = 4;
            this.boxSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // startB
            // 
            this.startB.Location = new System.Drawing.Point(234, 28);
            this.startB.Name = "startB";
            this.startB.Size = new System.Drawing.Size(78, 35);
            this.startB.TabIndex = 5;
            this.startB.Text = "Старт";
            this.startB.UseVisualStyleBackColor = true;
            this.startB.Click += new System.EventHandler(this.startB_Click);
            // 
            // chart1
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 100);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(800, 350);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(343, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 27);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Пауза";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labX
            // 
            this.labX.AutoSize = true;
            this.labX.Location = new System.Drawing.Point(479, 37);
            this.labX.Name = "labX";
            this.labX.Size = new System.Drawing.Size(29, 17);
            this.labX.TabIndex = 7;
            this.labX.Text = "X =";
            // 
            // labY
            // 
            this.labY.AutoSize = true;
            this.labY.Location = new System.Drawing.Point(479, 63);
            this.labY.Name = "labY";
            this.labY.Size = new System.Drawing.Size(29, 17);
            this.labY.TabIndex = 8;
            this.labY.Text = "Y =";
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Location = new System.Drawing.Point(457, 12);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(51, 17);
            this.labTime.TabIndex = 9;
            this.labTime.Text = "Time =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxHight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startB;
        private System.Windows.Forms.NumericUpDown boxSpeed;
        private System.Windows.Forms.NumericUpDown boxAngle;
        private System.Windows.Forms.NumericUpDown boxHight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labY;
        private System.Windows.Forms.Label labX;
        private System.Windows.Forms.Label labTime;
    }
}

