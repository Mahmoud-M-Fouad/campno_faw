namespace faw
{
    partial class view_all_hour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_all_hour));
            this.comboBox_date = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_page_title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox_weekly = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_date
            // 
            this.comboBox_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_date.FormattingEnabled = true;
            this.comboBox_date.Location = new System.Drawing.Point(173, 78);
            this.comboBox_date.Name = "comboBox_date";
            this.comboBox_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox_date.Size = new System.Drawing.Size(314, 33);
            this.comboBox_date.TabIndex = 0;
            this.comboBox_date.SelectedIndexChanged += new System.EventHandler(this.comboBox_date_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Aquamarine;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 75);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(163, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "تاريخ الحجز";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_page_title
            // 
            this.label_page_title.BackColor = System.Drawing.Color.Teal;
            this.label_page_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_page_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_page_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_page_title.Location = new System.Drawing.Point(0, 0);
            this.label_page_title.Name = "label_page_title";
            this.label_page_title.Size = new System.Drawing.Size(1125, 67);
            this.label_page_title.TabIndex = 6;
            this.label_page_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_page_title.Click += new System.EventHandler(this.label_page_title_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.checkBox_weekly);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.gunaImageButton1);
            this.panel2.Controls.Add(this.label_page_title);
            this.panel2.Controls.Add(this.comboBox_date);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1125, 128);
            this.panel2.TabIndex = 8;
            // 
            // checkBox_weekly
            // 
            this.checkBox_weekly.BackColor = System.Drawing.Color.Aqua;
            this.checkBox_weekly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_weekly.Location = new System.Drawing.Point(704, 70);
            this.checkBox_weekly.Name = "checkBox_weekly";
            this.checkBox_weekly.Size = new System.Drawing.Size(309, 41);
            this.checkBox_weekly.TabIndex = 30;
            this.checkBox_weekly.Text = "عرض الحجوزات الأسبوعية الثابتة";
            this.checkBox_weekly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_weekly.UseVisualStyleBackColor = false;
            this.checkBox_weekly.CheckedChanged += new System.EventHandler(this.checkBox_weekly_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aquamarine;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(1055, 43);
            this.label1.TabIndex = 29;
            this.label1.Text = "بحث عن حجوزات يوم معين";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.BackColor = System.Drawing.Color.Azure;
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.Image")));
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(1073, 12);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(40, 43);
            this.gunaImageButton1.TabIndex = 28;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click_1);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(0, 128);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1125, 664);
            this.dataGridView.TabIndex = 18;
            // 
            // view_all_hour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 792);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "view_all_hour";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "view_all_hour";
            this.Load += new System.EventHandler(this.view_all_hour_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_page_title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_weekly;
    }
}