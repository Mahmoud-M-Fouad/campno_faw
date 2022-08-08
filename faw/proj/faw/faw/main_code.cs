using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faw
{
    class main_code
    {
       private int hour = 0;
        private string date= "";

       /* main_code(int hour , string date)
        {
            this.hour = hour;
            this.date = date;
        }
        */
        // GUI 
        // all codes of gui we will need in our project in methods 
        public void animate_width(Panel panel, int start, int end)
        {
            if (panel.Width == start)
            {
                while (panel.Width < end)
                    panel.Width += 1;
            }
            else
            {

                while (panel.Width > start)
                    panel.Width -= 1;
            }
        }

        public void animate_hight(Panel panel, int start, int end)
        {
            if (panel.Height == start)
            {
                while (panel.Height < end)
                    panel.Height += 1;
            }
            else
            {

                while (panel.Height > start)
                    panel.Height -= 1;
            }
        }

        public void SetForm(Panel panel, Form form)
        {
            // like this
            // addpatient = new AddPatient() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            // cls.methodSetForm(panelResult, addpatient);
            panel.Controls.Clear();

            form.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(form);
            form.Show();

        }

        public void only_integers(KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
                MessageBox.Show("من فضلك أدخل أرقم فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void only_characters(KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("من فضلك أدخل حروف فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_hour(int i)
        {
            this.hour = i;
        }

        public int get_hour()
        {
            return hour;
        }

        public void set_date(string d)
        {
            this.date = d;
        }

        public string get_date()
        {
            return date;
        }

    }
}
