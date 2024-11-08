namespace PR_6_Indi_
{
    partial class ArrayForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_kor = new System.Windows.Forms.RadioButton();
            this.radioButton_rand = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.обчисленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обчислитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записатиУФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зчитатиЗФайлуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повернутисяДоВиборуЗадачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_Vid = new System.Windows.Forms.TextBox();
            this.textBox_Do = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Mezhi = new System.Windows.Forms.TextBox();
            this.textBox_array = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(883, 85);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_kor);
            this.groupBox1.Controls.Add(this.radioButton_rand);
            this.groupBox1.Location = new System.Drawing.Point(16, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 139);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим роботи ";
            // 
            // radioButton_kor
            // 
            this.radioButton_kor.AutoSize = true;
            this.radioButton_kor.Location = new System.Drawing.Point(17, 75);
            this.radioButton_kor.Name = "radioButton_kor";
            this.radioButton_kor.Size = new System.Drawing.Size(64, 23);
            this.radioButton_kor.TabIndex = 1;
            this.radioButton_kor.Text = "Вручну";
            this.radioButton_kor.UseVisualStyleBackColor = true;
            this.radioButton_kor.CheckedChanged += new System.EventHandler(this.radioButton_kor_CheckedChanged);
            // 
            // radioButton_rand
            // 
            this.radioButton_rand.AutoSize = true;
            this.radioButton_rand.Checked = true;
            this.radioButton_rand.Location = new System.Drawing.Point(17, 41);
            this.radioButton_rand.Name = "radioButton_rand";
            this.radioButton_rand.Size = new System.Drawing.Size(91, 23);
            this.radioButton_rand.TabIndex = 0;
            this.radioButton_rand.TabStop = true;
            this.radioButton_rand.Text = "Автоматично";
            this.radioButton_rand.UseVisualStyleBackColor = true;
            this.radioButton_rand.CheckedChanged += new System.EventHandler(this.radioButton_rand_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обчисленняToolStripMenuItem,
            this.файлToolStripMenuItem,
            this.повернутисяДоВиборуЗадачToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 25);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // обчисленняToolStripMenuItem
            // 
            this.обчисленняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обчислитиToolStripMenuItem,
            this.очиститиToolStripMenuItem});
            this.обчисленняToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.обчисленняToolStripMenuItem.Name = "обчисленняToolStripMenuItem";
            this.обчисленняToolStripMenuItem.Size = new System.Drawing.Size(89, 21);
            this.обчисленняToolStripMenuItem.Text = "Обчислення";
            this.обчисленняToolStripMenuItem.Click += new System.EventHandler(this.обчисленняToolStripMenuItem_Click);
            // 
            // обчислитиToolStripMenuItem
            // 
            this.обчислитиToolStripMenuItem.Name = "обчислитиToolStripMenuItem";
            this.обчислитиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.обчислитиToolStripMenuItem.Text = "Обчислити";
            this.обчислитиToolStripMenuItem.Click += new System.EventHandler(this.обчислитиToolStripMenuItem_Click);
            // 
            // очиститиToolStripMenuItem
            // 
            this.очиститиToolStripMenuItem.Name = "очиститиToolStripMenuItem";
            this.очиститиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.очиститиToolStripMenuItem.Text = "Очистити";
            this.очиститиToolStripMenuItem.Click += new System.EventHandler(this.очиститиToolStripMenuItem_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.записатиУФайлToolStripMenuItem,
            this.зчитатиЗФайлуToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // записатиУФайлToolStripMenuItem
            // 
            this.записатиУФайлToolStripMenuItem.Name = "записатиУФайлToolStripMenuItem";
            this.записатиУФайлToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.записатиУФайлToolStripMenuItem.Text = "Записати у файл";
            this.записатиУФайлToolStripMenuItem.Click += new System.EventHandler(this.записатиУФайлToolStripMenuItem_Click);
            // 
            // зчитатиЗФайлуToolStripMenuItem
            // 
            this.зчитатиЗФайлуToolStripMenuItem.Name = "зчитатиЗФайлуToolStripMenuItem";
            this.зчитатиЗФайлуToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.зчитатиЗФайлуToolStripMenuItem.Text = "Зчитати з файлу";
            this.зчитатиЗФайлуToolStripMenuItem.Click += new System.EventHandler(this.зчитатиЗФайлуToolStripMenuItem_Click);
            // 
            // повернутисяДоВиборуЗадачToolStripMenuItem
            // 
            this.повернутисяДоВиборуЗадачToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.повернутисяДоВиборуЗадачToolStripMenuItem.Name = "повернутисяДоВиборуЗадачToolStripMenuItem";
            this.повернутисяДоВиборуЗадачToolStripMenuItem.Size = new System.Drawing.Size(189, 21);
            this.повернутисяДоВиборуЗадачToolStripMenuItem.Text = "Повернутися до вибору задач";
            this.повернутисяДоВиборуЗадачToolStripMenuItem.Click += new System.EventHandler(this.повернутисяДоВиборуЗадачToolStripMenuItem_Click);
            // 
            // textBox_Vid
            // 
            this.textBox_Vid.Location = new System.Drawing.Point(187, 225);
            this.textBox_Vid.Name = "textBox_Vid";
            this.textBox_Vid.Size = new System.Drawing.Size(100, 27);
            this.textBox_Vid.TabIndex = 10;
            // 
            // textBox_Do
            // 
            this.textBox_Do.Location = new System.Drawing.Point(321, 225);
            this.textBox_Do.Name = "textBox_Do";
            this.textBox_Do.Size = new System.Drawing.Size(100, 27);
            this.textBox_Do.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Від";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "До";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Кількість елементів масиву:";
            // 
            // textBox_Mezhi
            // 
            this.textBox_Mezhi.Location = new System.Drawing.Point(187, 156);
            this.textBox_Mezhi.Name = "textBox_Mezhi";
            this.textBox_Mezhi.Size = new System.Drawing.Size(100, 27);
            this.textBox_Mezhi.TabIndex = 15;
            // 
            // textBox_array
            // 
            this.textBox_array.Location = new System.Drawing.Point(187, 159);
            this.textBox_array.Name = "textBox_array";
            this.textBox_array.Size = new System.Drawing.Size(234, 27);
            this.textBox_array.TabIndex = 16;
            this.textBox_array.Visible = false;
            this.textBox_array.TextChanged += new System.EventHandler(this.textBox_array_TextChanged);
            this.textBox_array.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_array_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Введіть елементи масиву через пробіл:";
            this.label7.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ArrayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(911, 286);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_array);
            this.Controls.Add(this.textBox_Mezhi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Do);
            this.Controls.Add(this.textBox_Vid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ArrayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Одновимірний масив";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArrayForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_kor;
        private System.Windows.Forms.RadioButton radioButton_rand;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem обчисленняToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_Vid;
        private System.Windows.Forms.TextBox textBox_Do;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Mezhi;
        private System.Windows.Forms.ToolStripMenuItem обчислитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститиToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_array;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записатиУФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зчитатиЗФайлуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повернутисяДоВиборуЗадачToolStripMenuItem;
    }
}