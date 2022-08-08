using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faw.hour
{
    public partial class add_new_hour : Form
    {
        main_code cls = new main_code();
        string day = manager.set_day;
        string month = manager.set_month;
        string year = manager.set_year;
        int hour = manager.set_hour;
        string hour_type;
        manager m = new manager ();
        string date;
        string hour_day;
        DataBase_code database = new DataBase_code();
        public add_new_hour()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            try
            {
                int weekly = checkBox_weekly.Checked ? 1 : 0;
                hour_type = manager.set_hour_type == 1 ? "مساءاً" : "صباحاً";
                hour_day = manager.set_hour_day;

                if (txt_name.Text != "" && txt_phone.TextLength==11)
                {

                   // MessageBox.Show(hour_day);

                   if (database.return_hour_in_fixed_table_or_no(hour_day , hour, manager.set_hour_type))
                    {
                        MessageBox.Show("هذه الساعة محجوزة إسبوعى ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   else
                    {
                        database.Reserve_an_hour(txt_name.Text, txt_phone.Text, hour, date, manager.set_day_in_fixed, richTextBox_notes.Text, weekly, hour_type);
                        database.View_today_reservations(m.dataGridView_manager);
                       if(checkBox_weekly.Checked)
                        {
                            int id = database.return_id(hour, date, hour_type);
                            database.Reserve_fixed_hour(id, hour, manager.set_day_in_fixed, hour_type);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("يوجد مشكلة فى الأسم أو الهاتف غير صحيح ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show("بيانات غير صالحة"
                               , "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_Load(object sender, EventArgs e)
        {
             date = year + '-' + month + '-' + day;

            //-----------
            label_no.Text = database.return_count_reserv(date).ToString();
            label_hour.Text = hour.ToString();
            label_date.Text =  date;
            
        }

        private void label_hour_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls.only_characters(e);
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls.only_integers(e);
        }

        private void checkBox_weekly_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
