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
    public partial class forget_pass : Form
    {
        DataBase_code database = new DataBase_code();
        public forget_pass()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_ok_pass_Click(object sender, EventArgs e)
        {
            try
            {
                if (database.forget_password_by_manager(txt_pass.Text, label_show_pass) && txt_pass.Text != "")
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

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            txt_pass.PasswordChar = checkBox.Checked ? '\0' : '*';
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel_change_pass_Paint(object sender, PaintEventArgs e)
        {

        }

        private void forget_pass_Load(object sender, EventArgs e)
        {

        }
    }
}
