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
            
        }

        private void radioButton_kor_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void повернутисяДоВиборуЗадачToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void обчислитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void textBox_array_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void записатиУФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void зчитатиЗФайлуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

       

        private void PopulateDataGridView(List<int> numbers)
        {
            
        }

        private void ProcessArray(List<int> numbers)
        {
           
        }

        private void WriteNumbersToFile(List<int> numbers)
        {
            
        }

        private void Clear()
        {
           
        }

        private void textBox_array_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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