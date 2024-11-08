namespace PR_6_Indi_
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.but_zavd = new System.Windows.Forms.Button();
            this.but_aboutProgram = new System.Windows.Forms.Button();
            this.but_End = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // but_zavd
            // 
            this.but_zavd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.but_zavd.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_zavd.Location = new System.Drawing.Point(39, 60);
            this.but_zavd.Name = "but_zavd";
            this.but_zavd.Size = new System.Drawing.Size(115, 58);
            this.but_zavd.TabIndex = 0;
            this.but_zavd.Text = "Завдання";
            this.but_zavd.UseVisualStyleBackColor = false;
            this.but_zavd.Click += new System.EventHandler(this.but_zavd_Click);
            // 
            // but_aboutProgram
            // 
            this.but_aboutProgram.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.but_aboutProgram.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_aboutProgram.Location = new System.Drawing.Point(39, 156);
            this.but_aboutProgram.Name = "but_aboutProgram";
            this.but_aboutProgram.Size = new System.Drawing.Size(115, 58);
            this.but_aboutProgram.TabIndex = 1;
            this.but_aboutProgram.Text = "Про програму";
            this.but_aboutProgram.UseVisualStyleBackColor = false;
            this.but_aboutProgram.Click += new System.EventHandler(this.but_aboutProgram_Click);
            // 
            // but_End
            // 
            this.but_End.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.but_End.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_End.Location = new System.Drawing.Point(39, 256);
            this.but_End.Name = "but_End";
            this.but_End.Size = new System.Drawing.Size(115, 58);
            this.but_End.TabIndex = 2;
            this.but_End.Text = "Завершення роботи";
            this.but_End.UseVisualStyleBackColor = false;
            this.but_End.Click += new System.EventHandler(this.but_End_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Завдання 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(223, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(916, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.but_End);
            this.Controls.Add(this.but_aboutProgram);
            this.Controls.Add(this.but_zavd);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головне меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_zavd;
        private System.Windows.Forms.Button but_aboutProgram;
        private System.Windows.Forms.Button but_End;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

