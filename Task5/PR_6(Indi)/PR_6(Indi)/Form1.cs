using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_6_Indi_
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }
        private void but_End_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ви точно хочете вийти?", "Перевірка", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) e.Cancel = true;
        }


        private void but_aboutProgram_Click(object sender, EventArgs e)
        {
            
            
        }
        private async void but_zavd_Click(object sender, EventArgs e)
        { 
                while (this.Width <= 999)
                {
                    this.Width += 10;
                    await Task.Delay(10);
                    CenterToScreen();
                }  
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Zavd_1 zavd_1 = new Zavd_1();
            zavd_1.Show();
            Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Zavd_1 zavd_1 = new Zavd_1();
            zavd_1.Show();
            Hide();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Tab_function tab_function = new Tab_function();
            tab_function.Show();
            Hide();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Tab_function tab_function = new Tab_function();
            tab_function.Show();
            Hide();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ArrayForm arrayForm = new ArrayForm();
            arrayForm.Show();
            Hide();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            ArrayForm arrayForm = new ArrayForm();
            arrayForm.Show();
            Hide();
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TD_array tD_Array = new TD_array();
            tD_Array.Show();
            Hide();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            TD_array tD_Array = new TD_array();
            tD_Array.Show();
            Hide();
        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            cell_AU Cell_PC = new cell_AU();
            Cell_PC.Show();
            Hide();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            cell_AU Cell_PC = new cell_AU();
            Cell_PC.Show();
            Hide();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
