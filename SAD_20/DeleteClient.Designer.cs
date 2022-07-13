namespace SAD_20
{
    partial class DeleteClient
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
            this.back_btn = new System.Windows.Forms.Button();
            this.DeleteClient_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.FullName_textBox = new System.Windows.Forms.TextBox();
            this.SearchClient_btn = new System.Windows.Forms.Button();
            this.gender_comboBox = new System.Windows.Forms.ComboBox();
            this.birthdate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.city_textBox = new System.Windows.Forms.TextBox();
            this.country_textBox = new System.Windows.Forms.TextBox();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.Email_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(335, 394);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 49;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click_1);
            // 
            // DeleteClient_btn
            // 
            this.DeleteClient_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteClient_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DeleteClient_btn.Location = new System.Drawing.Point(191, 383);
            this.DeleteClient_btn.Name = "DeleteClient_btn";
            this.DeleteClient_btn.Size = new System.Drawing.Size(81, 44);
            this.DeleteClient_btn.TabIndex = 48;
            this.DeleteClient_btn.Text = "Delete";
            this.DeleteClient_btn.UseVisualStyleBackColor = false;
            this.DeleteClient_btn.Click += new System.EventHandler(this.DeleteClient_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(122, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "Full Name";
            // 
            // FullName_textBox
            // 
            this.FullName_textBox.Enabled = false;
            this.FullName_textBox.Location = new System.Drawing.Point(182, 118);
            this.FullName_textBox.Name = "FullName_textBox";
            this.FullName_textBox.Size = new System.Drawing.Size(100, 20);
            this.FullName_textBox.TabIndex = 63;
            // 
            // SearchClient_btn
            // 
            this.SearchClient_btn.Location = new System.Drawing.Point(288, 70);
            this.SearchClient_btn.Name = "SearchClient_btn";
            this.SearchClient_btn.Size = new System.Drawing.Size(58, 23);
            this.SearchClient_btn.TabIndex = 62;
            this.SearchClient_btn.Text = "Search";
            this.SearchClient_btn.UseVisualStyleBackColor = true;
            this.SearchClient_btn.Click += new System.EventHandler(this.SearchClient_btn_Click);
            // 
            // gender_comboBox
            // 
            this.gender_comboBox.Enabled = false;
            this.gender_comboBox.FormattingEnabled = true;
            this.gender_comboBox.Location = new System.Drawing.Point(182, 197);
            this.gender_comboBox.Name = "gender_comboBox";
            this.gender_comboBox.Size = new System.Drawing.Size(100, 21);
            this.gender_comboBox.TabIndex = 61;
            // 
            // birthdate_dateTimePicker
            // 
            this.birthdate_dateTimePicker.Enabled = false;
            this.birthdate_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdate_dateTimePicker.Location = new System.Drawing.Point(182, 243);
            this.birthdate_dateTimePicker.Name = "birthdate_dateTimePicker";
            this.birthdate_dateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.birthdate_dateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.birthdate_dateTimePicker.TabIndex = 60;
            this.birthdate_dateTimePicker.Value = new System.DateTime(2022, 6, 16, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(149, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(133, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(124, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Birth Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(134, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(138, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(93, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Email";
            // 
            // city_textBox
            // 
            this.city_textBox.Enabled = false;
            this.city_textBox.Location = new System.Drawing.Point(182, 330);
            this.city_textBox.Name = "city_textBox";
            this.city_textBox.Size = new System.Drawing.Size(100, 20);
            this.city_textBox.TabIndex = 53;
            // 
            // country_textBox
            // 
            this.country_textBox.Enabled = false;
            this.country_textBox.Location = new System.Drawing.Point(182, 286);
            this.country_textBox.Name = "country_textBox";
            this.country_textBox.Size = new System.Drawing.Size(100, 20);
            this.country_textBox.TabIndex = 52;
            // 
            // phone_textBox
            // 
            this.phone_textBox.Enabled = false;
            this.phone_textBox.Location = new System.Drawing.Point(182, 158);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(100, 20);
            this.phone_textBox.TabIndex = 51;
            // 
            // Email_txtBox
            // 
            this.Email_txtBox.Location = new System.Drawing.Point(134, 72);
            this.Email_txtBox.Name = "Email_txtBox";
            this.Email_txtBox.Size = new System.Drawing.Size(148, 20);
            this.Email_txtBox.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(128, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 31);
            this.label1.TabIndex = 65;
            this.label1.Text = "Delete Client";
            // 
            // DeleteClient
            // 
            this.ClientSize = new System.Drawing.Size(450, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FullName_textBox);
            this.Controls.Add(this.SearchClient_btn);
            this.Controls.Add(this.gender_comboBox);
            this.Controls.Add(this.birthdate_dateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.city_textBox);
            this.Controls.Add(this.country_textBox);
            this.Controls.Add(this.phone_textBox);
            this.Controls.Add(this.Email_txtBox);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.DeleteClient_btn);
            this.Name = "DeleteClient";
            this.Load += new System.EventHandler(this.DeleteClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button DeleteClient_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FullName_textBox;
        private System.Windows.Forms.Button SearchClient_btn;
        private System.Windows.Forms.ComboBox gender_comboBox;
        private System.Windows.Forms.DateTimePicker birthdate_dateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox city_textBox;
        private System.Windows.Forms.TextBox country_textBox;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.TextBox Email_txtBox;
        private System.Windows.Forms.Label label1;
    }
}
