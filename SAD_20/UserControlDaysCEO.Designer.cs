namespace SAD_20
{
    partial class UserControlDaysCEO
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbDays = new System.Windows.Forms.Label();
            this.BusySchedule = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDays
            // 
            this.lbDays.AutoSize = true;
            this.lbDays.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDays.Location = new System.Drawing.Point(3, 11);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(27, 19);
            this.lbDays.TabIndex = 1;
            this.lbDays.Text = "00";
            // 
            // BusySchedule
            // 
            this.BusySchedule.AutoSize = true;
            this.BusySchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusySchedule.Location = new System.Drawing.Point(3, 73);
            this.BusySchedule.Name = "BusySchedule";
            this.BusySchedule.Size = new System.Drawing.Size(28, 16);
            this.BusySchedule.TabIndex = 2;
            this.BusySchedule.Text = "-----";
            this.BusySchedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlDaysCEO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.BusySchedule);
            this.Controls.Add(this.lbDays);
            this.Name = "UserControlDaysCEO";
            this.Size = new System.Drawing.Size(150, 108);
            this.Load += new System.EventHandler(this.UserControlDaysCEO_Load);
            this.DoubleClick += new System.EventHandler(this.UserControlDaysCEO_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDays;
        private System.Windows.Forms.Label BusySchedule;
    }
}
