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
    


    public partial class manager : Form
    {
        public static int set_hour;
        public static string set_day = "";
        public static string set_day_in_fixed = "";
        public static string set_month = "";
        public static string set_year = "";
        public static int set_hour_type = 0 ;
        public static string set_hour_day ;
        static main_code cls = new main_code();
       
        public int form_manager_id = 0;

       
        DataBase_code database = new DataBase_code();

        string data = DateTime.Now.ToString("dddd , dd MMMM, yyyy", new CultureInfo("ar-AE"));
       
        string date3;
        string date2;
        public manager()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            form_manager_id = 1;
            panel_pass.Visible = true;
            //---
            hour.add_new_hour c = new hour.add_new_hour() ;
            c.ShowDialog();



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

            form_manager_id = 3;
            panel_pass.Visible = true;



        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

            form_manager_id = 4;
            panel_pass.Visible = true;



        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {


            form_manager_id = 5;
            panel_pass.Visible = true;



        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {

            form_manager_id = 2;
            panel_pass.Visible = true;
           


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void manager_Load(object sender, EventArgs e)
        {
            string El_day = DateTime.Now.ToString("dddd", new CultureInfo("ar-AE"));
           // MessageBox.Show(El_day);
            database.reserv_auto(El_day);

            notifyIcon1.BalloonTipTitle = "Some Title";
            notifyIcon1.BalloonTipText = "Some Notification";
            notifyIcon1.Text = "الملعب";

            ///---------------------------------------------------------

            set_day = dateTimePicker1.Value.Date.ToString("dd");
            set_month = dateTimePicker1.Value.Date.ToString("MM");
            set_year = dateTimePicker1.Value.Date.ToString("yyyy");
            date3 = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            date2 = dateTimePicker1.Value.Date.ToString("dd-MM-yyyy");

            ///

            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Saturday) label_day_.Text = "السبت";
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Sunday) label_day_.Text = "الأحد";
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Monday) label_day_.Text = "الإثنين";
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Tuesday) label_day_.Text = "الثلاثاء";
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Wednesday) label_day_.Text = "الأربعاء";
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Thursday) label_day_.Text = "الخميس";
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Friday) label_day_.Text = "الأربعاء";
            set_day_in_fixed = label_day_.Text;

//            MessageBox.Show()
            ///-----------------------------------------------------
            label_data.Text = data;
            ///-----------------------------------------------------
            database.View_today_reservations(dataGridView_manager);

            ///-----------------------------------------------------

            if (database.return_hour_reserv_or_no(date3, 12, 0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 12, 0)) label_12_am.BackColor = Color.Red; else label_12_am.BackColor = Color.LightGreen;
            if (database.return_hour_reserv_or_no(date3, 1, 0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 1, 0)) label_1_am.BackColor = Color.Red; else label_1_am.BackColor = Color.LightGreen;
            if (database.return_hour_reserv_or_no(date3, 2, 0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 2, 0)) label_2_am.BackColor = Color.Red; else label_2_am.BackColor = Color.LightGreen;
            if (database.return_hour_reserv_or_no(date3, 3, 0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 3, 0)) label_3_am.BackColor = Color.Red; else label_3_am.BackColor = Color.LightGreen;
            if (database.return_hour_reserv_or_no(date3, 4, 0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 4, 0)) label_4_am.BackColor = Color.Red; else label_4_am.BackColor = Color.LightGreen;
            if (database.return_hour_reserv_or_no(date3, 5, 0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 5, 0)) label_5_am.BackColor = Color.Red; else label_5_am.BackColor = Color.LightGreen;
            if (database.return_hour_reserv_or_no(date3, 6, 0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 6, 0)) label_6_am.BackColor = Color.Red; else label_6_am.BackColor = Color.LightGreen;
            if (database.return_hour_reserv_or_no(date3, 7, 0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 7, 0)) label_7_am.BackColor = Color.Red; else label_7_am.BackColor = Color.LightGreen;
            if (database.return_hour_reserv_or_no(date3, 8, 0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 8, 0)) label_8_am.BackColor = Color.Red; else label_8_am.BackColor = Color.LightGreen;
            if (database.return_hour_reserv_or_no(date3, 9, 0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 9, 0)) label_9_am.BackColor = Color.Red; else label_9_am.BackColor = Color.LightGreen;
            if (database.return_hour_reserv_or_no(date3, 10, 0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 10, 0)) label_10_am.BackColor = Color.Red; else label_10_am.BackColor = Color.LightGreen;
            if (database.return_hour_reserv_or_no(date3, 11, 0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 11, 0)) label_11_am.BackColor = Color.Red; else label_11_am.BackColor = Color.LightGreen;


            if (database.return_hour_reserv_or_no(date3, 12, 1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 12, 1)) label_12_pm.BackColor = Color.Red; else label_12_pm.BackColor = Color.LightGreen;
            if (database.return_hour_reserv_or_no(date3, 1, 1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 1, 1)) label_1_pm.BackColor = Color.Red; else label_1_pm.BackColor = Color.LightGreen;
            if (database.return_hour_reserv_or_no(date3, 2, 1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 2, 1)) label_2_pm.BackColor = Color.Red; else label_2_pm.BackColor = Color.LightGreen;
            if (database.return_hour_reserv_or_no(date3, 3, 1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 3, 1)) label_3_pm.BackColor = Color.Red; else label_3_pm.BackColor = Color.LightGreen;
            if (database.return_hour_reserv_or_no(date3, 4, 1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 4, 1)) label_4_pm.BackColor = Color.Red; else label_4_pm.BackColor = Color.LightGreen;
            if (database.return_hour_reserv_or_no(date3, 5, 1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 5, 1)) label_5_pm.BackColor = Color.Red; else label_5_pm.BackColor = Color.LightGreen;
            if (database.return_hour_reserv_or_no(date3, 6, 1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 6, 1)) label_6_pm.BackColor = Color.Red; else label_6_pm.BackColor = Color.LightGreen;
            if (database.return_hour_reserv_or_no(date3, 7, 1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 7, 1)) label_7_pm.BackColor = Color.Red; else label_7_pm.BackColor = Color.LightGreen;
            if (database.return_hour_reserv_or_no(date3, 8, 1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 8, 1)) label_8_pm.BackColor = Color.Red; else label_8_pm.BackColor = Color.LightGreen;
            if (database.return_hour_reserv_or_no(date3, 9, 1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 9, 1)) label_9_pm.BackColor = Color.Red; else label_9_pm.BackColor = Color.LightGreen;
            if (database.return_hour_reserv_or_no(date3, 10, 1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 10, 1)) label_10_pm.BackColor = Color.Red; else label_10_pm.BackColor = Color.LightGreen;
            if (database.return_hour_reserv_or_no(date3, 11, 1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 11, 1)) label_11_pm.BackColor = Color.Red; else label_11_pm.BackColor = Color.LightGreen;


        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;


            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
            { notifyIcon1.Visible = false; }
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Maximized;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void الخروجمنالتطبيقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ok_pass_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(form_manager_id + "");
            if (database.authentication2(txt_pass.Text) && txt_pass.Text != "" )
            {
                if (form_manager_id == 1)
                {
                    hour.add_new_hour c = new hour.add_new_hour();
                    c.ShowDialog();
                    panel_pass.Hide();
                }
                else if (form_manager_id == 2)
                {
                    delete_hour c = new delete_hour();
                    c.ShowDialog();
                    panel_pass.Hide();
                }
                else if (form_manager_id == 3)
                {
                    update_hour c = new update_hour();
                    c.ShowDialog();
                    panel_pass.Hide();
                }
                else if (form_manager_id == 4)
                {
                    search_hour c = new search_hour();
                    c.ShowDialog();
                    panel_pass.Hide();
                }
                else if (form_manager_id == 5)
                {
                    view_all_hour c = new view_all_hour();
                    c.ShowDialog();
                    panel_pass.Hide();
                }
                else if (form_manager_id == 6)
                {
                    hour.delete_all_hour1 c = new hour.delete_all_hour1();
                    c.ShowDialog();
                    panel_pass.Hide();
                }
                txt_pass.Text = "";
            }
            else
            {
                DialogResult result = MessageBox.Show(" كلمة السر خاطئة"
                                            , "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            txt_pass.PasswordChar = checkBox.Checked ? '\0' : '*';
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
           // database.View_today_reservations(dataGridView1);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Refresh();
            Refresh();
            this.Hide();
            manager ss = new manager();
            ss.Show();
           




        }

        private void comboBox_day_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void comboBox_month_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox_year_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton21_Click_2(object sender, EventArgs e)
        { 
            {
               // MessageBox.Show(date2);
                if (database.return_hour_reserv_or_no(date3, 12, 0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 12,0) ) label_12_am.BackColor = Color.Red; else label_12_am.BackColor = Color.LightGreen;
                if (database.return_hour_reserv_or_no(date3, 1, 0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 1, 0)) label_1_am.BackColor = Color.Red; else label_1_am.BackColor = Color.LightGreen;
                if (database.return_hour_reserv_or_no(date3, 2, 0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 2, 0)) label_2_am.BackColor = Color.Red; else label_2_am.BackColor = Color.LightGreen;
                if (database.return_hour_reserv_or_no(date3, 3, 0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 3, 0)) label_3_am.BackColor = Color.Red; else label_3_am.BackColor = Color.LightGreen;
                if (database.return_hour_reserv_or_no(date3, 4, 0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 4, 0)) label_4_am.BackColor = Color.Red; else label_4_am.BackColor = Color.LightGreen;
                if (database.return_hour_reserv_or_no(date3, 5, 0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 5, 0)) label_5_am.BackColor = Color.Red; else label_5_am.BackColor = Color.LightGreen;
                if (database.return_hour_reserv_or_no(date3, 6, 0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 6, 0)) label_6_am.BackColor = Color.Red; else label_6_am.BackColor = Color.LightGreen;
                if (database.return_hour_reserv_or_no(date3, 7, 0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 7, 0)) label_7_am.BackColor = Color.Red; else label_7_am.BackColor = Color.LightGreen;
                if (database.return_hour_reserv_or_no(date3, 8, 0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 8, 0)) label_8_am.BackColor = Color.Red; else label_8_am.BackColor = Color.LightGreen;
                if (database.return_hour_reserv_or_no(date3, 9, 0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 9, 0)) label_9_am.BackColor = Color.Red; else label_9_am.BackColor = Color.LightGreen;
                if (database.return_hour_reserv_or_no(date3, 10, 0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 10, 0)) label_10_am.BackColor = Color.Red; else label_10_am.BackColor = Color.LightGreen;
                if (database.return_hour_reserv_or_no(date3, 11, 0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 11, 0)) label_11_am.BackColor = Color.Red; else label_11_am.BackColor = Color.LightGreen;


                if (database.return_hour_reserv_or_no(date3, 12,1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 12, 1)) label_12_pm.BackColor = Color.Red; else label_12_pm.BackColor = Color.LightGreen;
                if (database.return_hour_reserv_or_no(date3, 1,1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 1, 1)) label_1_pm.BackColor = Color.Red; else label_1_pm.BackColor = Color.LightGreen;
                if (database.return_hour_reserv_or_no(date3, 2,1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 2, 1)) label_2_pm.BackColor = Color.Red; else label_2_pm.BackColor = Color.LightGreen;
                if (database.return_hour_reserv_or_no(date3, 3,1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 3, 1)) label_3_pm.BackColor = Color.Red; else label_3_pm.BackColor = Color.LightGreen;
                if (database.return_hour_reserv_or_no(date3, 4,1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 4, 1)) label_4_pm.BackColor = Color.Red; else label_4_pm.BackColor = Color.LightGreen;
                if (database.return_hour_reserv_or_no(date3, 5,1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 5, 1)) label_5_pm.BackColor = Color.Red; else label_5_pm.BackColor = Color.LightGreen;
                if (database.return_hour_reserv_or_no(date3, 6,1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 6, 1)) label_6_pm.BackColor = Color.Red; else label_6_pm.BackColor = Color.LightGreen;
                if (database.return_hour_reserv_or_no(date3, 7,1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 7, 1)) label_7_pm.BackColor = Color.Red; else label_7_pm.BackColor = Color.LightGreen;
                if (database.return_hour_reserv_or_no(date3, 8,1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 8, 1)) label_8_pm.BackColor = Color.Red; else label_8_pm.BackColor = Color.LightGreen;
                if (database.return_hour_reserv_or_no(date3, 9,1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 9, 1)) label_9_pm.BackColor = Color.Red; else label_9_pm.BackColor = Color.LightGreen;
                if (database.return_hour_reserv_or_no(date3, 10,1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 10,1)) label_10_pm.BackColor = Color.Red; else label_10_pm.BackColor = Color.LightGreen;
                if (database.return_hour_reserv_or_no(date3, 11,1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 11,1)) label_11_pm.BackColor = Color.Red; else label_11_pm.BackColor = Color.LightGreen;

                
            }


        }

        private void label_3_Click(object sender, EventArgs e)
        {
        }

        private void label_12_Click(object sender, EventArgs e)
        {
            if (database.return_hour_reserv_or_no(date3, 12,0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 12, 0))
            {
               
                MessageBox.Show("هذه الساعة محجوزة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
          //      MessageBox.Show(database.return_hour_reserv_or_no(date2, 12).ToString());

                DialogResult dr = MessageBox.Show("هل تريد حجز الساعة  " + " 12 صباحاً" + " يوم   " + date2 +" ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {

                    form_manager_id = 1;
                    panel_pass.Visible = true;
                    set_hour = 12;
                    set_hour_type = 0;
                    set_hour_day = label_day_.Text;

                }



            }
        }

        private void label_13_Click(object sender, EventArgs e)
        {
        
            if (database.return_hour_reserv_or_no(date3, 1,1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 1, 1))
            {
                MessageBox.Show("هذه الساعة محجوزة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult dr = MessageBox.Show("هل تريد حجز الساعة  " + "1 مساءاً" + " يوم   " + date2 + " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    form_manager_id = 1;
                    panel_pass.Visible = true;
                    set_hour = 1;

                    set_hour_type = 1;
                }



            }
        }

        private void label_14_Click(object sender, EventArgs e)
        {

      
            if (database.return_hour_reserv_or_no(date3, 2,1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 2, 1))
            {
                MessageBox.Show("هذه الساعة محجوزة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MessageBox.Show("هل تريد حجز الساعة  " + "2 مساءاً" + " يوم   " + date2 + " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {

                    form_manager_id = 1;
                    panel_pass.Visible = true;
                    set_hour = 2;
                    set_hour_type = 1;
                }



            }
        }

        private void label_15_Click(object sender, EventArgs e)
        {

            if (database.return_hour_reserv_or_no(date3, 3,1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 3, 1))
            {
                MessageBox.Show("هذه الساعة محجوزة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MessageBox.Show("هل تريد حجز الساعة  " + "3 مساءاً" + " يوم   " + date2 + " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {

                    form_manager_id = 1;
                    panel_pass.Visible = true;
                    set_hour = 3;
                    set_hour_type = 1;
                }


            }
        }

        private void label_16_Click(object sender, EventArgs e)
        {
     
            if (database.return_hour_reserv_or_no(date3, 4,1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 4, 1))
            {
                MessageBox.Show("هذه الساعة محجوزة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MessageBox.Show("هل تريد حجز الساعة  " + "4 مساءاً" + " يوم   " + date2 + " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {


                    form_manager_id = 1;
                    panel_pass.Visible = true;
                    set_hour = 4;
                    set_hour_type = 1;
                }



            }
        }

        private void label_17_Click(object sender, EventArgs e)
        {

            if (database.return_hour_reserv_or_no(date3,5,1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 5, 1))
            {
                MessageBox.Show("هذه الساعة محجوزة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult dr = MessageBox.Show("هل تريد حجز الساعة  " + "5 مساءاً" + " يوم   " + date2 + " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    form_manager_id = 1;
                    panel_pass.Visible = true;
                    set_hour = 5;
                    set_hour_type = 1;
                }

            }
        }

        private void label_18_Click(object sender, EventArgs e)
        {
            if (database.return_hour_reserv_or_no(date3,6,1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 6, 1))
            {
                MessageBox.Show("هذه الساعة محجوزة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult dr = MessageBox.Show("هل تريد حجز الساعة  " + "6 مساءاً" + " يوم   " + date2 + " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {

                    form_manager_id = 1;
                    panel_pass.Visible = true;
                    set_hour = 6;
                    set_hour_type = 1;
                }


            }
        }

        private void label_19_Click(object sender, EventArgs e)
        {
            
            if (database.return_hour_reserv_or_no(date3, 7,1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 7, 1))
            {
                MessageBox.Show("هذه الساعة محجوزة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MessageBox.Show("هل تريد حجز الساعة  " + "7 مساءاً" + " يوم   " + date2 + " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    form_manager_id = 1;
                    panel_pass.Visible = true;
                    set_hour = 7;
                    set_hour_type = 1;
                }

            }
        }

        private void label_20_Click(object sender, EventArgs e)
        {

            if (database.return_hour_reserv_or_no(date3, 8,1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 8, 1))
            {
                MessageBox.Show("هذه الساعة محجوزة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                DialogResult dr = MessageBox.Show("هل تريد حجز الساعة  " + "8 مساءاً " + " يوم   " + date2 + " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    form_manager_id = 1;
                    panel_pass.Visible = true;
                    set_hour = 8;
                    set_hour_type = 1;
                }
            }

               
        }

        private void label_21_Click(object sender, EventArgs e)
        {
            if (database.return_hour_reserv_or_no(date3, 9,1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 9, 1))
            {
                MessageBox.Show("هذه الساعة محجوزة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult dr = MessageBox.Show("هل تريد حجز الساعة  " + "9 مساءاً " + " يوم   " + date2 + " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    form_manager_id = 1;
                    panel_pass.Visible = true;
                    set_hour = 9;
                    set_hour_type = 1;
                }


            }
        }

        private void label_22_Click(object sender, EventArgs e)
        {
            if (database.return_hour_reserv_or_no(date3,10,1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 10, 1))
            {
                MessageBox.Show("هذه الساعة محجوزة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MessageBox.Show("هل تريد حجز الساعة  " + "10 مساءاً " + " يوم   " + date2 + " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {

                    form_manager_id = 1;
                    panel_pass.Visible = true;
                    set_hour = 10;
                    set_hour_type = 1;
                }


            }
        }

        private void label_23_Click(object sender, EventArgs e)
        {
            if (database.return_hour_reserv_or_no(date3,11,1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 11, 1))
            {
                MessageBox.Show("هذه الساعة محجوزة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult dr = MessageBox.Show("هل تريد حجز الساعة  " + "11 مساءاً " + " يوم   " + date2 + " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {

                    form_manager_id = 1;
                    panel_pass.Visible = true;
                    set_hour = 11;
                    set_hour_type = 1;
                }


            }
        }

        private void label_24_Click(object sender, EventArgs e)
        {
            
        }

        private void label_1_Click(object sender, EventArgs e)
        {
            
        }

        private void label_2_Click(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void label_data_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(bunifuDatepicker1.da);
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            
            

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            form_manager_id = 6;
            panel_pass.Visible = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Saturday) label_day_.Text = "السبت";
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Sunday) label_day_.Text = "الأحد";
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Monday) label_day_.Text = "الإثنين";
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Tuesday) label_day_.Text = "الثلاثاء";
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Wednesday) label_day_.Text = "الأربعاء";
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Thursday) label_day_.Text = "الخميس";
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Friday) label_day_.Text = "الجمعة";

            //------------------------------------------------------------------------------------------

          set_day = dateTimePicker1.Value.Date.ToString("dd");
          set_month = dateTimePicker1.Value.Date.ToString("MM");
          set_year = dateTimePicker1.Value.Date.ToString("yyyy");
          date3 = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
          date2 = dateTimePicker1.Value.Date.ToString("dd-MM-yyyy");
          set_day_in_fixed = label_day_.Text;
        //------------------------------------------------------------------------------------------



        }

        private void label11_Click(object sender, EventArgs e)
        {

            if (database.return_hour_reserv_or_no(date3, 5,0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 5, 0))
            {
                MessageBox.Show("هذه الساعة محجوزة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MessageBox.Show("هل تريد حجز الساعة  " + "5 صباحاً" + " يوم   " + date2 + " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {

                    form_manager_id = 1;
                    panel_pass.Visible = true;
                    set_hour = 5;
                    set_hour_type = 0;
                    set_hour_day = label_day_.Text;
                }


            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (database.return_hour_reserv_or_no(date2, 4,0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 4, 0))
            {
                MessageBox.Show("هذه الساعة محجوزة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult dr = MessageBox.Show("هل تريد حجز الساعة  " + "4 صباحاً" + " يوم   " + date2 + " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    form_manager_id = 1;
                    panel_pass.Visible = true;
                    set_hour = 4;
                    set_hour_type = 0;
                    set_hour_day = label_day_.Text;
                }


            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (database.return_hour_reserv_or_no(date3, 12,1) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 12, 1))
            {
                MessageBox.Show("هذه الساعة محجوزة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                DialogResult dr = MessageBox.Show("هل تريد حجز الساعة  " + "12 مساءاً" + " يوم   " + date2 + " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    form_manager_id = 1;
                    panel_pass.Visible = true;
                    set_hour =12;
                    set_hour_type = 1;
                }



            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (database.return_hour_reserv_or_no(date3, 3,0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 3, 0))
            {
                MessageBox.Show("هذه الساعة محجوزة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MessageBox.Show("هل تريد حجز الساعة  " + "3 صباحاً" + " يوم   " + date2 + " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {

                    form_manager_id = 1;
                    panel_pass.Visible = true;
                    set_hour = 3;
                    set_hour_type = 0;
                    set_hour_day = label_day_.Text;
                }

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (database.return_hour_reserv_or_no(date3, 1,0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 1, 0))
            {
                MessageBox.Show("هذه الساعة محجوزة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MessageBox.Show("هل تريد حجز الساعة  " + " 1 صباحاً" + " يوم   " + date2 + " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {

                    form_manager_id = 1;
                    panel_pass.Visible = true;
                    set_hour = 1;
                    set_hour_type = 0;
                    set_hour_day = label_day_.Text;
                }

            }

        }

        private void label8_Click(object sender, EventArgs e)
        {


            if (database.return_hour_reserv_or_no(date3, 2,0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 2, 0))
            {
                MessageBox.Show("هذه الساعة محجوزة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MessageBox.Show("هل تريد حجز الساعة  " + " 2 صباحاً" + " يوم   " + date2 + " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {

                    form_manager_id = 1;
                    panel_pass.Visible = true;
                    set_hour = 2;
                    set_hour_type = 0;
                    set_hour_day = label_day_.Text;
                }

            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (database.return_hour_reserv_or_no(date3, 6,0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 6, 0))
            {
                MessageBox.Show("هذه الساعة محجوزة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MessageBox.Show("هل تريد حجز الساعة  " + "6 صباحاً" + " يوم   " + date2 + " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {

                    form_manager_id = 1;
                    panel_pass.Visible = true;
                    set_hour = 6;
                    set_hour_type = 0;
                }

            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

            if (database.return_hour_reserv_or_no(date3, 7,0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 7, 0)) 
            {
                MessageBox.Show("هذه الساعة محجوزة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MessageBox.Show("هل تريد حجز الساعة  " + "7 صباحأ" + " يوم   " + date2 + " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {

                    form_manager_id = 1;
                    panel_pass.Visible = true;
                    set_hour = 7;
                    set_hour_type = 0;
                }

            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

            if (database.return_hour_reserv_or_no(date3, 8,0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 8, 0))
            {
                MessageBox.Show("هذه الساعة محجوزة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MessageBox.Show("هل تريد حجز الساعة  " + "8 صباحاً" + " يوم   " + date2 + " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {

                    form_manager_id = 1;
                    panel_pass.Visible = true;
                    set_hour = 8;
                }

            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

            if (database.return_hour_reserv_or_no(date3,9,0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 9, 0))
            {
                MessageBox.Show("هذه الساعة محجوزة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MessageBox.Show("هل تريد حجز الساعة  " + "9 صباحاً" + " يوم   " + date2 + " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {

                    form_manager_id = 1;
                    panel_pass.Visible = true;
                    set_hour = 9;
                    set_hour_type = 0;
                }

            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

            if (database.return_hour_reserv_or_no(date3, 10,0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 10, 0))
            {
                MessageBox.Show("هذه الساعة محجوزة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MessageBox.Show("هل تريد حجز الساعة  " + "10 صباحاً" + " يوم   " + date2 + " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {

                    form_manager_id = 1;
                    panel_pass.Visible = true;
                    set_hour = 10;
                    set_hour_type = 0;
                }

            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

           

            if (database.return_hour_reserv_or_no(date3, 11,0) || database.return_hour_in_fixed_table_or_no(set_day_in_fixed, 11, 0))
            {
                MessageBox.Show("هذه الساعة محجوزة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MessageBox.Show("هل تريد حجز الساعة  " + "11 صباحاً " + " يوم   " + date2 + " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {

                    form_manager_id = 1;
                    panel_pass.Visible = true;
                    set_hour = 11;
                    set_hour_type = 0;
                }

            }
        }
    }
}
