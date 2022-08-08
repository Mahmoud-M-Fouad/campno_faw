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
    public partial class delete_hour : Form
    {
        DataBase_code database = new DataBase_code();
        public delete_hour()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_page_title_Click(object sender, EventArgs e)
        {

        }

        private void delete_hour_Load(object sender, EventArgs e)
        {
            database.fill_combobox_data_to_search_hour(comboBox_date);
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hour_type = radioButton_pm.Checked ? "مساءاً" : "صباحاً";
            database.fill_combobox_hour_to_search_hour(comboBox_hour, comboBox_date.Text, hour_type);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hour_type = radioButton_pm.Checked ? "مساءاً" : "صباحاً";
            database.View_name_reservations_about_hour(dataGridView, comboBox_hour.Text.ToString(), comboBox_date.Text.ToString() , hour_type);
        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {


           if(comboBox_date.Text!="" && comboBox_hour.Text!="")
            {
                if (database.validation_delete_fixed_hour() || database.validation_delete_hour())
                {
                    string hour_type = radioButton_pm.Checked ? "مساءاً" : "صباحاً";
                    database.delete_hour(comboBox_date.Text.ToString(), Convert.ToInt32(comboBox_hour.Text.ToString()), hour_type);
                    database.View_name_reservations_about_hour(dataGridView, comboBox_hour.Text.ToString(), comboBox_date.Text.ToString(), hour_type);

                }
                else
                {
                    MessageBox.Show("لا يوجد ساعات ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           else
            {
                MessageBox.Show("أدخل بيانات البيانات كاملة" , "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


           // manager m = new manager();
           // database.View_today_reservations(m.dataGridView_manager);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            string hour_type = radioButton_pm.Checked ? "مساءاً" : "صباحاً";
            database.View_name_reservations_about_hour(dataGridView, comboBox_hour.Text.ToString(), comboBox_date.Text.ToString() , hour_type);
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
