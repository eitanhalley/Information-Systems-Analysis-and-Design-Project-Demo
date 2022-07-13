namespace SAD_20
{
    partial class SendFeedback
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.sAD_20DataSet = new SAD_20.SAD_20DataSet();
            this.sPGetBookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_Get_BookingsTableAdapter = new SAD_20.SAD_20DataSetTableAdapters.SP_Get_BookingsTableAdapter();
            this.CreateFeedbackBtn = new System.Windows.Forms.Button();
            this.FreeTextBox = new System.Windows.Forms.TextBox();
            this.RankBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Booking_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcitivityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activity_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_20DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGetBookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Send Feedback";
            // 
            // sAD_20DataSet
            // 
            this.sAD_20DataSet.DataSetName = "SAD_20DataSet";
            this.sAD_20DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPGetBookingsBindingSource
            // 
            this.sPGetBookingsBindingSource.DataMember = "SP_Get_Bookings";
            this.sPGetBookingsBindingSource.DataSource = this.sAD_20DataSet;
            // 
            // sP_Get_BookingsTableAdapter
            // 
            this.sP_Get_BookingsTableAdapter.ClearBeforeFill = true;
            // 
            // CreateFeedbackBtn
            // 
            this.CreateFeedbackBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CreateFeedbackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CreateFeedbackBtn.Location = new System.Drawing.Point(91, 471);
            this.CreateFeedbackBtn.Name = "CreateFeedbackBtn";
            this.CreateFeedbackBtn.Size = new System.Drawing.Size(118, 50);
            this.CreateFeedbackBtn.TabIndex = 8;
            this.CreateFeedbackBtn.Text = "Create";
            this.CreateFeedbackBtn.UseVisualStyleBackColor = false;
            this.CreateFeedbackBtn.Click += new System.EventHandler(this.CreateFeedbackBtn_Click);
            // 
            // FreeTextBox
            // 
            this.FreeTextBox.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FreeTextBox.Location = new System.Drawing.Point(46, 364);
            this.FreeTextBox.Multiline = true;
            this.FreeTextBox.Name = "FreeTextBox";
            this.FreeTextBox.Size = new System.Drawing.Size(354, 91);
            this.FreeTextBox.TabIndex = 9;
            // 
            // RankBox
            // 
            this.RankBox.FormattingEnabled = true;
            this.RankBox.Location = new System.Drawing.Point(88, 312);
            this.RankBox.Name = "RankBox";
            this.RankBox.Size = new System.Drawing.Size(121, 21);
            this.RankBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Rank:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Free Text:";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(316, 495);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(84, 26);
            this.BackBtn.TabIndex = 13;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(46, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Please choose an activity for feedback:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Booking_ID,
            this.Price,
            this.AcitivityID,
            this.Activity_Name});
            this.dataGridView1.Location = new System.Drawing.Point(46, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(445, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // Booking_ID
            // 
            this.Booking_ID.HeaderText = "BookingID";
            this.Booking_ID.Name = "Booking_ID";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // AcitivityID
            // 
            this.AcitivityID.HeaderText = "Activity ID";
            this.AcitivityID.Name = "AcitivityID";
            // 
            // Activity_Name
            // 
            this.Activity_Name.HeaderText = "ActivityName";
            this.Activity_Name.Name = "Activity_Name";
            // 
            // SendFeedback
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(515, 541);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RankBox);
            this.Controls.Add(this.FreeTextBox);
            this.Controls.Add(this.CreateFeedbackBtn);
            this.Controls.Add(this.label1);
            this.Name = "SendFeedback";
            this.Load += new System.EventHandler(this.SendFeedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sAD_20DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGetBookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private SAD_20DataSet sAD_20DataSet;
        private System.Windows.Forms.BindingSource sPGetBookingsBindingSource;
        private SAD_20DataSetTableAdapters.SP_Get_BookingsTableAdapter sP_Get_BookingsTableAdapter;
        private System.Windows.Forms.Button CreateFeedbackBtn;
        private System.Windows.Forms.TextBox FreeTextBox;
        private System.Windows.Forms.ComboBox RankBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Booking_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcitivityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activity_Name;
    }
}
