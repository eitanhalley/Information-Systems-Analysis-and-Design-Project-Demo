﻿namespace Example_Project
{
    partial class CRUD
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_new = new System.Windows.Forms.Button();
            this.button_exist = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(20, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(707, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "ניהול פרטי עובדים";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(48, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(741, 220);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button_new
            // 
            this.button_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_new.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_new.Location = new System.Drawing.Point(48, 420);
            this.button_new.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(300, 149);
            this.button_new.TabIndex = 2;
            this.button_new.Text = "יצירת עובד חדש";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // button_exist
            // 
            this.button_exist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exist.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button_exist.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_exist.Location = new System.Drawing.Point(489, 420);
            this.button_exist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_exist.Name = "button_exist";
            this.button_exist.Size = new System.Drawing.Size(300, 151);
            this.button_exist.TabIndex = 3;
            this.button_exist.Text = "צפייה בעובד קיים";
            this.button_exist.UseVisualStyleBackColor = true;
            this.button_exist.Click += new System.EventHandler(this.button_exist_Click);
            // 
            // button_exit
            // 
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_exit.Location = new System.Drawing.Point(339, 780);
            this.button_exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(177, 60);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "יציאה";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(339, 647);
            this.back.Name = "back";
            this.back.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.back.Size = new System.Drawing.Size(132, 50);
            this.back.TabIndex = 9;
            this.back.Text = "חזור";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(848, 862);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_exist);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CRUD";
            this.Text = "main_form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Button button_exist;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button back;
    }
}