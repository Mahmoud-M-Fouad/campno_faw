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
    public partial class change_pass : Form
    {
        DataBase_code database = new DataBase_code();
        public change_pass()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ok_pass_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                if (database.change_password_by_manager(txt_pass.Text)&& txt_pass.Text!="")
                {
                    panel_change_pass.Visible = true;
                }
                
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show("أدخل كلمة سر صالحة"
                               , "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_new_pass.Text == txt_conf_new_pass.Text&& txt_new_pass.Text != ""&& txt_conf_new_pass.Text != "")
                {
                    database.update_login_by_manager(txt_new_pass.Text);
                }

                else
                {
                    DialogResult result = MessageBox.Show("كلمة السر غير متطابقتان"
                             , "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show("أدخل كلمة سر صالحة"
                               , "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            txt_pass.PasswordChar = checkBox.Checked ? '\0' : '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_new_pass.PasswordChar = checkBox_new.Checked ? '\0' : '*';
            txt_conf_new_pass.PasswordChar = checkBox_new.Checked ? '\0' : '*';
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel_change_pass_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
