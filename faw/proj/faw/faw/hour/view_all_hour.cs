using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faw
{
    public partial class view_all_hour : Form
    {
        DataBase_code database = new DataBase_code();
        public view_all_hour()
        {
            InitializeComponent();
        }

        private void view_all_hour_Load(object sender, EventArgs e)
        {
            database.fill_combobox_data_to_search_hour(comboBox_date);
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void label_page_title_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (checkBox_weekly.Checked)
            {
                database.View_all_fixed_reservations_about_any_day(dataGridView, comboBox_date.Text.ToString());
            }
            else
            {
                database.View_all_reservations_about_any_data(dataGridView, comboBox_date.Text.ToString());
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_weekly_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_weekly.Checked)
            {
                database.fill_combobox_day_to_search_fixed_hour(comboBox_date);
            }
            else
            {
                database.fill_combobox_data_to_search_hour(comboBox_date);
            }
        }
    }
}
