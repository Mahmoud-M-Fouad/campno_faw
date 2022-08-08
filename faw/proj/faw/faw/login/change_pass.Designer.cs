namespace faw
{
    partial class change_pass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(change_pass));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.btn_ok_pass = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_pass = new Guna.UI.WinForms.GunaTextBox();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.label_page_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_change_pass = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_conf_new_pass = new Guna.UI.WinForms.GunaTextBox();
            this.checkBox_new = new System.Windows.Forms.CheckBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_new_pass = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_change_pass.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.checkBox);
            this.panel1.Controls.Add(this.btn_ok_pass);
            this.panel1.Controls.Add(this.txt_pass);
            this.panel1.Controls.Add(this.gunaImageButton1);
            this.panel1.Controls.Add(this.label_page_title);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 242);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(83, 151);
            this.checkBox.Name = "checkBox";
            this.checkBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox.Size = new System.Drawing.Size(108, 21);
            this.checkBox.TabIndex = 41;
            this.checkBox.Text = "عرض كلمة السر";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // btn_ok_pass
            // 
            this.btn_ok_pass.ActiveBorderThickness = 1;
            this.btn_ok_pass.ActiveCornerRadius = 20;
            this.btn_ok_pass.ActiveFillColor = System.Drawing.Color.Navy;
            this.btn_ok_pass.ActiveForecolor = System.Drawing.Color.White;
            this.btn_ok_pass.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_ok_pass.BackColor = System.Drawing.Color.Teal;
            this.btn_ok_pass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ok_pass.BackgroundImage")));
            this.btn_ok_pass.ButtonText = "تأكيد";
            this.btn_ok_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ok_pass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok_pass.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_ok_pass.IdleBorderThickness = 1;
            this.btn_ok_pass.IdleCornerRadius = 20;
            this.btn_ok_pass.IdleFillColor = System.Drawing.Color.White;
            this.btn_ok_pass.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_ok_pass.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_ok_pass.Location = new System.Drawing.Point(11, 180);
            this.btn_ok_pass.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ok_pass.Name = "btn_ok_pass";
            this.btn_ok_pass.Size = new System.Drawing.Size(188, 47);
            this.btn_ok_pass.TabIndex = 30;
            this.btn_ok_pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ok_pass.Click += new System.EventHandler(this.btn_ok_pass_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_pass.BackColor = System.Drawing.Color.Transparent;
            this.txt_pass.BaseColor = System.Drawing.Color.White;
            this.txt_pass.BorderColor = System.Drawing.Color.Silver;
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_pass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_pass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(3, 102);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Radius = 5;
            this.txt_pass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_pass.SelectedText = "";
            this.txt_pass.Size = new System.Drawing.Size(196, 32);
            this.txt_pass.TabIndex = 29;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.BackColor = System.Drawing.Color.Azure;
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.Image")));
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(297, 12);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(40, 43);
            this.gunaImageButton1.TabIndex = 28;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // label_page_title
            // 
            this.label_page_title.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label_page_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_page_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_page_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_page_title.Location = new System.Drawing.Point(0, 0);
            this.label_page_title.Name = "label_page_title";
            this.label_page_title.Size = new System.Drawing.Size(349, 70);
            this.label_page_title.TabIndex = 4;
            this.label_page_title.Text = "أدخل كلمة السر الرئسية";
            this.label_page_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Aquamarine;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 102);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(121, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "كلمة السر";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_change_pass
            // 
            this.panel_change_pass.BackColor = System.Drawing.Color.Teal;
            this.panel_change_pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_change_pass.Controls.Add(this.label4);
            this.panel_change_pass.Controls.Add(this.txt_conf_new_pass);
            this.panel_change_pass.Controls.Add(this.checkBox_new);
            this.panel_change_pass.Controls.Add(this.bunifuThinButton21);
            this.panel_change_pass.Controls.Add(this.txt_new_pass);
            this.panel_change_pass.Controls.Add(this.label1);
            this.panel_change_pass.Controls.Add(this.label3);
            this.panel_change_pass.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_change_pass.Location = new System.Drawing.Point(0, 242);
            this.panel_change_pass.Name = "panel_change_pass";
            this.panel_change_pass.Size = new System.Drawing.Size(349, 299);
            this.panel_change_pass.TabIndex = 20;
            this.panel_change_pass.Visible = false;
            this.panel_change_pass.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_change_pass_Paint);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Aquamarine;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 143);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(121, 36);
            this.label4.TabIndex = 44;
            this.label4.Text = "تأكيد كلمة السر";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_conf_new_pass
            // 
            this.txt_conf_new_pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_conf_new_pass.BackColor = System.Drawing.Color.Transparent;
            this.txt_conf_new_pass.BaseColor = System.Drawing.Color.White;
            this.txt_conf_new_pass.BorderColor = System.Drawing.Color.Silver;
            this.txt_conf_new_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_conf_new_pass.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_conf_new_pass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_conf_new_pass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_conf_new_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_conf_new_pass.Location = new System.Drawing.Point(3, 143);
            this.txt_conf_new_pass.Name = "txt_conf_new_pass";
            this.txt_conf_new_pass.PasswordChar = '*';
            this.txt_conf_new_pass.Radius = 5;
            this.txt_conf_new_pass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_conf_new_pass.SelectedText = "";
            this.txt_conf_new_pass.Size = new System.Drawing.Size(196, 32);
            this.txt_conf_new_pass.TabIndex = 43;
            // 
            // checkBox_new
            // 
            this.checkBox_new.AutoSize = true;
            this.checkBox_new.Location = new System.Drawing.Point(83, 191);
            this.checkBox_new.Name = "checkBox_new";
            this.checkBox_new.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_new.Size = new System.Drawing.Size(108, 21);
            this.checkBox_new.TabIndex = 42;
            this.checkBox_new.Text = "عرض كلمة السر";
            this.checkBox_new.UseVisualStyleBackColor = true;
            this.checkBox_new.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Navy;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Teal;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "تأكيد";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(22, 239);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(177, 47);
            this.bunifuThinButton21.TabIndex = 30;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // txt_new_pass
            // 
            this.txt_new_pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_new_pass.BackColor = System.Drawing.Color.Transparent;
            this.txt_new_pass.BaseColor = System.Drawing.Color.White;
            this.txt_new_pass.BorderColor = System.Drawing.Color.Silver;
            this.txt_new_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_new_pass.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_new_pass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_new_pass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_new_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_new_pass.Location = new System.Drawing.Point(3, 87);
            this.txt_new_pass.Name = "txt_new_pass";
            this.txt_new_pass.PasswordChar = '*';
            this.txt_new_pass.Radius = 5;
            this.txt_new_pass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_new_pass.SelectedText = "";
            this.txt_new_pass.Size = new System.Drawing.Size(196, 36);
            this.txt_new_pass.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "أدخل كلمة السر الجديدة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Aquamarine;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 87);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(121, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "كلمة السر";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // change_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(349, 542);
            this.Controls.Add(this.panel_change_pass);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "change_pass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "change_pass";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_change_pass.ResumeLayout(false);
            this.panel_change_pass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_ok_pass;
        private Guna.UI.WinForms.GunaTextBox txt_pass;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private System.Windows.Forms.Label label_page_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_change_pass;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Guna.UI.WinForms.GunaTextBox txt_new_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.CheckBox checkBox_new;
        private Guna.UI.WinForms.GunaTextBox txt_conf_new_pass;
        private System.Windows.Forms.Label label4;
    }
}