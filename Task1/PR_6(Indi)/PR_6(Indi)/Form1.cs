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
           
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
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


       


        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
