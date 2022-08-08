using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faw
{
    class DataBase_code
    {
        SqlConnection con = new SqlConnection("Data Source=OMDAA\\SQLEXPRESS;Initial Catalog=final_campno_faw;Integrated Security=True");
        SqlCommand cmd;

        public void open_connection()
        {
            try
            {
                con.Open();
            }
            catch
            {

            }
        }

        public void close_connection()
        {
            try
            {
                con.Close();
            }
            catch
            {

            }
        }

        public bool authentication(string username, string passw)
        {
            int i = 0;
            try
            {
                open_connection();
                cmd = new SqlCommand("select * from login where username = '" + username + "' and password ='" + passw + "'  ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (i == 0)
                {
                    MessageBox.Show("فشل تسجيل الدخول", "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    MessageBox.Show("تم تسجيل الدخول بنجاح", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }


                close_connection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;

        }

        public bool authentication2(string pass)
        {
            int i = 0;
            try
            {
                open_connection();
                cmd = new SqlCommand("SELECT login.password FROM login WHERE login.username = 'campno_faw'and password ='" + pass + "'  ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (i == 0)
                {
                    //MessageBox.Show("خطأ فى كلمة السر ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                   // MessageBox.Show("تم تسجيل الدخول بنجاح", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;

                }


                close_connection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;

        }

        public bool change_password_by_manager(string pass)
        {
            int i = 0;
            try
            {
                open_connection();
                cmd = new SqlCommand("SELECT login.password FROM login WHERE login.username = 'campno' and password ='" + pass + "'  ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (i == 0)
                {
                    MessageBox.Show("خطأ فى كلمة السر ", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    MessageBox.Show("كلمة السر صحيحة", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;

                }


                close_connection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        public bool forget_password_by_manager(string pass , Label l)
        {
            int i = 0;
            try
            {
                open_connection();
                cmd = new SqlCommand("SELECT login.password FROM login WHERE login.username = 'campno'and password ='" + pass + "'  ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (i == 0)
                {
                    MessageBox.Show("خطأ فى كلمة السر ", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {

                    MessageBox.Show("كلمة السر صحيحة", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    show_forget_password(l);
                    return true;
                }


                close_connection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;

        }


        public void show_forget_password(Label l)
        {
            int i = 0;
            try
            {
                open_connection();
                cmd = new SqlCommand("SELECT login.password FROM login WHERE login.username = 'campno_faw';", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (i == 0)
                {
                    l.Text = "";

                    
                }
                else
                {

                    string tname = dt.Rows[0][0].ToString();
                    l.Text = tname;

                  
                }


                close_connection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        public void update_login_by_manager(String pass)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("update  login set  password ='" + pass + "' where username = 'campno_faw' ;", con);
                cmd.ExecuteNonQuery();
                close_connection();

                DialogResult result = MessageBox.Show("  تم تغير كلمة السر"
                             , "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e + " \n"+"خطأ فى تعدبل كلمة السر");
                close_connection();
            }
        }

        public void Reserve_an_hour(string name , string phone,int hour , string date ,string hour_day, string notes , int weekly , string hour_type)
        {
            try
            {
               

                open_connection();
                cmd = new SqlCommand("insert into reserv(name ,phone ,hour ,date , day ,notes , weekly ,money ,hour_type ) values ('" + name + "','" + phone + "','" + hour + "','" + date + "' , '" + hour_day+"' , '" + notes + "','" + weekly + "','" + 0 + "','" + hour_type + "');", con);
                cmd.ExecuteNonQuery();

               

                close_connection();
                MessageBox.Show("تم حجز الساعة", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch (Exception )
            { 
                MessageBox.Show("خطأ فى بيانات الحجز", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Reserve_fixed_hour(int player_id , int hour, string day , string hour_type)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("insert into fixed_reserv(player_id ,hour ,day , hour_type ) values ('" + player_id + "','" + hour + "','" + day + "' , '"+ hour_type + "');", con);
                cmd.ExecuteNonQuery();
                close_connection();
               // MessageBox.Show("تم حجز الساعة", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("خطأ فى بيانات الحجز", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int return_id(int hour,string date ,string hour_type )
        {
            try
            {
                open_connection();/* p.id = m.playerId and*/
                cmd = new SqlCommand("select id  from reserv where hour = '" + hour + "' and date =  '" + date + "' and hour_type = '"+ hour_type + "';", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                int i = Convert.ToInt32(table.Rows.Count.ToString());
                if (i == 0)
                {
                    return -1;

                }
                else
                {
                    return Convert.ToInt32(table.Rows[0][0].ToString());
                }
                da.Dispose();
              
            }
             
            catch (Exception)
            {
                MessageBox.Show("خطأ كود الحاجز", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }



        public bool count(int id , string hour_type , string date , string hour)
        {
            try
            {
                open_connection();/* p.id = m.playerId and*/
                cmd = new SqlCommand("select *  from reserv where id = '" + id + "' and hour_type = '"+hour_type +"' and date = '" + date+"' and hour = '"+hour+"';", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                int i = Convert.ToInt32(table.Rows.Count.ToString());
                if (i == 0)
                {
                    return true;

                }
                else
                {
                    return false;
                }
                da.Dispose();

            }

            catch (Exception ex)
            {
                MessageBox.Show("خطأ كود الحاجز", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }


        public string return_hour_type(int id )
        {
            try
            {
                open_connection();/* p.id = m.playerId and*/
                cmd = new SqlCommand("select hour_type  from reserv where id = '" + id + "';", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                int i = Convert.ToInt32(table.Rows.Count.ToString());
                if (i == 0)
                {
                    return "";

                }
                else
                {
                    return table.Rows[0][0].ToString();
                }
                da.Dispose();

            }

            catch (Exception ex)
            {
                MessageBox.Show("خطأ كود الحاجز", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "";
        }

        public string return_hour_day(int id)
        {
            try
            {
                open_connection();/* p.id = m.playerId and*/
                cmd = new SqlCommand("select day from reserv where id = '" + id + "';", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                int i = Convert.ToInt32(table.Rows.Count.ToString());
                if (i == 0)
                {
                    return "";

                }
                else
                {
                    return table.Rows[0][0].ToString();
                }
                da.Dispose();

            }

            catch (Exception ex)
            {
                MessageBox.Show("خطأ كود الحاجز", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "";
        }

        public string return_hour_day_from_date(string date)
        {
            try
            {
                open_connection();/* p.id = m.playerId and*/
                cmd = new SqlCommand("select day from reserv where date = '" + date + "';", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                int i = Convert.ToInt32(table.Rows.Count.ToString());
                if (i == 0)
                {
                    return "";

                }
                else
                {
                    return table.Rows[0][0].ToString();
                }
                da.Dispose();

            }

            catch (Exception ex)
            {
                MessageBox.Show("خطأ كود الحاجز", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "";
        }

        public int return_count_reserv(string date)
        {
            try
            {
                open_connection();/* p.id = m.playerId and*/
                cmd = new SqlCommand("select hour from reserv where date = '" + date + "';", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                int i = Convert.ToInt32(table.Rows.Count.ToString());
                if (i == 0)
                {
                    return 1;

                }
                else
                {
                    //return Convert.ToInt32(table.Rows[0][0].ToString());
                    return i+1;
                }
                da.Dispose();

            }

            catch (Exception ex)
            {
                MessageBox.Show("خطأ ساعة الحجز", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }

        public bool return_hour_reserv_or_no(string date , int hour , int  hour_type)
        {
            try
            {
                string h_type = hour_type== 1 ? "مساءاً" : "صباحاً";
                //MessageBox.Show(date.ToString());
                open_connection();/* p.id = m.playerId and*/
                cmd = new SqlCommand("select hour from reserv where date =  '" + date + "' and hour = '"+ hour + "' and hour_type = '"+ h_type + "';", con);
                
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                int i = Convert.ToInt32(table.Rows.Count.ToString());
               
                if (i == 0)
                {
                  // MessageBox.Show(i.ToString());
                    return false;

                }
                else
                {
                    //return Convert.ToInt32(table.Rows[0][0].ToString());
                    return true;
                }
                da.Dispose();

            }

            catch (Exception ex)
            {
                MessageBox.Show("خطأ فى ساعة الحجز", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool return_hour_in_fixed_table_or_no(string day, int hour, int hour_type)
        {
            try
            {
                string h_type = hour_type == 1 ? "مساءاً" : "صباحاً";
              //  MessageBox.Show(day  );
                open_connection();/* p.id = m.playerId and*/
                cmd = new SqlCommand("select hour from fixed_reserv where day =  '" + day + "' and hour = '" + hour + "' and hour_type = '" + h_type + "';", con);

                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                int i = Convert.ToInt32(table.Rows.Count.ToString());

                if (i == 0)
                {
                    // MessageBox.Show(i.ToString());
                    return false;

                }
                else
                {
                    //return Convert.ToInt32(table.Rows[0][0].ToString());
                    return true;
                }
                da.Dispose();

            }

            catch (Exception ex)
            {
                MessageBox.Show("---خطأ فى ساعة الحجز", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool validation_delete_fixed_hour()
        {
            try
            {  
                open_connection();/* p.id = m.playerId and*/
                cmd = new SqlCommand("select * from fixed_reserv;", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                int i = Convert.ToInt32(table.Rows.Count.ToString());

                if (i == 0)
                {
                    // MessageBox.Show(i.ToString());
                    return false;

                }
                else
                {
                    //return Convert.ToInt32(table.Rows[0][0].ToString());
                    return true;
                }
                da.Dispose();

            }

            catch (Exception ex)
            {
                MessageBox.Show("---خطأ فى ساعة الحجز", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool validation_delete_hour()
        {
            try
            {
                open_connection();/* p.id = m.playerId and*/
                cmd = new SqlCommand("select * from reserv;", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                int i = Convert.ToInt32(table.Rows.Count.ToString());

                if (i == 0)
                {
                    // MessageBox.Show(i.ToString());
                    return false;

                }
                else
                {
                    //return Convert.ToInt32(table.Rows[0][0].ToString());
                    return true;
                }
                da.Dispose();

            }

            catch (Exception ex)
            {
                MessageBox.Show("خطأ فى ساعة الحجز", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public void View_today_reservations(DataGridView dgv)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("select  name as 'الأسم' , phone as  'التلفون', hour as 'الساعة', hour_type as 'الموعد', notes as 'الملاحطات', date as 'التاريخ' , day as 'اليوم', weekly as 'تثبيت إسبوعى ' , money as 'دفع فلوس الحجز' from reserv  where date = (SELECT CAST( GETDATE() AS Date)) ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv.DataSource = dt;
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void fill_combobox_data_to_search_hour(ComboBox cbx)
        {

            try
            {
                open_connection();
                cmd = new SqlCommand("select distinct TOP (50)  date from reserv order by date desc;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cbx.DataSource = dt;
                cbx.DisplayMember = "date";
                cbx.ValueMember = "id";
                close_connection();
            }
            catch
            {
               // MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void cursor( string day )
        {

            try
            {
                open_connection();
                cmd = new SqlCommand(" DECLARE @date NVARCHAR(50);" +
                    "select @date = (SELECT CAST(GETDATE() AS Date));" +
                    " DECLARE cursor_weekly CURSOR FOR " +
                    "SELECT reserv.date FROM reserv where weekly = 1 and reserv.day = '"+ day+" ;' OPEN cursor_weekly;" +
                    "FETCH NEXT from cursor_weekly ; WHILE @@FETCH_STATUS = 0" +
                    "BEGIN" +
                    "update reserv set reserv.date = @date WHERE reserv.day = '" + day + "' and weekly = 1;" +
                    "FETCH NEXT from cursor_weekly" +
                    "END;" +
                    "CLOSE cursor_weekly;" +
                    "DEALLOCATE cursor_weekly;GO", con);
                cmd.ExecuteNonQuery();            
                close_connection();
            }
            catch
            {
                // MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void reserv_auto(string day)
        {

            try
            {
                open_connection();
                cmd = new SqlCommand("update reserv set reserv.date = (SELECT CAST(GETDATE() AS Date))  WHERE reserv.day = '" + day + "' and weekly = 1;", con);
                cmd.ExecuteNonQuery();
                close_connection();
            }
            catch
            {
                // MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void fill_combobox_day_to_search_fixed_hour(ComboBox cbx)
        {

            try
            {
                open_connection();
                cmd = new SqlCommand("select distinct day from reserv where weekly =1 ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cbx.DataSource = dt;
                cbx.DisplayMember = "day";
                cbx.ValueMember = "id";
                close_connection();
            }
            catch
            {
                // MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //distinct
        public void fill_combobox_hour_to_search_hour(ComboBox cbx, string d , string h_type)
        {

            try
            {
                open_connection();
                cmd = new SqlCommand("select hour from reserv where date = '" + d+"' and hour_type = '"+ h_type +"';", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cbx.DataSource = dt;
                cbx.DisplayMember = "hour";
                cbx.ValueMember = "hour";
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void fill_combobox_hour_to_ava_hour(ComboBox com , string date, string day,int hour , int h_type)
        {

            try
            {
                //string s= h_type== 1 ? "مساءاً" : "صباحاً";
                if (!return_hour_reserv_or_no(date, hour, h_type) ||
               !return_hour_in_fixed_table_or_no(day, hour, h_type))
                {
                    com.Items.Add(hour);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       


        public void View_name_reservations_about_hour(DataGridView dgv , string hour,string d , string h_type)
        {
            
           
            try
            {
                open_connection();
                cmd = new SqlCommand("select  name as 'الأسم' , phone as  'التلفون', hour as 'الساعة', hour_type as 'الموعد' , day as 'اليوم' , notes as 'الملاحطات'  , money as 'دفع فلوس الحجز' from reserv where hour = '"+ hour +"' and date = '" +d+"' and hour_type = '"+ h_type  + "' ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv.DataSource = dt;
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void View_all_reservations_about_date(DataGridView dgv, string d)
        {


            try
            {
                open_connection();
                cmd = new SqlCommand("select  name as 'الأسم' , phone as  'التلفون', hour as 'الساعة', hour_type as 'الموعد' , day as 'اليوم' ,notes as 'الملاحظات' , weekly as 'الحجز الأسبوعى' , money as 'دفع فلوس الحجز'  from reserv where date = '"+d+"' ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv.DataSource = dt;
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void View_all_reservations_about_any_data(DataGridView dgv  , string d)
        {


            try
            {
                open_connection();
                cmd = new SqlCommand("select  name as 'الأسم' , phone as  'التلفون', hour as 'الساعة', hour_type as 'الموعد' ,  day as 'اليوم' ,notes as 'الملاحطات' , money as 'دفع فلوس الحجز' , weekly as 'الججز الأسبوعى'  from reserv  where date = '" + d + "' ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv.DataSource = dt;
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void View_all_fixed_reservations_about_any_day(DataGridView dgv, string day)
        {


            try
            {
                open_connection();
                cmd = new SqlCommand("select  name as 'الأسم' , phone as  'التلفون', hour as 'الساعة', hour_type as 'الموعد' , day as 'اليوم' , notes as 'الملاحطات' , money as 'دفع فلوس الحجز' , weekly as 'الججز الأسبوعى'  from reserv  where day = '" + day + "' and weekly = 1 ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv.DataSource = dt;
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        ///---------------
        public void delete_hour(string date, int hour , string hour_type)
        {

            DialogResult dr = MessageBox.Show("هل تريد حذف الساعة", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (dr == DialogResult.Yes)
            {
                try
                {
                    string day = return_hour_day_from_date(date);
                    open_connection();
                    cmd = new SqlCommand("delete from reserv where date = '" + date + "' and hour  = '" + hour + "' and hour_type = '"+ hour_type + "';", con);
                    cmd.ExecuteNonQuery();
                    close_connection();
                    
                    delete_fixed_hour(hour , day , hour_type);

                    MessageBox.Show("تم حذف الساعة بنجاح", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("يوجد مشكلة فى الحذف", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        public void delete_fixed_hour(int hour , string day , string hour_type)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("delete from fixed_reserv where hour = '" + hour +"' and day = '" +day +"' and hour_type = '"+hour_type+"' ; ", con);
                cmd.ExecuteNonQuery();
                close_connection();
                //MessageBox.Show("تم حذف الساعة بنجاح", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("يوجد مشكلة فى الحذف من الحجز الأسبوعى", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void delete_all_hour(string date )
        {

            DialogResult dr = MessageBox.Show("هل تريد حذف كل الساعة", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    string day = return_hour_day_from_date(date);
                    open_connection();
                    cmd = new SqlCommand("delete from reserv where date = '" + date + "';", con);
                    cmd.ExecuteNonQuery();
                    close_connection();
                    delete_all_fixed_hour(day);
                   // MessageBox.Show("تم حذف كل الساعة بنجاح", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("يوجد مشكلة فى الحذف", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        public void delete_all_fixed_hour(string day)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("delete from fixed_reserv where day = '" + day + "';", con);
                cmd.ExecuteNonQuery();
                close_connection();
                MessageBox.Show("تم حذف كل الساعة بنجاح", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("يوجد مشكلة فى الحذف", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void update_hour_name(string newName , int hour , string date , string hour_type)
        {
            
            DialogResult dr = MessageBox.Show("هل تريد تعديل الأسم", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
               
                try
                {
                    int id = return_id(hour, date , hour_type);    
                    open_connection();
                    cmd = new SqlCommand("update reserv SET name = '" + newName + "' where id = '"+ id +"' ;", con);    
                    cmd.ExecuteNonQuery();
                    close_connection();
                    MessageBox.Show("تم تعديل الأسم بنجاح", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" يوجد مشكلة فى تعديل الأسم", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        
        public void update_hour_phone(int phone, int hour, string date , string hour_type)
        {

            DialogResult dr = MessageBox.Show("هل تريد تعديل الهاتف", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                try
                {
                    int id = return_id(hour, date , hour_type);
                    open_connection();
                    cmd = new SqlCommand("update reserv SET phone = '" + phone + "' where id = '" + id + "' ;", con);
                    cmd.ExecuteNonQuery();
                    close_connection();
                    MessageBox.Show("تم تعديل الهاتف بنجاح", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" يوجد مشكلة فى تعديل الهاتف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        public void update_hour_hour(int hournew, int hour, string date , string hour_type, string hour_type_new)
        {

            DialogResult dr = MessageBox.Show("هل تريد تعديل الساعة", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                try
                {
                    int id = return_id(hour, date , hour_type);
                    open_connection();
                    cmd = new SqlCommand("update reserv SET hour = '" + hournew + "' ,  hour_type = '"+ hour_type_new  + "' where id = '" + id + "' and hour_type = '"+ hour_type + "' ;", con);
                    cmd.ExecuteNonQuery();
                    close_connection();
                    MessageBox.Show("تم تعديل ساعة الحجز بنجاح", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("الساعة محجوزة من قبل", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public void update_hour_notes(string notes, int hour, string date , string hour_type)
        {

            DialogResult dr = MessageBox.Show("هل تريد تعديل الملاحظات", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                try
                {
                    int id = return_id(hour, date , hour_type);
                    open_connection();
                    cmd = new SqlCommand("update reserv SET notes = '" + notes + "' where id = '" + id + "' ;", con);
                    cmd.ExecuteNonQuery();
                    close_connection();
                    MessageBox.Show("تم تعديل الملاحظات بنجاح", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("هناك مشكلة فى تعديل الملاحظات", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public void update_hour_weekly(int check, int hour, string date , string hour_type)
        {

            DialogResult dr = MessageBox.Show("هل تريد تعديل الحجز الأسبوعى", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                try
                {
                    int id = return_id(hour, date , hour_type);
                    open_connection();
                    cmd = new SqlCommand("update reserv SET weekly = '" + check + "' where id = '" + id + "' ;", con);
                    cmd.ExecuteNonQuery();
                    close_connection();

                    if(check ==1)
                    {                       
                        Reserve_fixed_hour(id, hour, return_hour_day(id), hour_type);
                       // MessageBox.Show(return_hour_day(id));
                    }
                    else if (check==0)
                    {
                        string day = return_hour_day_from_date(date);
                        delete_fixed_hour(hour, day, hour_type);
                    }

                    MessageBox.Show("تم تعديل الحجز الأسبوعى", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("هناك مشكلة فى تعديل الحجز الأسبوعى", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public void update_hour_money(int check, int hour, string date , string hour_type)
        {

            DialogResult dr = MessageBox.Show("هل تريد تعديل فلوس الحجز", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                try
                {
                    int id = return_id(hour, date ,  hour_type);
                    open_connection();
                    cmd = new SqlCommand("update reserv SET money = '" + check + "' where id = '" + id + "' ;", con);
                    cmd.ExecuteNonQuery();
                    close_connection();
                    MessageBox.Show("تم تعديل فلوس الحجز", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("هناك مشكلة فى تعديل فلوس الحجز", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public void update_hour_date(string datenew, string day, int hour, string date , string hour_type)
        {

            DialogResult dr = MessageBox.Show("هل تريد تعديل تاريخ الحجز", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                try
                {
                    int id = return_id(hour, date ,  hour_type);
                   // MessageBox.Show(id.ToString() + "" + datenew);

                   open_connection();
                    cmd = new SqlCommand("update reserv SET date = '" + datenew + "', day = '"+ day +"' where id = '" + id + "' ;", con);
                    cmd.ExecuteNonQuery();
                    close_connection();
                    MessageBox.Show("تم تعديل تاريخ الحجز إلى " + datenew, "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("هذه الساعة محجوزة من قبل", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        
        
        public void get_values_of_hour_in_text_boxes(int h ,string d, string hour_type , Guna.UI.WinForms.GunaTextBox name, Guna.UI.WinForms.GunaTextBox phone,
            Guna.UI.WinForms.GunaTextBox hour, RadioButton pm, RadioButton am,Label day, RichTextBox notes,CheckBox weekly , CheckBox money)
        {
            DataTable dt = new DataTable();
            try
            {
                open_connection();
                cmd = new SqlCommand("select * from reserv where hour = '" + h+ "' and date = '" + d + "' and hour_type = '"+ hour_type + "';", con);
                cmd.ExecuteNonQuery();

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(dt);
                close_connection();

                int count = Convert.ToInt32(dt.Rows.Count.ToString());
                
                if (count == 0)
                {
                    
                    name.Text = "";
                    phone.Text = "";
                    hour.Text = "";
                    day.Text = "";                   
                    notes.Text = "";
                    weekly.Checked = false;
                    money.Checked = false;
                    pm.Checked  = false;
                    am.Checked = false;




                }
                else
                {                                          // 0    1     2    3   4
                    name.Text = dt.Rows[0][1].ToString(); // name id relation ph wph 
                    phone.Text = dt.Rows[0][2].ToString();
                    day.Text = dt.Rows[0][3].ToString();
                    // date
                    hour.Text = dt.Rows[0][5].ToString();                                    
                    notes.Text = dt.Rows[0][6].ToString();
                    if (Convert.ToBoolean(dt.Rows[0][7].ToString()) == true)
                    {
                        weekly.Checked = true;
                    }
                    else
                        weekly.Checked = false;

                    if (Convert.ToBoolean(dt.Rows[0][8].ToString()) == true)
                    {                                                                                                                                                                                               
                        money.Checked = true;
                    }
                    else
                        money.Checked = false;

                    if (dt.Rows[0][9].ToString() == "مساءاً")
                    {
                        pm.Checked = true;
                        am.Checked = false;
                    }
                    else
                    {
                        pm.Checked = false;
                        am.Checked = true;
                    }
                        

                   /* if (Convert.ToBoolean(dt.Rows[0][7].ToString()) == true)
                    {
                        am.Checked = true;
                    }
                    else
                        am.Checked = false;
                    */

                    // MessageBox.Show("من فضلك اختر تاريخ الميلاد مجددا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            



        }



    }
}
