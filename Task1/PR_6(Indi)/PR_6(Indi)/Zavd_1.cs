using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR_6_Indi_
{
    public partial class Zavd_1 : Form
    {
        public Zavd_1()
        {
            InitializeComponent();
        }

        private void Zavd_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
        }
        private void Zavd_1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox1, "Введіть кут β");
            toolTip1.SetToolTip(textBox2, "Введіть кут γ");
            toolTip1.SetToolTip(textBox3, "Введіть сторону а");
        }
        private void повернутисяДоВиборуЗадачToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            Hide();
        }


        //перевірити
        private void обчислитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                if (!IsCorect())
                {
                    MessageBox.Show("Введені некоректні дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double.TryParse(textBox1.Text, out double a);
                    double.TryParse(textBox2.Text, out double b);
                    double.TryParse(textBox3.Text, out double c);


                    textBox4.Text = (2 * (a * b + b * c + a * c)).ToString("F3");

                }
            }
            else if (radioButton2.Checked)
            {
                if (!IsCorect2())
                {
                    MessageBox.Show("Введені некоректні дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                double.TryParse(textBox1.Text, out double r);


                textBox4.Text = (4 * Math.PI * r * r).ToString("F3");



            }
            else if (radioButton3.Checked)
            {
                if (!IsCorect3())
                {
                    MessageBox.Show("Введені некоректні дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                double.TryParse(textBox1.Text, out double r);
                double.TryParse(textBox2.Text, out double h);



                textBox4.Text = (2 * Math.PI * r * r + 2 * Math.PI * r * h).ToString("F3");


            }
            else if (radioButton4.Checked)
            {
                if (!IsCorect4())
                {
                    MessageBox.Show("Введені некоректні дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                double.TryParse(textBox1.Text, out double r);
                double.TryParse(textBox2.Text, out double l);



                textBox4.Text = (Math.PI * r * r + Math.PI * r * l).ToString("F3");
            }

        }


        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;

            label2.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            textBox3.Visible = true;
            label1.Text = "Введіть a:";
            label2.Text = "Введіть b:";
            label3.Text = "Введіть c:";
            label8.Text = "Площа S:";
            toolTip1.SetToolTip(textBox1, "Введіть ребро a");
            toolTip1.SetToolTip(textBox2, "Введіть ребро в");
            toolTip1.SetToolTip(textBox3, "Введіть ребро с");
            label8.Location = new Point(426, 283);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();

            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;

            label2.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            textBox3.Visible = false;
            textBox4.Clear();
            label1.Text = "Введіть r:";
            label8.Text = "Площа сфери:";
            toolTip1.SetToolTip(textBox1, "Введіть r");
            label8.Location = new Point(426, 283);
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;

            label2.Visible = true;
            textBox2.Visible = true;
            label3.Visible = false;
            textBox3.Visible = false;

            label1.Text = "Введіть r:";
            label2.Text = "Введіть h:";

            label8.Text = "Площа поверхні циліндра:";


            toolTip1.SetToolTip(textBox1, "Введіть радіус r");
            toolTip1.SetToolTip(textBox2, "Введіть висоту h");

            label8.Location = new Point(335, 279);
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;

            label2.Visible = true;
            textBox2.Visible = true;
            label3.Visible = false;
            textBox3.Visible = false;

            label1.Text = "Введіть r:";
            label2.Text = "Введіть l:";

            label8.Text = "Площа поверхні конуса:";


            toolTip1.SetToolTip(textBox1, "Введіть радіус r");
            toolTip1.SetToolTip(textBox2, "Введіть висоту l");

            label8.Location = new Point(335, 279);
        }

        private void записатиУФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(Path.Combine(Directory.GetCurrentDirectory(), "Data_For_ex1.txt")))
                {

                    if (radioButton1.Checked)
                    {
                        writer.WriteLine("Сторона b: " + textBox4.Text.ToString());

                    }
                    else if (radioButton2.Checked)
                    {
                        writer.WriteLine("Сторона с: " + textBox4.Text.ToString());

                    }
                    else
                    {
                        writer.WriteLine("Кут α: " + textBox4.Text.ToString());

                    }
                }

                MessageBox.Show("Числа успішно записані у файл.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка під час запису у файл: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void очищенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private bool IsCorect()
        {
            return double.TryParse(textBox1.Text, out double a) &&
        double.TryParse(textBox2.Text, out double b) &&
        double.TryParse(textBox3.Text, out double c);
        }

        private bool IsCorect2()
        {
            return double.TryParse(textBox1.Text, out double r);
        }

        private bool IsCorect3()
        {
            return double.TryParse(textBox1.Text, out double r) &&
        double.TryParse(textBox2.Text, out double h);
        }
        private bool IsCorect4()
        {
            return double.TryParse(textBox1.Text, out double r) &&
        double.TryParse(textBox2.Text, out double l);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void обчисленняToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}