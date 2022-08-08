using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faw
{
    public partial class search_hour : Form
    {
        DataBase_code database = new DataBase_code();
        public search_hour()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label_page_title_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search_hour_Load(object sender, EventArgs e)
        {
            string data = "2022-08-01";
            comboBox_date.Text = data.ToString();
            database.fill_combobox_data_to_search_hour(comboBox_date);
        }

        private void comboBox_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hour_type = radioButton_pm.Checked ? "مساءاً" : "صباحاً";
            database.fill_combobox_hour_to_search_hour(comboBox_hour,comboBox_date.Text , hour_type);
        }

        private void comboBox_name_SelectedIndexChanged(object sender, EventArgs e)

        {
            string hour_type = radioButton_pm.Checked ? "مساءاً" : "صباحاً";
            // MessageBox.Show(comboBox_name.Text.ToString() + "  " + comboBox_date.Text.ToString());
            database.View_name_reservations_about_hour(dataGridView, comboBox_hour.Text.ToString(), comboBox_date.Text.ToString() , hour_type);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_am_CheckedChanged(object sender, EventArgs e)
        {
            string hour_type = radioButton_pm.Checked ? "مساءاً" : "صباحاً";
            database.fill_combobox_hour_to_search_hour(comboBox_hour, comboBox_date.Text, hour_type);
        }

        private void radioButton_pm_CheckedChanged(object sender, EventArgs e)
        {
            string hour_type = radioButton_pm.Checked ? "مساءاً" : "صباحاً";
            database.fill_combobox_hour_to_search_hour(comboBox_hour, comboBox_date.Text, hour_type);
        }
    }
}
