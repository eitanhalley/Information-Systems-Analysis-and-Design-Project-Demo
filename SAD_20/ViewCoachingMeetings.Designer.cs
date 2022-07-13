namespace SAD_20
{
    partial class ViewCoachingMeetings
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
            this.txtDate = new System.Windows.Forms.Label();
            this.txtCoachDate = new System.Windows.Forms.TextBox();
            this.btn9AM = new System.Windows.Forms.Button();
            this.btn10AM = new System.Windows.Forms.Button();
            this.btn11AM = new System.Windows.Forms.Button();
            this.btn12PM = new System.Windows.Forms.Button();
            this.btn14PM = new System.Windows.Forms.Button();
            this.btn15PM = new System.Windows.Forms.Button();
            this.btn16PM = new System.Windows.Forms.Button();
            this.btn17PM = new System.Windows.Forms.Button();
            this.btnRTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.BackColor = System.Drawing.Color.Transparent;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtDate.Location = new System.Drawing.Point(232, 21);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(72, 31);
            this.txtDate.TabIndex = 0;
            this.txtDate.Text = "Date";
            // 
            // txtCoachDate
            // 
            this.txtCoachDate.Location = new System.Drawing.Point(215, 55);
            this.txtCoachDate.Name = "txtCoachDate";
            this.txtCoachDate.ReadOnly = true;
            this.txtCoachDate.Size = new System.Drawing.Size(100, 20);
            this.txtCoachDate.TabIndex = 1;
            this.txtCoachDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCoachDate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn9AM
            // 
            this.btn9AM.Location = new System.Drawing.Point(27, 125);
            this.btn9AM.Name = "btn9AM";
            this.btn9AM.Size = new System.Drawing.Size(206, 23);
            this.btn9AM.TabIndex = 2;
            this.btn9AM.Text = "9:00 - 10:00";
            this.btn9AM.UseVisualStyleBackColor = true;
            // 
            // btn10AM
            // 
            this.btn10AM.Location = new System.Drawing.Point(27, 176);
            this.btn10AM.Name = "btn10AM";
            this.btn10AM.Size = new System.Drawing.Size(206, 23);
            this.btn10AM.TabIndex = 2;
            this.btn10AM.Text = "10:00 - 11:00";
            this.btn10AM.UseVisualStyleBackColor = true;
            // 
            // btn11AM
            // 
            this.btn11AM.Location = new System.Drawing.Point(27, 227);
            this.btn11AM.Name = "btn11AM";
            this.btn11AM.Size = new System.Drawing.Size(206, 23);
            this.btn11AM.TabIndex = 2;
            this.btn11AM.Text = "11:00 - 12:00";
            this.btn11AM.UseVisualStyleBackColor = true;
            // 
            // btn12PM
            // 
            this.btn12PM.Location = new System.Drawing.Point(27, 280);
            this.btn12PM.Name = "btn12PM";
            this.btn12PM.Size = new System.Drawing.Size(206, 23);
            this.btn12PM.TabIndex = 2;
            this.btn12PM.Text = "12:00 - 13:00";
            this.btn12PM.UseVisualStyleBackColor = true;
            // 
            // btn14PM
            // 
            this.btn14PM.Location = new System.Drawing.Point(299, 125);
            this.btn14PM.Name = "btn14PM";
            this.btn14PM.Size = new System.Drawing.Size(206, 23);
            this.btn14PM.TabIndex = 2;
            this.btn14PM.Text = "14:00 - 15:00";
            this.btn14PM.UseVisualStyleBackColor = true;
            // 
            // btn15PM
            // 
            this.btn15PM.Location = new System.Drawing.Point(299, 176);
            this.btn15PM.Name = "btn15PM";
            this.btn15PM.Size = new System.Drawing.Size(206, 23);
            this.btn15PM.TabIndex = 2;
            this.btn15PM.Text = "15:00 - 16:00";
            this.btn15PM.UseVisualStyleBackColor = true;
            // 
            // btn16PM
            // 
            this.btn16PM.Location = new System.Drawing.Point(299, 227);
            this.btn16PM.Name = "btn16PM";
            this.btn16PM.Size = new System.Drawing.Size(206, 23);
            this.btn16PM.TabIndex = 2;
            this.btn16PM.Text = "16:00 - 17:00";
            this.btn16PM.UseVisualStyleBackColor = true;
            // 
            // btn17PM
            // 
            this.btn17PM.Location = new System.Drawing.Point(299, 280);
            this.btn17PM.Name = "btn17PM";
            this.btn17PM.Size = new System.Drawing.Size(206, 23);
            this.btn17PM.TabIndex = 2;
            this.btn17PM.Text = "17:00 - 18:00";
            this.btn17PM.UseVisualStyleBackColor = true;
            // 
            // btnRTN
            // 
            this.btnRTN.Location = new System.Drawing.Point(229, 378);
            this.btnRTN.Name = "btnRTN";
            this.btnRTN.Size = new System.Drawing.Size(75, 23);
            this.btnRTN.TabIndex = 3;
            this.btnRTN.Text = "Return";
            this.btnRTN.UseVisualStyleBackColor = true;
            this.btnRTN.Click += new System.EventHandler(this.btnRTN_Click);
            // 
            // ViewCoachingMeetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 413);
            this.Controls.Add(this.btnRTN);
            this.Controls.Add(this.btn17PM);
            this.Controls.Add(this.btn12PM);
            this.Controls.Add(this.btn16PM);
            this.Controls.Add(this.btn11AM);
            this.Controls.Add(this.btn15PM);
            this.Controls.Add(this.btn14PM);
            this.Controls.Add(this.btn10AM);
            this.Controls.Add(this.btn9AM);
            this.Controls.Add(this.txtCoachDate);
            this.Controls.Add(this.txtDate);
            this.Name = "ViewCoachingMeetings";
            this.Text = "ViewCoachingMeetings";
            this.Load += new System.EventHandler(this.ViewCoachingMeetings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.TextBox txtCoachDate;
        private System.Windows.Forms.Button btn9AM;
        private System.Windows.Forms.Button btn10AM;
        private System.Windows.Forms.Button btn11AM;
        private System.Windows.Forms.Button btn12PM;
        private System.Windows.Forms.Button btn14PM;
        private System.Windows.Forms.Button btn15PM;
        private System.Windows.Forms.Button btn16PM;
        private System.Windows.Forms.Button btn17PM;
        private System.Windows.Forms.Button btnRTN;
    }
}