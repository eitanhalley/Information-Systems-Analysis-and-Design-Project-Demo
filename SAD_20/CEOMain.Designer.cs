namespace SAD_20
{
    partial class CEOMain
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
            this.ClientsBtn = new System.Windows.Forms.Button();
            this.ScheduleBtn = new System.Windows.Forms.Button();
            this.LecturesBtn = new System.Windows.Forms.Button();
            this.WorkshopsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.FPCBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientsBtn
            // 
            this.ClientsBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsBtn.Location = new System.Drawing.Point(87, 173);
            this.ClientsBtn.Name = "ClientsBtn";
            this.ClientsBtn.Size = new System.Drawing.Size(133, 55);
            this.ClientsBtn.TabIndex = 9;
            this.ClientsBtn.Text = "Clients";
            this.ClientsBtn.UseVisualStyleBackColor = false;
            this.ClientsBtn.Click += new System.EventHandler(this.ClientsBtn_Click);
            // 
            // ScheduleBtn
            // 
            this.ScheduleBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ScheduleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleBtn.Location = new System.Drawing.Point(144, 271);
            this.ScheduleBtn.Name = "ScheduleBtn";
            this.ScheduleBtn.Size = new System.Drawing.Size(152, 47);
            this.ScheduleBtn.TabIndex = 8;
            this.ScheduleBtn.Text = "Visit Schedule";
            this.ScheduleBtn.UseVisualStyleBackColor = false;
            this.ScheduleBtn.Click += new System.EventHandler(this.ScheduleBtn_Click);
            // 
            // LecturesBtn
            // 
            this.LecturesBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LecturesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecturesBtn.Location = new System.Drawing.Point(446, 173);
            this.LecturesBtn.Name = "LecturesBtn";
            this.LecturesBtn.Size = new System.Drawing.Size(126, 55);
            this.LecturesBtn.TabIndex = 7;
            this.LecturesBtn.Text = "Lectures";
            this.LecturesBtn.UseVisualStyleBackColor = false;
            this.LecturesBtn.Click += new System.EventHandler(this.LecturesBtn_Click);
            // 
            // WorkshopsBtn
            // 
            this.WorkshopsBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.WorkshopsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkshopsBtn.Location = new System.Drawing.Point(267, 173);
            this.WorkshopsBtn.Name = "WorkshopsBtn";
            this.WorkshopsBtn.Size = new System.Drawing.Size(131, 55);
            this.WorkshopsBtn.TabIndex = 6;
            this.WorkshopsBtn.Text = "Workshops";
            this.WorkshopsBtn.UseVisualStyleBackColor = false;
            this.WorkshopsBtn.Click += new System.EventHandler(this.WorkshopsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hi, Ronnie";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(551, 405);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(89, 35);
            this.BackBtn.TabIndex = 10;
            this.BackBtn.Text = "Exit";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // FPCBtn
            // 
            this.FPCBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FPCBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPCBtn.Location = new System.Drawing.Point(349, 271);
            this.FPCBtn.Name = "FPCBtn";
            this.FPCBtn.Size = new System.Drawing.Size(181, 47);
            this.FPCBtn.TabIndex = 11;
            this.FPCBtn.Text = "Find Potential Clients";
            this.FPCBtn.UseVisualStyleBackColor = false;
            this.FPCBtn.Click += new System.EventHandler(this.FPCBtn_Click);
            // 
            // CEOMain
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::SAD_20.Properties.Resources.Background_ronnie;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 464);
            this.Controls.Add(this.FPCBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ClientsBtn);
            this.Controls.Add(this.ScheduleBtn);
            this.Controls.Add(this.LecturesBtn);
            this.Controls.Add(this.WorkshopsBtn);
            this.Controls.Add(this.label1);
            this.Name = "CEOMain";
            this.Text = "CEO MAIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClientsBtn;
        private System.Windows.Forms.Button ScheduleBtn;
        private System.Windows.Forms.Button LecturesBtn;
        private System.Windows.Forms.Button WorkshopsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button FPCBtn;
    }
}
