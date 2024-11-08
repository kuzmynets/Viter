using System;
using System.Collections.Generic;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR_6_Indi_
{
    public partial class cell_AU : Form
    {

        struct AU
        {
            public string num, year, marka, kolir, potuzh, cina;
        }
        //struct Compl
        //{
        //    public string num_Aut, year_Aut, mark_Aut,cina_Aut;
        //}


        int n = 0;


        AU au;



        AU[] arr_AU;



        public cell_AU()
        {
            InitializeComponent();
        }
        private void cell_AU_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save(sender, e);
        }
        private void повернутисяДоВиборуЗадачToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save(sender, e);
        }
        private void Save(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Зберегти дані?", "Вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (radioButton_AU.Checked)
                {
                    if (dg_car.RowCount < 1 || dg_car.Rows[0].Cells[0].Value == null)
                    {
                        MessageBox.Show("Таблиця не містить даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Main_Menu form = new Main_Menu();
                        form.Show();
                        Hide();
                        return;
                    }
                    else
                    {
                        записатиУToolStripMenuItem_Click(sender, e);
                        Main_Menu form = new Main_Menu();
                        form.Show();
                        Hide();
                    }
                }
                else
                {



                    записатиУToolStripMenuItem_Click(sender, e);
                    Main_Menu form = new Main_Menu();
                    form.Show();
                    Hide();

                }
            }
            else
            if (result == DialogResult.No)
            {
                Main_Menu form = new Main_Menu();
                form.Show();
                Hide();
            }
        }
        private void cell_AU_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txt_Vid, "Введіть мінімальну суму вартості");
            toolTip1.SetToolTip(txt_Do, "Введіть максимальну суму вартості");
            toolTip1.SetToolTip(txt_search_au, "Введіть назву марок, які хочете знайти");
            toolTip1.SetToolTip(bt_delate, "Для того щоб видалити дані, потрібно виділити всі стовпці в табличці");
            toolTip1.SetToolTip(bt_clear, "Для того щоб видалити дані, потрібно вибрати дані в ComboBox");
            if (radioButton_AU.Checked)
                txt_nameAU.Focus();
            else
                txt_nameAut.Focus();
            dg_car.AllowUserToAddRows = false;

            dg_search.AllowUserToAddRows = false;
        }


        private void bt_add_Click(object sender, EventArgs e)
        {

            if (radioButton_AU.Checked)
            {

                foreach (DataGridViewColumn column in dg_car.Columns)
                    column.ReadOnly = true;

                foreach (DataGridViewColumn column in dg_car.Columns)
                    column.ReadOnly = false;
                if (IsNumeric(txt_cinaAU.Text) == false)
                {
                    MessageBox.Show("Поле ціна має містити лише числові дані!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_cinaAU.Focus();
                    return;
                }
                if (txt_nameAU.Text == string.Empty)
                {
                    MessageBox.Show("Для початку потрібно ввести дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_nameAU.Focus();
                    return;
                }
                if (txt_cinaAU.Text == string.Empty)
                {
                    MessageBox.Show("Для початку потрібно ввести дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_cinaAU.Focus();
                    return;
                }
                if (DT_date.Text == string.Empty)
                {
                    MessageBox.Show("Для початку потрібно ввести дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DT_date.Focus();
                    return;
                }
                if (txt_proceAU.Text == string.Empty)
                {
                    MessageBox.Show("Для початку потрібно ввести дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_proceAU.Focus();
                    return;
                }
                if (txt_typAU.Text == string.Empty)
                {
                    MessageBox.Show("Для початку потрібно ввести дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_typAU.Focus();
                    return;
                }
                if (txt_videoAU.Text == string.Empty)
                {
                    MessageBox.Show("Для початку потрібно ввести дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_videoAU.Focus();
                    return;
                }

                au.num = txt_nameAU.Text;
                au.marka = txt_typAU.Text;
                au.kolir = txt_proceAU.Text;
                au.potuzh = txt_videoAU.Text;

                DateTime selectedDate = DT_date.Value;
                DateTime currentDate = DateTime.Now;

                if (selectedDate > currentDate)
                {
                    MessageBox.Show("Вибрана дата не може бути більшою за поточну дату.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                au.year = selectedDate.ToString("yyyy-MM-dd");
                au.cina = txt_cinaAU.Text;

                dg_car.Rows.Add(au.num, au.marka, au.kolir, au.potuzh, au.year, au.cina);


                create_array();
                newComboBox();
                FormatData_Comma();
                Clearing_txtbox();
            }
            else
            {



                if (IsNumeric(txt_potuzhAuto.Text) == false)
                {
                    MessageBox.Show("Поле ціна має містити лише числові дані!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_potuzhAuto.Focus();
                    return;
                }
                if (txt_nameAut.Text == string.Empty)
                {
                    MessageBox.Show("Для початку потрібно ввести дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_nameAut.Focus();
                    return;
                }
                if (txt_potuzhAuto.Text == string.Empty)
                {
                    MessageBox.Show("Для початку потрібно ввести дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_potuzhAuto.Focus();
                    return;
                }
                if (DT_dateAut.Text == string.Empty)
                {
                    MessageBox.Show("Для початку потрібно ввести дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DT_dateAut.Focus();
                    return;
                }
                if (txt_markAut.Text == string.Empty)
                {
                    MessageBox.Show("Для початку потрібно ввести дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_markAut.Focus();
                    return;
                }
                //compl.num_Aut = txt_nameAut.Text;
                //compl.mark_Aut = txt_markAut.Text;

                DateTime selectedDate = DT_dateAut.Value;
                DateTime currentDate = DateTime.Now;

                if (selectedDate > currentDate)
                {
                    MessageBox.Show("Вибрана дата не може бути більшою за поточну дату.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //compl.year_Aut = selectedDate.ToString("yyyy-MM-dd");
                //compl.cina_Aut = txt_potuzhAuto.Text;



                create_array();
                newComboBox();
                FormatData_Comma();
                Clearing_txtbox();
            }
        }
        private void записатиУToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (radioButton_AU.Checked)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (saveFileDialog1.FileName == null) return;

                    string fileName = saveFileDialog1.FileName;
                    if (!fileName.EndsWith(".au"))
                    {
                        fileName += ".au";
                    }

                    BinaryWriter fout = new BinaryWriter(new FileStream(fileName, FileMode.Create));
                    for (int i = 0; i < dg_car.RowCount; i++)
                    {
                        fout.Write(Convert.ToString(dg_car.Rows[i].Cells[0].Value));
                        fout.Write(Convert.ToString(dg_car.Rows[i].Cells[1].Value));
                        fout.Write(Convert.ToString(dg_car.Rows[i].Cells[2].Value));
                        fout.Write(Convert.ToString(dg_car.Rows[i].Cells[3].Value));
                        fout.Write(Convert.ToString(dg_car.Rows[i].Cells[4].Value));
                        fout.Write(Convert.ToString(dg_car.Rows[i].Cells[5].Value));
                    }
                    fout.Close();
                }
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (saveFileDialog1.FileName == null) return;

                    string fileName = saveFileDialog1.FileName;
                    if (!fileName.EndsWith(".compl"))
                    {
                        fileName += ".compl";
                    }

                    BinaryWriter fout = new BinaryWriter(new FileStream(fileName, FileMode.Create));

                    fout.Close();
                }
            }
        }
        private void зчитатиЗФайлуToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (radioButton_AU.Checked)
            {
                dg_car.Rows.Clear();
                openFileDialog1.Filter = "AU files (*.au)|*.au";
                openFileDialog1.FilterIndex = 1;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog1.FileName == null) return;

                    BinaryReader fin = new BinaryReader(new FileStream(openFileDialog1.FileName, FileMode.Open));
                    n = 0;
                    while (fin.BaseStream.Position != fin.BaseStream.Length)
                    {
                        dg_car.Rows.Add();
                        for (int j = 0; j < 6; j++) dg_car.Rows[n].Cells[j].Value = fin.ReadString();
                        n++;
                    }
                    fin.Close();
                    create_array();
                    newComboBox();
                    if (n > 0) comboBox_search_au.SelectedIndex = 0;
                    MessageBox.Show("Файл завантажено!\nЗчитано " + n + " записів", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {

                openFileDialog2.Filter = "Compl files (*.compl)|*.compl";
                openFileDialog2.FilterIndex = 1;

                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog2.FileName == null) return;

                    BinaryReader fin = new BinaryReader(new FileStream(openFileDialog2.FileName, FileMode.Open));
                    n = 0;
                    while (fin.BaseStream.Position != fin.BaseStream.Length)
                    {


                    }
                    fin.Close();
                    create_array();
                    newComboBox();
                    if (n > 0) comboBox_search_au.SelectedIndex = 0;
                    MessageBox.Show("Файл завантажено!\nЗчитано " + n + " записів", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox_search_au.Text == string.Empty || comboBox_search_au.Items.Count == 1)
            {
                MessageBox.Show("В табличці немає жодних даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (radioButton_AU.Checked)
                    txt_nameAU.Focus();
                else
                    txt_nameAut.Focus();
                return;
            }
            if (dg_search.Rows.Count != 0)
            {
                dg_search.Rows.Clear();
            }

            create_array();

            if (radioButton_Obm.Checked)
            {
                int.TryParse(txt_Vid.Text, out int mezha_vid);
                int.TryParse(txt_Do.Text, out int mezha_do);
                int count_mezhi = 0, count_name = 0;


                if (txt_Vid.Text == string.Empty)
                {
                    MessageBox.Show("Для початку потрібно ввести дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Vid.Focus();
                    return;
                }
                if (txt_Do.Text == string.Empty)
                {
                    MessageBox.Show("Для початку потрібно ввести дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Do.Focus();
                    return;
                }
                if (mezha_vid < 0 || mezha_do < 0)
                {
                    MessageBox.Show("Обмеження в ціні має бути більшим нуля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (mezha_vid > mezha_do)
                {
                    MessageBox.Show("Найменше значення ціни,\n має бути меншим ніж найбільше значення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Vid.Focus();
                    return;
                }


                else if (radioButtonAU_search.Checked)
                {
                    int[] cinaArray = new int[arr_AU.Length];

                    for (int i = 0; i < arr_AU.Length; i++)
                    {
                        string cinaau = arr_AU[i].cina.Replace(",", "").Replace(" ", "");
                        int.TryParse(cinaau, out cinaArray[i]);
                    }
                    for (int i = 0; i < dg_car.RowCount; i++)
                    {
                        if (comboBox_search_au.Text.ToString() == arr_AU[i].marka || txt_search_au.Text.ToString() == arr_AU[i].marka)
                        {
                            if (cinaArray[i] >= mezha_vid && cinaArray[i] <= mezha_do)
                            {
                                count_mezhi++;
                                count_name++;
                                dg_search.Rows.Add(arr_AU[i].marka, arr_AU[i].kolir, arr_AU[i].potuzh, arr_AU[i].year, arr_AU[i].cina);
                                //comboBox_search_au.SelectedIndex = i;
                            }
                        }
                    }
                    if (count_name == 0)
                    {
                        MessageBox.Show($"Даних за назвою *{txt_search_au.Text.ToString()}*", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (count_mezhi == 0)
                    {
                        MessageBox.Show($"Немає даних на проміжку цін: від {mezha_vid}, до {mezha_do}", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    //int[] cinaArray = new int[arr_Compl.Length];
                    //for (int i = 0; i < arr_Compl.Length; i++)
                    //{
                    //    string cinaau = arr_Compl[i].cina_Aut.Replace(",", "").Replace(" ", "");
                    //    int.TryParse(cinaau, out cinaArray[i]);
                    //}


                    if (count_name == 0)
                    {
                        MessageBox.Show($"Даних за назвою *{txt_search_au.Text.ToString()}*", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (count_mezhi == 0)
                    {
                        MessageBox.Show($"Немає даних на проміжку цін: від {mezha_vid}, до {mezha_do}", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            else
            {
                int count_name = 0;
                if (radioButtonAU_search.Checked)
                {
                    for (int i = 0; i < dg_car.RowCount; i++)
                    {
                        if (comboBox_search_au.Text.ToString() == arr_AU[i].marka || txt_search_au.Text.ToString() == arr_AU[i].marka)
                        {
                            count_name++;
                            dg_search.Rows.Add(arr_AU[i].marka, arr_AU[i].kolir, arr_AU[i].potuzh, arr_AU[i].year, arr_AU[i].cina);
                            //comboBox_search_au.SelectedIndex = i;
                        }
                    }
                    if (count_name == 0)
                    {
                        MessageBox.Show($"Даних за назвою *{txt_search_au.Text.ToString()}*", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {

                    if (count_name == 0)
                    {
                        MessageBox.Show($"Даних за назвою *{txt_search_au.Text.ToString()}*", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }

            if (radioButtonSortByPower.Checked)
            {
                SortuvannyaZaPotuzhnistyu();
            }
            else if (radioButtonFindCheapestAndLeastPowerful.Checked)
            {
                ZnaytiNaydeshevshuINaymenshPotuzhnu();
            }
            else if (radioButtonSamePriceDifferentColor.Checked)
            {
                MarkyZOdnakovoyuTsinoyuTaRiznymyKoloramy();
            }
            else if (radioButtonPriceOutOfRange.Checked)
            {
                int mezhaVid = int.Parse(txt_Vid.Text);
                int mezhaDo = int.Parse(txt_Do.Text);
                MarkyZTsinoyuPozaZadanymyMezhamy(mezhaVid, mezhaDo);
            }
            else if (radioButtonManualSearch.Checked)
            {
                string searchTerm = txt_search_au.Text;
                SearchAndDisplayResults(searchTerm);
            }

        }
        private void SearchAndDisplayResults(string searchTerm)
        {
            // Приклад пошуку даних (цей код потрібно замінити на актуальний метод пошуку у вашій базі даних)
            var results = from marka in arr_AU
                          where marka.marka.Contains(searchTerm /*StringComparison.OrdinalIgnoreCase*/)
                          select marka;
            foreach (var result in arr_AU)
            {
                dg_search.Rows.Add(au.marka, au.kolir, au.potuzh, au.year, au.cina);
            }

            //dg_car.DataSource = results.ToList();
        }
        private void radioButtonSortByPower_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSortByPower.Checked)
            {
                SortuvannyaZaPotuzhnistyu();
            }
        }

        private void radioButtonFindCheapestAndLeastPowerful_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFindCheapestAndLeastPowerful.Checked)
            {
                ZnaytiNaydeshevshuINaymenshPotuzhnu();
            }
        }

        private void radioButtonSamePriceDifferentColor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSamePriceDifferentColor.Checked)
            {
                MarkyZOdnakovoyuTsinoyuTaRiznymyKoloramy();
            }
        }

        private void radioButtonPriceOutOfRange_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPriceOutOfRange.Checked)
            {
                int mezhaVid = int.Parse(txt_Vid.Text);
                int mezhaDo = int.Parse(txt_Do.Text);
                MarkyZTsinoyuPozaZadanymyMezhamy(mezhaVid, mezhaDo);
            }
        }




        private void radioButton_neObm_CheckedChanged(object sender, EventArgs e)
        {
            txt_Do.Visible = false;
            txt_Vid.Visible = false;
        }
        private void radioButton_Obm_CheckedChanged(object sender, EventArgs e)
        {
            txt_Vid.Visible = true;
            txt_Do.Visible = true;
        }
        private void radioButton_AU_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAU_search.Checked == false)
                radioButtonAU_search.Checked = true;
            newComboBox();

            dg_car.Visible = true;

            txt_nameAU.TabIndex = 1;
            txt_typAU.TabIndex = 2;
            txt_proceAU.TabIndex = 3;
            txt_videoAU.TabIndex = 4;

            label2.Text = "Процесор";
            label4.Text = "Відеокарта";

            label5.Visible = true;
            label6.Visible = true;
            DT_date.Visible = true;
            txt_cinaAU.Visible = true;
            txt_nameAU.Visible = true;
            txt_proceAU.Visible = true;
            txt_typAU.Visible = true;
            txt_videoAU.Visible = true;

            txt_potuzhAuto.Visible = false;
            DT_dateAut.Visible = false;
            txt_nameAut.Visible = false;
            txt_markAut.Visible = false;
        }


        private void radioButtonAU_search_CheckedChanged(object sender, EventArgs e)
        {
            dg_search.Rows.Clear();

            if (comboBox_search_au.Text != string.Empty)
            {
                comboBox_search_au.Text = string.Empty;
                comboBox_search_au.Items.Clear();
            }

            int i;
            if (dg_car.RowCount == 0) return;
            this.comboBox_search_au.Items.Clear();
            for (i = 0; i < dg_car.RowCount; i++)
                comboBox_search_au.Items.Add(arr_AU[i].marka);
            comboBox_search_au.Items.Add(" ");
            comboBox_search_au.SelectedIndex = 0;

            toolTip1.SetToolTip(txt_search_au, "Введіть назву марок машин, які хочете знайти");
        }
        private void comboBox_search_au_MouseMove(object sender, MouseEventArgs e)
        {
            if (comboBox_search_au.Items.Count == 0)
            {
                toolTip1.SetToolTip(comboBox_search_au, "Для початку потрібно ввести дані в табличку");
                if (radioButton_AU.Checked)
                    txt_nameAU.Focus();
                else
                    txt_nameAut.Focus();
            }
        }


        private void очиститиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (radioButton_AU.Checked)
                dg_car.Rows.Clear();


        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dg_search.Rows.Clear();
        }
        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clearing_txtbox();
            dg_car.Rows.Clear();
            dg_search.Rows.Clear();


            txt_Do.Clear();
            txt_Vid.Clear();
            txt_search_au.Clear();
            comboBox_search_au.Items.Clear();
            comboBox_search_au.Text = string.Empty;

        }
        private void bt_delate_Click(object sender, EventArgs e)
        {
            if (radioButton_AU.Checked)
            {
                if (dg_car.RowCount != 0)
                {
                    if (dg_car.SelectedRows.Count > 0)
                        dg_car.Rows.Remove(dg_car.SelectedRows[0]);
                    else
                        MessageBox.Show("Будь ласка, виділіть рядок в таблиці", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Щоб видалити дані, потрібно їх ввести в табличку", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                MessageBox.Show("Щоб видалити дані, потрібно їх ввести в табличку", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void bt_clear_Click(object sender, EventArgs e)
        {
            if (radioButtonAU_search.Checked)
            {
                if (comboBox_search_au.SelectedIndex >= 0)
                {
                    if (comboBox_search_au.Items.Count > 1)
                    {
                        dg_car.Rows.RemoveAt(comboBox_search_au.SelectedIndex);
                        dg_search.Rows.Clear();

                        comboBox_search_au.Items.RemoveAt(comboBox_search_au.SelectedIndex);
                        if (comboBox_search_au.SelectedIndex < comboBox_search_au.Items.Count)
                            comboBox_search_au.SelectedIndex = comboBox_search_au.SelectedIndex + 1;
                        else
                            comboBox_search_au.SelectedIndex = comboBox_search_au.SelectedIndex - 1;

                    }
                    else
                        MessageBox.Show("ComboBox порожній. Немає елементів для видалення", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Будь ласка, виберіть елемент у ComboBox для видалення", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (comboBox_search_au.SelectedIndex >= 0)
                {
                    if (comboBox_search_au.Items.Count > 1)
                    {

                        dg_search.Rows.Clear();
                        comboBox_search_au.Items.RemoveAt(comboBox_search_au.SelectedIndex);
                        if (comboBox_search_au.SelectedIndex < comboBox_search_au.Items.Count)
                            comboBox_search_au.SelectedIndex = comboBox_search_au.SelectedIndex + 1;
                        else
                            comboBox_search_au.SelectedIndex = comboBox_search_au.SelectedIndex - 1;
                    }
                    else
                        MessageBox.Show("ComboBox порожній. Немає елементів для видалення", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Будь ласка, виберіть елемент у ComboBox для видалення", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void newComboBox()
        {
            if (radioButton_AU.Checked)
            {
                int i;
                if (dg_car.RowCount == 0) return;
                this.comboBox_search_au.Items.Clear();
                for (i = 0; i < dg_car.RowCount; i++)
                    comboBox_search_au.Items.Add(arr_AU[i].marka);
                comboBox_search_au.Items.Add(" ");
                comboBox_search_au.SelectedIndex = 0;
            }
            else
            {
                //int i;

                this.comboBox_search_au.Items.Clear();

                //comboBox_search_au.Items.Add(arr_Compl[i].mark_Aut);
                comboBox_search_au.Items.Add(" ");
                comboBox_search_au.SelectedIndex = 0;
            }
        }
        private void Clearing_txtbox()
        {
            txt_cinaAU.Clear();
            DT_date.Text = string.Empty;
            txt_nameAU.Clear();
            txt_proceAU.Clear();
            txt_typAU.Clear();
            txt_videoAU.Clear();

            txt_nameAU.Focus();


        }
        private void create_array()
        {
            if (radioButton_AU.Checked)
            {
                arr_AU = new AU[dg_car.RowCount];
                for (int i = 0; i < dg_car.RowCount; i++)
                {
                    arr_AU[i].num = Convert.ToString(dg_car.Rows[i].Cells[0].Value);
                    arr_AU[i].marka = Convert.ToString(dg_car.Rows[i].Cells[1].Value);
                    arr_AU[i].kolir = Convert.ToString(dg_car.Rows[i].Cells[2].Value);
                    arr_AU[i].potuzh = Convert.ToString(dg_car.Rows[i].Cells[3].Value);
                    arr_AU[i].year = Convert.ToString(dg_car.Rows[i].Cells[4].Value);
                    arr_AU[i].cina = Convert.ToString(dg_car.Rows[i].Cells[5].Value);
                }
            }

        }
        private void FormatData_Comma()
        {
            if (radioButton_AU.Checked)
            {
                foreach (DataGridViewRow row in dg_car.Rows)
                {
                    if (row.Cells[5].Value != null)
                    {
                        string value = row.Cells[5].Value.ToString();
                        if (int.TryParse(value, out int intValue))
                        {
                            string formattedValue = intValue.ToString("N0");
                            row.Cells[5].Value = formattedValue;
                        }
                    }
                }
            }
            else
            {

            }
        }
        private bool IsNumeric(string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;

            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }

        private void comboBox_search_au_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_search_au_TextChanged(object sender, EventArgs e)
        {

        }

        private void dg_search_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_car_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void SortuvannyaZaPotuzhnistyu()
        {
            if (radioButton_AU.Checked)
            {
                Array.Sort(arr_AU, (x, y) => x.potuzh.CompareTo(y.potuzh));
                //dg_car.Rows.Clear();
                foreach (var au in arr_AU)
                {
                    dg_search.Rows.Add(au.marka, au.kolir, au.potuzh, au.year, au.cina);
                }
            }
            //else
            //{
            //    Array.Sort(arr_Compl, (x, y) => x.cina_Aut.CompareTo(y.cina_Aut));

            //}
        }


        private void ZnaytiNaydeshevshuINaymenshPotuzhnu()
        {
            string marka = comboBox_search_au.Text.Trim();
            if (radioButton_AU.Checked)
            {
                if (string.IsNullOrWhiteSpace(marka))
                {
                    MessageBox.Show("Будь ласка, виберіть марку.");
                    return;
                }

                var filteredaus = arr_AU.Where(au => string.Equals(au.marka, marka, StringComparison.OrdinalIgnoreCase));
                if (filteredaus.Any())
                {

                    var cheapestau = filteredaus.OrderBy(au => au.cina).FirstOrDefault();

                    var leastPowerfulau = filteredaus.OrderBy(au => au.potuzh).FirstOrDefault();

                    if (cheapestau.cina != null && leastPowerfulau.potuzh != null)
                    {
                        MessageBox.Show($"Найдешевший: {cheapestau.marka} {cheapestau.cina}, Найменш потужний: {leastPowerfulau.marka} {leastPowerfulau.potuzh}");
                    }
                    else
                    {
                        MessageBox.Show("Не знайдено валідних значень ціни або потужності.");
                    }
                }
                else
                {
                    MessageBox.Show("Марка не знайдена.");
                }
            }
        }


        private void NaipotuzhnishaChervonogoNaishevshaChornogo()
        {
            var mostPowerfulRed = arr_AU.Where(au => au.kolir.ToLower() == "червоний").OrderByDescending(au => au.potuzh).FirstOrDefault();
            var cheapestBlack = arr_AU.Where(au => au.kolir.ToLower() == "чорний").OrderBy(au => au.cina).FirstOrDefault();

            if (mostPowerfulRed.potuzh != null)
            {
                dg_search.Rows.Clear();
                dg_search.Rows.Add(au.marka, au.kolir, au.potuzh, au.year, au.cina);
                MessageBox.Show($"Найпотужніша червоного кольору: {mostPowerfulRed.marka} {mostPowerfulRed.potuzh}");

            }
            else
            {
                MessageBox.Show("Немає червоного авто.");
            }

            if (cheapestBlack.cina != null)
            {

                MessageBox.Show($"Найдешевша чорного кольору: {cheapestBlack.marka} {cheapestBlack.cina}");

            }
            else
            {
                MessageBox.Show("Немає чорного aвто.");
            }

        }
        private void MarkyZOdnakovoyuTsinoyuTaRiznymyKoloramy()
        {
            var groupedByPrice = arr_AU.GroupBy(au => au.cina)
                .Where(group => group.Select(au => au.kolir).Distinct().Count() > 1);
            dg_search.Rows.Clear();
            foreach (var group in groupedByPrice)
            {
                foreach (var au in group)
                {
                    dg_search.Rows.Add(au.marka, au.kolir, au.potuzh, au.year, au.cina);
                }
            }
        }
        private void MarkyZTsinoyuPozaZadanymyMezhamy(int mezhaVid, int mezhaDo)
        {
            var outOfRangeaus = arr_AU.Where(au => string.Compare(au.cina, mezhaVid.ToString()) < 0 || string.Compare(au.cina, mezhaDo.ToString()) > 0);

            dg_search.Rows.Clear();
            foreach (var au in outOfRangeaus)
            {
                dg_search.Rows.Add(au.marka, au.kolir, au.potuzh, au.year, au.cina);
            }
        }


        private void radioButtonMostPowerfulRedCheapestBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMostPowerfulRedCheapestBlack.Checked)
            {
                txt_Vid.Visible = false;
                txt_Do.Visible = false;
                groupBox3.Visible = false;
                NaipotuzhnishaChervonogoNaishevshaChornogo();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonSortByPower_CheckedChanged_1(object sender, EventArgs e)
        {

            txt_Vid.Visible = false;
            txt_Do.Visible = false;
            groupBox3.Visible = false;
        }

        private void radioButtonPriceOutOfRange_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_Vid.Visible = true;
            txt_Do.Visible = true;
            groupBox3.Visible = true;
        }



        private void radioButtonFindCheapestAndLeastPowerful_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_Vid.Visible = false;
            txt_Do.Visible = false;
            groupBox3.Visible = false;
        }

        private void radioButtonSamePriceDifferentColor_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_Vid.Visible = false;
            txt_Do.Visible = false;
            groupBox3.Visible = false;
        }

        private void radioButtonManualSearch_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}