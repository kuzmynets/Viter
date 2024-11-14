using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace PR_6_Indi_
{
    public partial class ArrayForm : Form
    {
        public ArrayForm()
        {
            InitializeComponent();
        }

        private void ArrayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            Hide();
        }

        private void radioButton_rand_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Mezhi.Visible = true;
            textBox_Do.Visible = true;
            textBox_Vid.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = false;
            textBox_array.Visible = false;
            Clear();
        }

        private void radioButton_kor_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Mezhi.Visible = false;
            textBox_Do.Visible = false;
            textBox_Vid.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = true;
            textBox_array.Visible = true;
            Clear();
        }

        private void повернутисяДоВиборуЗадачToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            Hide();
        }

        private void обчислитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.ColumnCount != 0)
            {
                DialogResult result = MessageBox.Show("Ви точно хочете перезаписати дані?", "Перезапис", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
            }
            dataGridView1.Columns.Clear();
            List<int> numbers;

            if (radioButton_rand.Checked)
            {
                numbers = GenerateRandomNumbers();
            }
            else
            {
                numbers = GetNumbersFromInput();
            }

            if (numbers == null) return;

            PopulateDataGridView(numbers);
            ProcessArray(numbers);
            WriteNumbersToFile(numbers);
        }

        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void textBox_array_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void записатиУФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(Path.Combine(Directory.GetCurrentDirectory(), "Data_For_ex3(DataGrid).txt")))
                {
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        writer.Write(dataGridView1.Columns[i].HeaderText);
                        if (i < dataGridView1.Columns.Count - 1)
                        {
                            writer.Write("\t");
                        }
                    }
                    writer.WriteLine();

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DataGridViewRow row = dataGridView1.Rows[i];
                        for (int j = 0; j < row.Cells.Count; j++)
                        {
                            writer.Write(row.Cells[j].Value);
                            if (j < row.Cells.Count - 1)
                            {
                                writer.Write("\t");
                            }
                        }
                        writer.WriteLine();
                    }
                }

                MessageBox.Show("Значення успішно записані у файл.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка під час запису у файл: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void зчитатиЗФайлуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader reader = new StreamReader(Path.Combine(Directory.GetCurrentDirectory(), "Data_For_ex3(DataGrid).txt")))
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    string headerLine = reader.ReadLine();
                    string[] headers = headerLine.Split('\t');

                    foreach (string header in headers)
                    {
                        dataGridView1.Columns.Add(header, header);
                    }

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split('\t');
                        dataGridView1.Rows.Add(values);
                    }
                }

                MessageBox.Show("Значення успішно зчитані з файлу.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка під час зчитування файлу: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<int> GenerateRandomNumbers()
        {
            if (!int.TryParse(textBox_Mezhi.Text, out int mezhi) || mezhi <= 0)
            {
                MessageBox.Show("Некоректно введена кількість елементів", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_Mezhi.Focus();
                return null;
            }
            if (!int.TryParse(textBox_Vid.Text, out int minValue) || !int.TryParse(textBox_Do.Text, out int maxValue) || minValue >= maxValue)
            {
                MessageBox.Show("Некоректно введений діапазон створення масиву", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_Vid.Focus();
                return null;
            }

            Random random = new Random();
            List<int> numbers = new List<int>(mezhi);
            for (int i = 0; i < mezhi; i++)
            {
                numbers.Add(random.Next(minValue, maxValue + 1));
            }
            return numbers;
        }

        private List<int> GetNumbersFromInput()
        {
            string[] numberStrings = textBox_array.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> numbers = new List<int>(numberStrings.Length);

            if (textBox_array.Text == string.Empty)
            {
                MessageBox.Show("Для початку потрібно ввести дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_array.Focus();
                return null;
            }

            foreach (string numStr in numberStrings)
            {
                if (int.TryParse(numStr, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    MessageBox.Show($"Некоректно введене значення: {numStr}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_array.Focus();
                    return null;
                }
            }
            return numbers;
        }

        private void PopulateDataGridView(List<int> numbers)
        {
            dataGridView1.Columns.Clear();
            for (int i = 0; i < numbers.Count; i++)
            {
                dataGridView1.Columns.Add("Column" + i, (i + 1).ToString());
            }

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            for (int i = 0; i < numbers.Count; i++)
            {
                row.Cells[i].Value = numbers[i];
            }
            dataGridView1.Rows.Add(row);
        }

        private void ProcessArray(List<int> numbers)
        {
            int sumOfPositive = numbers.Where(x => x > 0).Sum();
            int countInRange = numbers.Count(x => x > 0 && x < 3);
            int maxOddIndexValue = int.MinValue;

            for (int i = 1; i < numbers.Count; i += 1)
            {
                if (numbers[i] > maxOddIndexValue && numbers[i]%2!=0)
                {
                    maxOddIndexValue = numbers[i];
                }
            }

            label1.Text = $"Сума додатніх елементів: {sumOfPositive}";
            label2.Text = $"Кількість елементів у діапазоні (0, 3): {countInRange}";
            label3.Text = maxOddIndexValue == int.MinValue ? "Немає елементів з непарним індексом" : $"Найбільший елемент з непарним індексом: {maxOddIndexValue}";
        }

        private void WriteNumbersToFile(List<int> numbers)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(Path.Combine(Directory.GetCurrentDirectory(), "Data_For_ex3.txt")))
                {
                    writer.WriteLine(string.Join("\t", numbers));

                    writer.WriteLine(label1.Text); // Сума додатніх елементів
                    writer.WriteLine(label2.Text); // Кількість елементів у діапазоні (0, 3)
                    writer.WriteLine(label3.Text); // Найбільший елемент з непарним індексом

                    if (radioButton_rand.Checked)
                    {
                        writer.WriteLine("\nМежі: " + textBox_Mezhi.Text);
                        writer.WriteLine("Від: " + textBox_Vid.Text);
                        writer.WriteLine("До: " + textBox_Do.Text);
                    }
                }

                MessageBox.Show("Числа успішно записані у файл.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка під час запису у файл: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            textBox_Do.Clear();
            textBox_Mezhi.Clear();
            textBox_Vid.Clear();
            textBox_array.Clear();
            label1.Text = string.Empty;
            label2.Text = string.Empty;
            label3.Text = string.Empty;
        }

        private void textBox_array_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



//порівняй цей код з цим, і розпиши шо там змінено

//перероби будь ласка цей код під умову яка вище

//Заданий одновимірний цілочисельний масив ST з довільною 
//кількістю елементів, значення елементів вводяться користувачем з 
//клавіатури та записуються в файл. Виконати опрацювання масиву 
//у відповідності з заданим варіантом завдання. 
//Знайти: 
//1.суму додатних елементів масиву;
//2.обчислити кількість елементів масиву, для яких 
//виконується нерівність 0<STi<3 
//3. найбільший із елементів з непарним номером;