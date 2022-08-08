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
    public partial class delete_all_hour1 : Form
    {
        main_code cls = new main_code();
        DataBase_code database = new DataBase_code();
        public delete_all_hour1()
        {
            InitializeComponent();
        }

        private void delete_all_hour1_Load(object sender, EventArgs e)
        {
            database.fill_combobox_data_to_search_hour(comboBox_date);
        }

        private void comboBox_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            database.View_all_reservations_about_date(dataGridView, comboBox_date.Text.ToString());
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            if (comboBox_date.Text != "")
            {
                if(database.validation_delete_fixed_hour() || database.validation_delete_hour())
                {
                    database.delete_all_hour(comboBox_date.Text.ToString());
                    database.fill_combobox_data_to_search_hour(comboBox_date);
                    database.View_all_reservations_about_date(dataGridView, comboBox_date.Text.ToString());
                }
                else
                {
                    MessageBox.Show("لا يوجد ساعات ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }
            else
            {
                MessageBox.Show("أدخل بيانات البيانات كاملة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
