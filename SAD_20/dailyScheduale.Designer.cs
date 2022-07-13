namespace SAD_20
{
    partial class dailyScheduale
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
            this.btn4PM = new System.Windows.Forms.Button();
            this.btn3PM = new System.Windows.Forms.Button();
            this.btn5PM = new System.Windows.Forms.Button();
            this.btn12PM = new System.Windows.Forms.Button();
            this.btn2PM = new System.Windows.Forms.Button();
            this.btn11AM = new System.Windows.Forms.Button();
            this.btn9AM = new System.Windows.Forms.Button();
            this.btn10AM = new System.Windows.Forms.Button();
            this.txdate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.sPGetCoachingMeetingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD20DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_20DataSet = new SAD_20.SAD_20DataSet();
            this.cOACHINGMEETINGSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOACHING_MEETINGSTableAdapter = new SAD_20.SAD_20DataSetTableAdapters.COACHING_MEETINGSTableAdapter();
            this.sP_Get_CoachingMeetingsTableAdapter = new SAD_20.SAD_20DataSetTableAdapters.SP_Get_CoachingMeetingsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPGetCoachingMeetingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD20DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_20DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOACHINGMEETINGSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn4PM
            // 
            this.btn4PM.Location = new System.Drawing.Point(342, 201);
            this.btn4PM.Name = "btn4PM";
            this.btn4PM.Size = new System.Drawing.Size(181, 23);
            this.btn4PM.TabIndex = 2;
            this.btn4PM.Text = "16:00 P.M - 17:00 P.M  ";
            this.btn4PM.UseVisualStyleBackColor = true;
            this.btn4PM.Click += new System.EventHandler(this.btn4PM_Click);
            // 
            // btn3PM
            // 
            this.btn3PM.Location = new System.Drawing.Point(342, 153);
            this.btn3PM.Name = "btn3PM";
            this.btn3PM.Size = new System.Drawing.Size(181, 23);
            this.btn3PM.TabIndex = 2;
            this.btn3PM.Text = "15:00 P.M - 16:00 P.M  ";
            this.btn3PM.UseVisualStyleBackColor = true;
            this.btn3PM.Click += new System.EventHandler(this.btn3PM_Click);
            // 
            // btn5PM
            // 
            this.btn5PM.Location = new System.Drawing.Point(342, 250);
            this.btn5PM.Name = "btn5PM";
            this.btn5PM.Size = new System.Drawing.Size(181, 23);
            this.btn5PM.TabIndex = 1;
            this.btn5PM.Text = "17:00 P.M - 18:00 P.M  ";
            this.btn5PM.UseVisualStyleBackColor = true;
            this.btn5PM.Click += new System.EventHandler(this.btn5PM_Click);
            // 
            // btn12PM
            // 
            this.btn12PM.Location = new System.Drawing.Point(62, 250);
            this.btn12PM.Name = "btn12PM";
            this.btn12PM.Size = new System.Drawing.Size(181, 23);
            this.btn12PM.TabIndex = 2;
            this.btn12PM.Text = "12:00 P.M - 13:00 P.M  ";
            this.btn12PM.UseVisualStyleBackColor = true;
            this.btn12PM.Click += new System.EventHandler(this.btn12PM_Click);
            // 
            // btn2PM
            // 
            this.btn2PM.Location = new System.Drawing.Point(342, 108);
            this.btn2PM.Name = "btn2PM";
            this.btn2PM.Size = new System.Drawing.Size(181, 23);
            this.btn2PM.TabIndex = 1;
            this.btn2PM.Text = "14:00 P.M - 15:00 P.M  ";
            this.btn2PM.UseVisualStyleBackColor = true;
            this.btn2PM.Click += new System.EventHandler(this.btn2PM_Click);
            // 
            // btn11AM
            // 
            this.btn11AM.Location = new System.Drawing.Point(62, 201);
            this.btn11AM.Name = "btn11AM";
            this.btn11AM.Size = new System.Drawing.Size(181, 23);
            this.btn11AM.TabIndex = 1;
            this.btn11AM.Text = "11:00 A.M - 12:00 P.M  ";
            this.btn11AM.UseVisualStyleBackColor = true;
            this.btn11AM.Click += new System.EventHandler(this.btn11AM_Click);
            // 
            // btn9AM
            // 
            this.btn9AM.Location = new System.Drawing.Point(62, 108);
            this.btn9AM.Name = "btn9AM";
            this.btn9AM.Size = new System.Drawing.Size(181, 23);
            this.btn9AM.TabIndex = 2;
            this.btn9AM.Text = "9:00 A.M - 10:00 A.M  ";
            this.btn9AM.UseVisualStyleBackColor = true;
            this.btn9AM.Click += new System.EventHandler(this.btn9AM_Click);
            // 
            // btn10AM
            // 
            this.btn10AM.Location = new System.Drawing.Point(62, 153);
            this.btn10AM.Name = "btn10AM";
            this.btn10AM.Size = new System.Drawing.Size(181, 23);
            this.btn10AM.TabIndex = 1;
            this.btn10AM.Text = "10:00 A.M - 11:00 A.M  ";
            this.btn10AM.UseVisualStyleBackColor = true;
            this.btn10AM.Click += new System.EventHandler(this.btn10AM_Click);
            // 
            // txdate
            // 
            this.txdate.AutoSize = true;
            this.txdate.Font = new System.Drawing.Font("MS PGothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txdate.Location = new System.Drawing.Point(263, 40);
            this.txdate.Name = "txdate";
            this.txdate.Size = new System.Drawing.Size(0, 33);
            this.txdate.TabIndex = 3;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(194, 54);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(202, 20);
            this.txtDate.TabIndex = 4;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(263, 12);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(72, 31);
            this.lbDate.TabIndex = 5;
            this.lbDate.Text = "Date";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(260, 325);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Return";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // sPGetCoachingMeetingsBindingSource
            // 
            this.sPGetCoachingMeetingsBindingSource.DataMember = "SP_Get_CoachingMeetings";
            this.sPGetCoachingMeetingsBindingSource.DataSource = this.sAD20DataSetBindingSource;
            // 
            // sAD20DataSetBindingSource
            // 
            this.sAD20DataSetBindingSource.DataSource = this.sAD_20DataSet;
            this.sAD20DataSetBindingSource.Position = 0;
            // 
            // sAD_20DataSet
            // 
            this.sAD_20DataSet.DataSetName = "SAD_20DataSet";
            this.sAD_20DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOACHINGMEETINGSBindingSource
            // 
            this.cOACHINGMEETINGSBindingSource.DataMember = "COACHING_MEETINGS";
            this.cOACHINGMEETINGSBindingSource.DataSource = this.sAD20DataSetBindingSource;
            // 
            // cOACHING_MEETINGSTableAdapter
            // 
            this.cOACHING_MEETINGSTableAdapter.ClearBeforeFill = true;
            // 
            // sP_Get_CoachingMeetingsTableAdapter
            // 
            this.sP_Get_CoachingMeetingsTableAdapter.ClearBeforeFill = true;
            // 
            // dailyScheduale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 360);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txdate);
            this.Controls.Add(this.btn4PM);
            this.Controls.Add(this.btn12PM);
            this.Controls.Add(this.btn3PM);
            this.Controls.Add(this.btn5PM);
            this.Controls.Add(this.btn9AM);
            this.Controls.Add(this.btn2PM);
            this.Controls.Add(this.btn11AM);
            this.Controls.Add(this.btn10AM);
            this.Name = "dailyScheduale";
            this.Text = "dailyScheduale";
            this.Load += new System.EventHandler(this.dailyScheduale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPGetCoachingMeetingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD20DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_20DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOACHINGMEETINGSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn4PM;
        private System.Windows.Forms.Button btn3PM;
        private System.Windows.Forms.Button btn5PM;
        private System.Windows.Forms.Button btn12PM;
        private System.Windows.Forms.Button btn2PM;
        private System.Windows.Forms.Button btn11AM;
        private System.Windows.Forms.Button btn9AM;
        private System.Windows.Forms.Button btn10AM;
        private System.Windows.Forms.Label txdate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.BindingSource sAD20DataSetBindingSource;
        private SAD_20DataSet sAD_20DataSet;
        private System.Windows.Forms.BindingSource cOACHINGMEETINGSBindingSource;
        private SAD_20DataSetTableAdapters.COACHING_MEETINGSTableAdapter cOACHING_MEETINGSTableAdapter;
        private System.Windows.Forms.BindingSource sPGetCoachingMeetingsBindingSource;
        private SAD_20DataSetTableAdapters.SP_Get_CoachingMeetingsTableAdapter sP_Get_CoachingMeetingsTableAdapter;
    }
}