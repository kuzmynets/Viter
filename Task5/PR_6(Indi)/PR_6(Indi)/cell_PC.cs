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
            public string num, year, marka, kolir, potuzh,cina;
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
            
        }
        private void повернутисяДоВиборуЗадачToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void Save(object sender, EventArgs e)
        {
            
        }
        private void cell_AU_Load(object sender, EventArgs e)
        {
            
        }


        private void bt_add_Click(object sender, EventArgs e)
        {

            
        }
        private void записатиУToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
        }
        private void зчитатиЗФайлуToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
        }
        private void SearchAndDisplayResults(string searchTerm)
        {
            
        }
        private void radioButtonSortByPower_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonFindCheapestAndLeastPowerful_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonSamePriceDifferentColor_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonPriceOutOfRange_CheckedChanged(object sender, EventArgs e)
        {
            
        }




        private void radioButton_neObm_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void radioButton_Obm_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void radioButton_AU_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        
       
        private void radioButtonAU_search_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void comboBox_search_au_MouseMove(object sender, MouseEventArgs e)
        {
            
        }


        private void очиститиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            
               
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }
        private void bt_delate_Click(object sender, EventArgs e)
        {
           
        }
        private void bt_clear_Click(object sender, EventArgs e)
        {
            
            
        }


        private void newComboBox()
        {
            
        }
        private void Clearing_txtbox()
        {
            

            
        }
        private void create_array()
        {
            
            
        }
        private void FormatData_Comma()
        {
            
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
            
        }
        

        private void ZnaytiNaydeshevshuINaymenshPotuzhnu()
        {
            
        }

    
        private void NaipotuzhnishaChervonogoNaishevshaChornogo()
        {
           
            
           
        }
        private void MarkyZOdnakovoyuTsinoyuTaRiznymyKoloramy()
                {
                    
                }
                private void MarkyZTsinoyuPozaZadanymyMezhamy(int mezhaVid, int mezhaDo)
                {
                    
                }


        private void radioButtonMostPowerfulRedCheapestBlack_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonSortByPower_CheckedChanged_1(object sender, EventArgs e)
        {

            
        }

        private void radioButtonPriceOutOfRange_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        

        private void radioButtonFindCheapestAndLeastPowerful_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void radioButtonSamePriceDifferentColor_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void radioButtonManualSearch_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
