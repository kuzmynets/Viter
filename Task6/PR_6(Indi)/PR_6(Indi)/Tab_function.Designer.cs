namespace PR_6_Indi_
{
    partial class Tab_function
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.протабулюватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очищенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.створитиДоВиборуЗадачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBo_Step = new System.Windows.Forms.TextBox();
            this.textBox_R = new System.Windows.Forms.TextBox();
            this.textBox_L = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(418, 67);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.LegendText = "y=sin^2x/(1+x^2)";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(577, 340);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.протабулюватиToolStripMenuItem,
            this.очищенняToolStripMenuItem,
            this.створитиДоВиборуЗадачToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1017, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // протабулюватиToolStripMenuItem
            // 
            this.протабулюватиToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.протабулюватиToolStripMenuItem.Name = "протабулюватиToolStripMenuItem";
            this.протабулюватиToolStripMenuItem.Size = new System.Drawing.Size(127, 25);
            this.протабулюватиToolStripMenuItem.Text = "Протабулювати";
            this.протабулюватиToolStripMenuItem.Click += new System.EventHandler(this.протабулюватиToolStripMenuItem_Click);
            // 
            // очищенняToolStripMenuItem
            // 
            this.очищенняToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.очищенняToolStripMenuItem.Name = "очищенняToolStripMenuItem";
            this.очищенняToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.очищенняToolStripMenuItem.Text = "Очистити";
            this.очищенняToolStripMenuItem.Click += new System.EventHandler(this.очищенняToolStripMenuItem_Click);
            // 
            // створитиДоВиборуЗадачToolStripMenuItem
            // 
            this.створитиДоВиборуЗадачToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.створитиДоВиборуЗадачToolStripMenuItem.Name = "створитиДоВиборуЗадачToolStripMenuItem";
            this.створитиДоВиборуЗадачToolStripMenuItem.Size = new System.Drawing.Size(226, 25);
            this.створитиДоВиборуЗадачToolStripMenuItem.Text = "Повернутися до вибору задач";
            this.створитиДоВиборуЗадачToolStripMenuItem.Click += new System.EventHandler(this.створитиДоВиборуЗадачToolStripMenuItem_Click);
            // 
            // textBo_Step
            // 
            this.textBo_Step.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.textBo_Step.Location = new System.Drawing.Point(418, 456);
            this.textBo_Step.Name = "textBo_Step";
            this.textBo_Step.Size = new System.Drawing.Size(164, 32);
            this.textBo_Step.TabIndex = 12;
            // 
            // textBox_R
            // 
            this.textBox_R.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.textBox_R.Location = new System.Drawing.Point(214, 456);
            this.textBox_R.Name = "textBox_R";
            this.textBox_R.Size = new System.Drawing.Size(164, 32);
            this.textBox_R.TabIndex = 11;
            // 
            // textBox_L
            // 
            this.textBox_L.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.textBox_L.Location = new System.Drawing.Point(17, 456);
            this.textBox_L.Name = "textBox_L";
            this.textBox_L.Size = new System.Drawing.Size(164, 32);
            this.textBox_L.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(474, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Крок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(235, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Права межа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ліва межа";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(17, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(361, 340);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(379, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 34);
            this.label4.TabIndex = 14;
            this.label4.Text = "sin^2x/(1+x^2)";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            // 
            // Tab_function
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1017, 531);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBo_Step);
            this.Controls.Add(this.textBox_R);
            this.Controls.Add(this.textBox_L);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Tab_function";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Табулювання функції";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tab_function_FormClosing);
            this.Load += new System.EventHandler(this.Tab_function_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem протабулюватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очищенняToolStripMenuItem;
        private System.Windows.Forms.TextBox textBo_Step;
        private System.Windows.Forms.TextBox textBox_R;
        private System.Windows.Forms.TextBox textBox_L;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem створитиДоВиборуЗадачToolStripMenuItem;
    }
}