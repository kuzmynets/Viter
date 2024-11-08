using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_6_Indi_
{
    public partial class Tab_function : Form
    {
        public Tab_function()
        {
            InitializeComponent();
        }

        private void Tab_function_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
        }

        private void Tab_function_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBo_Step, "Не може бути від'ємний");
            toolTip1.SetToolTip(listBox1, "Спочатку протабулюйте функцію");
        }

        private void створитиДоВиборуЗадачToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            this.Hide();
        }

        private void протабулюватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (!isCorect())
                MessageBox.Show("Некоректно введені дані", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Question);
            else
            {
                double.TryParse(textBox_L.Text, out double xLeft);
                double.TryParse(textBox_R.Text, out double xRight);
                double.TryParse(textBo_Step.Text, out double xStep);
                if (xLeft < xRight && xStep > 0)
                    tab(xLeft, xRight, xStep);
                else if (xLeft > xRight && xStep < 0)
                    tab(xRight, xLeft, -xStep);
                else if (xLeft > xRight && xStep > xRight)
                {
                    MessageBox.Show("Ліва межа має бути більшою ніж права!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    textBox_R.Focus();
                }
            }
            if (listBox1.Text != string.Empty)
            {
                MessageBox.Show("Дані успішно записані у файл", "Запис", MessageBoxButtons.OK, MessageBoxIcon.Information);
                toolTip1.SetToolTip(listBox1, "Функція протабульована");
            }
            else
                toolTip1.SetToolTip(listBox1, "Спочатку протабулюйте функцію");
        }

        private void tab(double xLeft, double xRight, double xStep)
        {
            var file = new StreamWriter(Path.Combine(Directory.GetCurrentDirectory(), "tab.txt"));
            double y = 0, sum = 0;
            int count = 0;
            listBox1.Items.Add("x\ty");
            file.WriteLine("x\ty");
            for (double i = xLeft; i <= xRight; i += xStep)
            {
                y = Math.Sin(2 * i) / (1 + Math.Pow(i, 2));
                chart1.Series[0].Points.AddXY(i, y);
                if (y < 0)
                {
                    sum += y;
                }
                if (y > 0)
                {
                    count++;
                }
                listBox1.Items.Add(i.ToString("F2") + "\t" + y.ToString("F2"));
                file.WriteLine(i.ToString("F2") + "\t" + y.ToString("F2"));
            }
            listBox1.Items.Add("\nКількість при y > 0\tСума при y < 0\n");
            file.WriteLine("\nКількість при y > 0\tСума при y < 0\n");
            listBox1.Items.Add(count.ToString() + "\t\t\t" + sum.ToString("F2"));
            file.WriteLine(count.ToString() + "\t\t\t" + sum.ToString("F2"));
            file.Close();
        }

        private bool isCorect()
        {
            return double.TryParse(textBox_L.Text, out double xLeft) &&
                   double.TryParse(textBox_R.Text, out double xRight) &&
                   double.TryParse(textBo_Step.Text, out double xStep) &&
                   xStep != 0;
        }

        private void очищенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_L.Clear();
            textBox_R.Clear();
            textBo_Step.Clear();
            listBox1.Items.Clear();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}