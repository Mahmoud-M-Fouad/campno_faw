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
    public partial class update_hour : Form
    {
        DataBase_code database = new DataBase_code();
        main_code cls = new main_code();
        List<int> all_hours_am = new List<int>{1,2,3,4,5,6,7,8,9,10,11,12};
        List<int> all_hours_pm = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        string date;
        string day;
        public update_hour()
        {
            InitializeComponent();
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_page_title_Click(object sender, EventArgs e)
        {

        }

        private void update_hour_Load(object sender, EventArgs e)
        {
            database.fill_combobox_data_to_search_hour(comboBox_date);


            ///---------------------------------------
            date = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");


            ////--------------
            ///

            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Saturday) day = "السبت";
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Sunday) day = "الأحد";
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Monday) day = "الأثنين";
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Tuesday) day = "الثلاثاء";
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Wednesday) day = "الأربعاء";
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Thursday) day = "الخميس";
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Friday) day = "الجمعة";

            


        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls.only_characters(e);
        }

        private void gunaTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls.only_integers(e);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hour_type = radioButton_pm.Checked ? "مساءاً" : "صباحاً";

            database.fill_combobox_hour_to_search_hour(comboBox_hour, comboBox_date.Text , hour_type);
           


        }

        private void comboBox_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hour_type = radioButton_pm.Checked ? "مساءاً" : "صباحاً";
            database.get_values_of_hour_in_text_boxes(Convert.ToInt32(comboBox_hour.Text), comboBox_date.Text , hour_type, txt_name, txt_phone, txt_hour_res, radioButton_new_hour_pm , radioButton_new_hour_am , l_day, richTextBox_notes, checkBox_weekly , checkBox_money);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {












            manager m = new manager();
            database.View_today_reservations(m.dataGridView_manager);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            string hour_type = radioButton_pm.Checked ? "مساءاً" : "صباحاً";
            database.update_hour_name(txt_name.Text, Convert.ToInt32(comboBox_hour.Text), comboBox_date.Text, hour_type);
        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {
            string hour_type = radioButton_pm.Checked ? "مساءاً" : "صباحاً";
            if(txt_phone.TextLength==11)
            {
                database.update_hour_phone(Convert.ToInt32(txt_phone.Text), Convert.ToInt32(comboBox_hour.Text), comboBox_date.Text, hour_type);
            }
            else
            {
                MessageBox.Show("أدخل رقم الهاتف صحيح ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gunaImageButton4_Click(object sender, EventArgs e)
        {
            string hour_type = radioButton_pm.Checked ? "مساءاً" : "صباحاً";

            string hour_type_new = radioButton_new_hour_pm.Checked ? "مساءاً" : "صباحاً";
            database.update_hour_hour(Convert.ToInt32(txt_hour_res.Text), Convert.ToInt32(comboBox_hour.Text), comboBox_date.Text , hour_type , hour_type_new);
        }

        private void gunaImageButton6_Click(object sender, EventArgs e)
        {
            string hour_type = radioButton_pm.Checked ? "مساءاً" : "صباحاً";
            database.update_hour_notes(richTextBox_notes.Text, Convert.ToInt32(comboBox_hour.Text), comboBox_date.Text , hour_type);
        }

        private void gunaImageButton7_Click(object sender, EventArgs e)
        {
            int check = checkBox_weekly.Checked ? 1 : 0;
            string hour_type = radioButton_pm.Checked ? "مساءاً" : "صباحاً";
            database.update_hour_weekly(check, Convert.ToInt32(comboBox_hour.Text), comboBox_date.Text , hour_type);


            //delete_fixed_hour
        }

        private void gunaImageButton5_Click(object sender, EventArgs e)
        {
            string hour_type = radioButton_pm.Checked ? "مساءاً" : "صباحاً";
            //MessageBox.Show(date);
            //l_day.Text = day;
            database.update_hour_date(date,day, Convert.ToInt32(comboBox_hour.Text), comboBox_date.Text , hour_type);
            l_day.Text = day;
        }

        private void gunaImageButton8_Click(object sender, EventArgs e)
        {
            int check = checkBox_money.Checked ? 1 : 0;
            string hour_type = radioButton_pm.Checked ? "مساءاً" : "صباحاً";
            database.update_hour_money(check, Convert.ToInt32(comboBox_hour.Text), comboBox_date.Text , hour_type);
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

        private void comboBox_ho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_hour_res_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls.only_integers(e);
        }

        private void comboBox_day_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Saturday) day = "السبت";
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Sunday) day = "الأحد";
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Monday) day = "الأثنين";
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Tuesday) day = "الثلاثاء";
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Wednesday) day = "الأربعاء";
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Thursday) day = "الخميس";
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Friday) day = "الجمعة";

            

            ///----------------------------
            ///

            date = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
        }
    }
}
