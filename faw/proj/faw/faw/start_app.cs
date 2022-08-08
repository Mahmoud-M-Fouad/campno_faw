using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Collections.Specialized;
using System.IO;

namespace faw
{
    public partial class start_app : Form
    {
        main_code cls = new main_code();
        DataBase_code database = new DataBase_code();
        public start_app()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ok_pass_Click(object sender, EventArgs e)
        {
            if (database.authentication(txt_user.Text, txt_pass.Text) && txt_user.Text !="" && txt_pass.Text!="")
            {
                manager m = new manager();
                this.Hide();
                m.Show();
            }
            
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            cls.animate_hight(panel_show, 40, 80);
            if(panel_show.Height != 80)
            {
                btn_show.ButtonText = "عرض";
            }
             else btn_show.ButtonText = "إخفاء";



        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            change_pass c = new change_pass();
            c.ShowDialog();

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            forget_pass c = new forget_pass();
            c.ShowDialog();



        }

        private void start_app_Load(object sender, EventArgs e)
        {
            cls.animate_hight(panel_show, 40, 80);
           
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            txt_pass.PasswordChar = checkBox.Checked ? '\0' : '*';
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            about a = new about();
            a.ShowDialog();
        }
    }
    }
    

