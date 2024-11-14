using System;
using System.Windows.Forms;

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
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string textToCopy = label6.Text;

            if (!string.IsNullOrEmpty(textToCopy))
            {
                Clipboard.SetText(textToCopy);
                MessageBox.Show("Текст скопійовано в буфер обміну.", "Копіювання", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}