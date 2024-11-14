using System;
<<<<<<< HEAD
using System.Windows.Forms;
=======
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
>>>>>>> 2e2eeb019f6b547595dabc3285ec49c9359c4391

namespace PR_6_Indi_
{
    public partial class About_program : Form
    {
        public About_program()
        {
            InitializeComponent();
        }
        private void About_program_FormClosing(object sender, FormClosingEventArgs e)
        {
<<<<<<< HEAD
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            Hide();
        }
        private void About_program_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button2, "Натисніть для копіювання нікнейму");
=======
            
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void About_program_Load(object sender, EventArgs e)
        {
           
>>>>>>> 2e2eeb019f6b547595dabc3285ec49c9359c4391
        }


        private void button2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            string textToCopy = label6.Text;

            if (!string.IsNullOrEmpty(textToCopy))
            {
                Clipboard.SetText(textToCopy);
                MessageBox.Show("Текст скопійовано в буфер обміну.", "Копіювання", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
=======
            

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
>>>>>>> 2e2eeb019f6b547595dabc3285ec49c9359c4391
