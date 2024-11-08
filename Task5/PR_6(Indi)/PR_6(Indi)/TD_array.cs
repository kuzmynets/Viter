using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_6_Indi_
{
    public partial class TD_array : Form
    {
        public TD_array()
        {
            InitializeComponent();
        }
        private void TD_array_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            Hide();
        }
        private void повернутисяДоВиборуЗадачToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            Hide();
        }

        private void обчислитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (radioButton_rand.Checked)
            {
                if (dataGridView1.ColumnCount != 0)
                {
                    DialogResult result = MessageBox.Show("Ви точно хочете перезаписати дані?", "Перезапис", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                        return;
                }
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                int.TryParse(textBox_rows.Text, out int rows);
                int.TryParse(textBox_columns.Text, out int columns);
                Columns(rows, columns); // викликає метод для заповнення автоматично

                List<List<double>> list = new List<List<double>>();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    List<double> innerList = new List<double>();
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            if (double.TryParse(dataGridView1.Rows[i].Cells[j].Value.ToString(), out double num))
                            {
                                innerList.Add(num);
                            }
                        }
                    }
                    list.Add(innerList);
                }
                min_element_columns(list); // виклик методу для автоматично заповнених даних
            }
            else if (radioButton_kor.Checked)
            {
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                    column.ReadOnly = true;

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                    column.ReadOnly = false;

                List<List<double>> list = new List<List<double>>();

                if (textBox_rows.Text == string.Empty)
                {
                    MessageBox.Show("Для початку потрібно ввести дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_rows.Focus();
                    return;
                }

                if (textBox_columns.Text == string.Empty)
                {
                    MessageBox.Show("Для початку потрібно ввести дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_columns.Focus();
                    return;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    List<double> innerList = new List<double>();

                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            if (double.TryParse(dataGridView1.Rows[i].Cells[j].Value.ToString(), out double num))
                            {
                                innerList.Add(num);
                            }
                            else
                            {
                                MessageBox.Show("Введено некоректне значення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                j--;
                            }
                        }
                        else
                        {
                            MessageBox.Show("В табличці немає даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    list.Add(innerList);
                }
                min_element_columns(list);
            }
        }

        private void Columns(int rows, int columns)
        {
            if (rows <= 0)
            {
                MessageBox.Show("Введені дані не мають бути меншими або рівними нулю!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_rows.Focus();
                return;
            }

            if (columns <= 0)
            {
                MessageBox.Show("Введені дані не мають бути меншими або рівними нулю!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_columns.Focus();
                return;
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            for (int num = 0; num < columns; num++)
            {
                dataGridView1.Columns.Add("", "");
                dataGridView1.Columns[num].HeaderText = "№" + (num + 1);
            }
            for (int num = 0; num < rows; num++)
            {
                dataGridView1.Rows.Add("", "");
                dataGridView1.Rows[num].HeaderCell.Value = "№" + (num + 1).ToString();
            }
            if (radioButton_kor.Checked)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        string input = InputDialog.Show("Значення для елемента [" + (i + 1) + ", " + (j + 1) + "]");
                        if (double.TryParse(input, out double parsedValue))
                        {
                            dataGridView1.Rows[i].Cells[j].Value = parsedValue.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Введено некоректне значення. Повторіть спробу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            j--; // Повторно запитати введення для цього елемента
                        }
                    }
                }
            }
            else if (radioButton_rand.Checked)
            {
                Random random = new Random();
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        double randomValue = random.NextDouble() * 100; // Заповнення випадковими числами від 0 до 100
                        dataGridView1.Rows[i].Cells[j].Value = randomValue.ToString("F2"); // Форматування до 2 знаків після коми
                    }
                }
            }
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox_columns.Text, out int columns);
            int.TryParse(textBox_rows.Text, out int rows);
            Columns(rows, columns);
        }

        private void radioButton_rand_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            button1.Visible = false;
            groupBox3.Visible = true;
            dataGridView1.ReadOnly = true;
        }

        private void radioButton_kor_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            button1.Visible = true;
            groupBox3.Visible = false;
            dataGridView1.ReadOnly = false;
        }

        private void TD_array_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
        }

        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void записатиУФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(Path.Combine(Directory.GetCurrentDirectory(), "Data_For_ex4.txt")))
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
                using (StreamReader reader = new StreamReader(Path.Combine(Directory.GetCurrentDirectory(), "Data_For_ex4.txt")))
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

        private void Clear()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            textBox_columns.Clear();
            textBox_Do.Clear();
            textBox_rows.Clear();
            textBox_Vid.Clear();
            label1.Text = string.Empty;
        }

        private void min_element_columns(List<List<double>> list)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Дані відсутні", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            double minElement = double.MaxValue;
            List<(int row, int col)> minPositions = new List<(int, int)>();

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Count; j++)
                {
                    if (list[i][j] < minElement)
                    {
                        minElement = list[i][j];
                        minPositions.Clear();
                        minPositions.Add((i + 1, j + 1)); // додавання 1 для порядкових номерів
                    }
                    else if (list[i][j] == minElement)
                    {
                        minPositions.Add((i + 1, j + 1)); // додавання 1 для порядкових номерів
                    }
                }
            }

            string positions = string.Join(", ", minPositions.Select(pos => $"[{pos.row}, {pos.col}]"));
            label1.Text = $"Мінімальний елемент {minElement} знаходиться в позиціях: {positions}";
            MessageBox.Show($"Мінімальний елемент {minElement} знаходиться в позиціях: {positions}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



    }
}

public class InputDialog : Form
{
    private TextBox textBox;
    private Button okButton;

    public InputDialog()
    {
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        textBox = new TextBox();
        okButton = new Button();

        SuspendLayout();

        textBox.Location = new System.Drawing.Point(12, 12);
        textBox.Size = new System.Drawing.Size(200, 20);

        okButton.Location = new System.Drawing.Point(66, 38);
        okButton.Size = new System.Drawing.Size(75, 23);
        okButton.Text = "Далі";
        okButton.DialogResult = DialogResult.OK;

        AcceptButton = okButton;

        AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(224, 73);
        Controls.Add(textBox);
        Controls.Add(okButton);

        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "InputDialog";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Input";
        ResumeLayout(false);
        PerformLayout();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        if (e.CloseReason == CloseReason.UserClosing)
        {
            DialogResult = DialogResult.Cancel;
        }
        base.OnFormClosing(e);
    }

    public static string Show(string caption)
    {
        InputDialog dialog = new InputDialog();
        dialog.Text = caption;
        DialogResult result = dialog.ShowDialog();

        if (result == DialogResult.OK)
        {
            return dialog.textBox.Text;
        }

        return "0";
    }
}

