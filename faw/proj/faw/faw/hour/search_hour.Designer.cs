namespace faw
{
    partial class search_hour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search_hour));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label_page_title = new System.Windows.Forms.Label();
            this.comboBox_date = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_hour = new System.Windows.Forms.ComboBox();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_pm = new System.Windows.Forms.RadioButton();
            this.radioButton_am = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(0, 241);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1018, 514);
            this.dataGridView.TabIndex = 17;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(610, 80);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(163, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "تاريخ الحجز";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_page_title
            // 
            this.label_page_title.BackColor = System.Drawing.Color.Teal;
            this.label_page_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_page_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_page_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_page_title.Location = new System.Drawing.Point(0, 0);
            this.label_page_title.Name = "label_page_title";
            this.label_page_title.Size = new System.Drawing.Size(1018, 70);
            this.label_page_title.TabIndex = 4;
            this.label_page_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_page_title.Click += new System.EventHandler(this.label_page_title_Click);
            // 
            // comboBox_date
            // 
            this.comboBox_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_date.FormattingEnabled = true;
            this.comboBox_date.Location = new System.Drawing.Point(350, 83);
            this.comboBox_date.Name = "comboBox_date";
            this.comboBox_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox_date.Size = new System.Drawing.Size(244, 33);
            this.comboBox_date.TabIndex = 0;
            this.comboBox_date.SelectedIndexChanged += new System.EventHandler(this.comboBox_date_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Aqua;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(610, 136);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(163, 36);
            this.label4.TabIndex = 21;
            this.label4.Text = "الساعة";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_hour
            // 
            this.comboBox_hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_hour.FormattingEnabled = true;
            this.comboBox_hour.Location = new System.Drawing.Point(350, 139);
            this.comboBox_hour.Name = "comboBox_hour";
            this.comboBox_hour.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox_hour.Size = new System.Drawing.Size(244, 33);
            this.comboBox_hour.TabIndex = 1;
            this.comboBox_hour.SelectedIndexChanged += new System.EventHandler(this.comboBox_name_SelectedIndexChanged);
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.BackColor = System.Drawing.Color.Azure;
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.Image")));
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(966, 12);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(40, 43);
            this.gunaImageButton1.TabIndex = 28;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.radioButton_pm);
            this.panel1.Controls.Add(this.radioButton_am);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gunaImageButton1);
            this.panel1.Controls.Add(this.comboBox_hour);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox_date);
            this.panel1.Controls.Add(this.label_page_title);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 242);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // radioButton_pm
            // 
            this.radioButton_pm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_pm.ForeColor = System.Drawing.Color.Black;
            this.radioButton_pm.Location = new System.Drawing.Point(334, 191);
            this.radioButton_pm.Name = "radioButton_pm";
            this.radioButton_pm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton_pm.Size = new System.Drawing.Size(112, 44);
            this.radioButton_pm.TabIndex = 37;
            this.radioButton_pm.Text = "مساءاً";
            this.radioButton_pm.UseVisualStyleBackColor = true;
            this.radioButton_pm.CheckedChanged += new System.EventHandler(this.radioButton_pm_CheckedChanged);
            // 
            // radioButton_am
            // 
            this.radioButton_am.Checked = true;
            this.radioButton_am.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_am.ForeColor = System.Drawing.Color.Black;
            this.radioButton_am.Location = new System.Drawing.Point(481, 191);
            this.radioButton_am.Name = "radioButton_am";
            this.radioButton_am.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton_am.Size = new System.Drawing.Size(104, 44);
            this.radioButton_am.TabIndex = 36;
            this.radioButton_am.TabStop = true;
            this.radioButton_am.Text = "صباحاً";
            this.radioButton_am.UseVisualStyleBackColor = true;
            this.radioButton_am.CheckedChanged += new System.EventHandler(this.radioButton_am_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(948, 43);
            this.label1.TabIndex = 29;
            this.label1.Text = "بحث عن حجز موجود";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // search_hour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 755);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "search_hour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "search_hour";
            this.Load += new System.EventHandler(this.search_hour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_page_title;
        private System.Windows.Forms.ComboBox comboBox_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_hour;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_pm;
        private System.Windows.Forms.RadioButton radioButton_am;
    }
}