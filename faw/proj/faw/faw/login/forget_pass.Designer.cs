namespace faw
{
    partial class forget_pass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forget_pass));
            this.panel_change_pass = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_show_pass = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.btn_ok_pass = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_pass = new Guna.UI.WinForms.GunaTextBox();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.label_page_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_change_pass.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_change_pass
            // 
            this.panel_change_pass.BackColor = System.Drawing.Color.Teal;
            this.panel_change_pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_change_pass.Controls.Add(this.label1);
            this.panel_change_pass.Controls.Add(this.label_show_pass);
            this.panel_change_pass.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_change_pass.Enabled = false;
            this.panel_change_pass.Location = new System.Drawing.Point(0, 235);
            this.panel_change_pass.Name = "panel_change_pass";
            this.panel_change_pass.Size = new System.Drawing.Size(334, 116);
            this.panel_change_pass.TabIndex = 22;
            this.panel_change_pass.Visible = false;
            this.panel_change_pass.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_change_pass_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "كلمة السر";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_show_pass
            // 
            this.label_show_pass.BackColor = System.Drawing.Color.Aquamarine;
            this.label_show_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_show_pass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_show_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_show_pass.Location = new System.Drawing.Point(0, 67);
            this.label_show_pass.Name = "label_show_pass";
            this.label_show_pass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_show_pass.Size = new System.Drawing.Size(334, 49);
            this.label_show_pass.TabIndex = 2;
            this.label_show_pass.Text = "كلمة السر";
            this.label_show_pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_show_pass.Click += new System.EventHandler(this.label3_Click);
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
            this.panel1.Size = new System.Drawing.Size(334, 235);
            this.panel1.TabIndex = 21;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(89, 142);
            this.checkBox.Name = "checkBox";
            this.checkBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox.Size = new System.Drawing.Size(108, 21);
            this.checkBox.TabIndex = 42;
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
            this.btn_ok_pass.Location = new System.Drawing.Point(12, 171);
            this.btn_ok_pass.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ok_pass.Name = "btn_ok_pass";
            this.btn_ok_pass.Size = new System.Drawing.Size(200, 47);
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
            this.txt_pass.Location = new System.Drawing.Point(12, 92);
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
            this.gunaImageButton1.Location = new System.Drawing.Point(276, 12);
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
            this.label_page_title.Size = new System.Drawing.Size(334, 70);
            this.label_page_title.TabIndex = 4;
            this.label_page_title.Text = "أدخل كلمة السر الرئسية";
            this.label_page_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Aquamarine;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 92);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(108, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "كلمة السر";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // forget_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(334, 360);
            this.Controls.Add(this.panel_change_pass);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "forget_pass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "forget_pass";
            this.Load += new System.EventHandler(this.forget_pass_Load);
            this.panel_change_pass.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_change_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_show_pass;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_ok_pass;
        private Guna.UI.WinForms.GunaTextBox txt_pass;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private System.Windows.Forms.Label label_page_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox;
    }
}