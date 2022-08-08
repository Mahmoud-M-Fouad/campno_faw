namespace faw
{
    partial class start_app
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(start_app));
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.label_page_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_user = new Guna.UI.WinForms.GunaTextBox();
            this.txt_pass = new Guna.UI.WinForms.GunaTextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.panel_show = new System.Windows.Forms.Panel();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_show = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ok_pass = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gunaImageButton2 = new Guna.UI.WinForms.GunaImageButton();
            this.panel1.SuspendLayout();
            this.panel_show.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.BackColor = System.Drawing.Color.Azure;
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.Image")));
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(389, 12);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(40, 43);
            this.gunaImageButton1.TabIndex = 28;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // label_page_title
            // 
            this.label_page_title.BackColor = System.Drawing.Color.Teal;
            this.label_page_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_page_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_page_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_page_title.Location = new System.Drawing.Point(0, 0);
            this.label_page_title.Name = "label_page_title";
            this.label_page_title.Size = new System.Drawing.Size(433, 87);
            this.label_page_title.TabIndex = 4;
            this.label_page_title.Text = "ملعب فاو قبلى";
            this.label_page_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Aquamarine;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 152);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(133, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "أسم المستخدم";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.gunaImageButton2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_user);
            this.panel1.Controls.Add(this.txt_pass);
            this.panel1.Controls.Add(this.checkBox);
            this.panel1.Controls.Add(this.panel_show);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_ok_pass);
            this.panel1.Controls.Add(this.gunaImageButton1);
            this.panel1.Controls.Add(this.label_page_title);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 487);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Aquamarine;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 212);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(133, 35);
            this.label3.TabIndex = 43;
            this.label3.Text = "كلمة السر";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.Transparent;
            this.txt_user.BaseColor = System.Drawing.Color.White;
            this.txt_user.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_user.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_user.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_user.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(41, 152);
            this.txt_user.Name = "txt_user";
            this.txt_user.PasswordChar = '\0';
            this.txt_user.Radius = 10;
            this.txt_user.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_user.SelectedText = "";
            this.txt_user.Size = new System.Drawing.Size(247, 35);
            this.txt_user.TabIndex = 0;
            this.txt_user.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.Transparent;
            this.txt_pass.BaseColor = System.Drawing.Color.White;
            this.txt_pass.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_pass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_pass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(41, 212);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Radius = 10;
            this.txt_pass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_pass.SelectedText = "";
            this.txt_pass.Size = new System.Drawing.Size(247, 35);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.BackColor = System.Drawing.Color.SpringGreen;
            this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.Location = new System.Drawing.Point(128, 266);
            this.checkBox.Name = "checkBox";
            this.checkBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox.Size = new System.Drawing.Size(126, 24);
            this.checkBox.TabIndex = 3;
            this.checkBox.Text = "عرض كلمة السر";
            this.checkBox.UseVisualStyleBackColor = false;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // panel_show
            // 
            this.panel_show.BackColor = System.Drawing.Color.CadetBlue;
            this.panel_show.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_show.Controls.Add(this.bunifuThinButton23);
            this.panel_show.Controls.Add(this.bunifuThinButton22);
            this.panel_show.Controls.Add(this.btn_show);
            this.panel_show.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_show.Location = new System.Drawing.Point(0, 389);
            this.panel_show.Name = "panel_show";
            this.panel_show.Size = new System.Drawing.Size(433, 98);
            this.panel_show.TabIndex = 33;
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.Navy;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.Violet;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.CadetBlue;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "نسيت كلمة السر";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.Location = new System.Drawing.Point(12, 47);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(149, 41);
            this.bunifuThinButton23.TabIndex = 34;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Navy;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.Violet;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.CadetBlue;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "تغير كلمة السر";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(276, 47);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(149, 41);
            this.bunifuThinButton22.TabIndex = 33;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // btn_show
            // 
            this.btn_show.ActiveBorderThickness = 1;
            this.btn_show.ActiveCornerRadius = 20;
            this.btn_show.ActiveFillColor = System.Drawing.Color.Navy;
            this.btn_show.ActiveForecolor = System.Drawing.Color.Violet;
            this.btn_show.ActiveLineColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_show.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_show.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_show.BackgroundImage")));
            this.btn_show.ButtonText = "عرض";
            this.btn_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_show.IdleBorderThickness = 1;
            this.btn_show.IdleCornerRadius = 20;
            this.btn_show.IdleFillColor = System.Drawing.Color.White;
            this.btn_show.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_show.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_show.Location = new System.Drawing.Point(184, 5);
            this.btn_show.Margin = new System.Windows.Forms.Padding(5);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(82, 41);
            this.btn_show.TabIndex = 5;
            this.btn_show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_show.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 87);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(433, 42);
            this.label1.TabIndex = 31;
            this.label1.Text = "تسجيل دخول";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ok_pass
            // 
            this.btn_ok_pass.ActiveBorderThickness = 1;
            this.btn_ok_pass.ActiveCornerRadius = 20;
            this.btn_ok_pass.ActiveFillColor = System.Drawing.Color.Navy;
            this.btn_ok_pass.ActiveForecolor = System.Drawing.Color.White;
            this.btn_ok_pass.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_ok_pass.BackColor = System.Drawing.Color.Transparent;
            this.btn_ok_pass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ok_pass.BackgroundImage")));
            this.btn_ok_pass.ButtonText = "دخول";
            this.btn_ok_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ok_pass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok_pass.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_ok_pass.IdleBorderThickness = 1;
            this.btn_ok_pass.IdleCornerRadius = 20;
            this.btn_ok_pass.IdleFillColor = System.Drawing.Color.White;
            this.btn_ok_pass.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_ok_pass.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_ok_pass.Location = new System.Drawing.Point(105, 327);
            this.btn_ok_pass.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ok_pass.Name = "btn_ok_pass";
            this.btn_ok_pass.Size = new System.Drawing.Size(149, 45);
            this.btn_ok_pass.TabIndex = 4;
            this.btn_ok_pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ok_pass.Click += new System.EventHandler(this.btn_ok_pass_Click);
            // 
            // gunaImageButton2
            // 
            this.gunaImageButton2.BackColor = System.Drawing.Color.Azure;
            this.gunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton2.Image")));
            this.gunaImageButton2.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton2.Location = new System.Drawing.Point(3, 12);
            this.gunaImageButton2.Name = "gunaImageButton2";
            this.gunaImageButton2.OnHoverImage = null;
            this.gunaImageButton2.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton2.Size = new System.Drawing.Size(40, 43);
            this.gunaImageButton2.TabIndex = 44;
            this.gunaImageButton2.Click += new System.EventHandler(this.gunaImageButton2_Click);
            // 
            // start_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 486);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "start_app";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "start_app";
            this.Load += new System.EventHandler(this.start_app_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_show.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private System.Windows.Forms.Label label_page_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_ok_pass;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_show;
        private System.Windows.Forms.Panel panel_show;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.CheckBox checkBox;
        private Guna.UI.WinForms.GunaTextBox txt_pass;
        private Guna.UI.WinForms.GunaTextBox txt_user;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton2;
    }
}