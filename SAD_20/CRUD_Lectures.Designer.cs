namespace SAD_20
{
    partial class CRUD_Lectures
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
            this.CRUD_View_BTN_Lecture = new System.Windows.Forms.Button();
            this.CRUD_Create_BTN_Lecutre = new System.Windows.Forms.Button();
            this.CRUD_Update_BTN_Lecture = new System.Windows.Forms.Button();
            this.CRUD_Delete_BTN_Lecture = new System.Windows.Forms.Button();
            this.CRUD_Back_BTN_Lecture = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CRUD_View_BTN_Lecture
            // 
            this.CRUD_View_BTN_Lecture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CRUD_View_BTN_Lecture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CRUD_View_BTN_Lecture.Location = new System.Drawing.Point(54, 188);
            this.CRUD_View_BTN_Lecture.Name = "CRUD_View_BTN_Lecture";
            this.CRUD_View_BTN_Lecture.Size = new System.Drawing.Size(128, 60);
            this.CRUD_View_BTN_Lecture.TabIndex = 0;
            this.CRUD_View_BTN_Lecture.Text = "View";
            this.CRUD_View_BTN_Lecture.UseVisualStyleBackColor = false;
            this.CRUD_View_BTN_Lecture.Click += new System.EventHandler(this.CRUD_View_BTN_Lecture_Click);
            // 
            // CRUD_Create_BTN_Lecutre
            // 
            this.CRUD_Create_BTN_Lecutre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CRUD_Create_BTN_Lecutre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CRUD_Create_BTN_Lecutre.Location = new System.Drawing.Point(213, 188);
            this.CRUD_Create_BTN_Lecutre.Name = "CRUD_Create_BTN_Lecutre";
            this.CRUD_Create_BTN_Lecutre.Size = new System.Drawing.Size(128, 60);
            this.CRUD_Create_BTN_Lecutre.TabIndex = 1;
            this.CRUD_Create_BTN_Lecutre.Text = "Create";
            this.CRUD_Create_BTN_Lecutre.UseVisualStyleBackColor = false;
            this.CRUD_Create_BTN_Lecutre.Click += new System.EventHandler(this.CRUD_Create_BTN_Lecutre_Click);
            // 
            // CRUD_Update_BTN_Lecture
            // 
            this.CRUD_Update_BTN_Lecture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CRUD_Update_BTN_Lecture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CRUD_Update_BTN_Lecture.Location = new System.Drawing.Point(379, 188);
            this.CRUD_Update_BTN_Lecture.Name = "CRUD_Update_BTN_Lecture";
            this.CRUD_Update_BTN_Lecture.Size = new System.Drawing.Size(128, 60);
            this.CRUD_Update_BTN_Lecture.TabIndex = 2;
            this.CRUD_Update_BTN_Lecture.Text = "Update";
            this.CRUD_Update_BTN_Lecture.UseVisualStyleBackColor = false;
            this.CRUD_Update_BTN_Lecture.Click += new System.EventHandler(this.CRUD_Update_BTN_Lecture_Click);
            // 
            // CRUD_Delete_BTN_Lecture
            // 
            this.CRUD_Delete_BTN_Lecture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CRUD_Delete_BTN_Lecture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CRUD_Delete_BTN_Lecture.Location = new System.Drawing.Point(534, 188);
            this.CRUD_Delete_BTN_Lecture.Name = "CRUD_Delete_BTN_Lecture";
            this.CRUD_Delete_BTN_Lecture.Size = new System.Drawing.Size(128, 60);
            this.CRUD_Delete_BTN_Lecture.TabIndex = 3;
            this.CRUD_Delete_BTN_Lecture.Text = "Delete";
            this.CRUD_Delete_BTN_Lecture.UseVisualStyleBackColor = false;
            this.CRUD_Delete_BTN_Lecture.Click += new System.EventHandler(this.CRUD_Delete_BTN_Lecture_Click);
            // 
            // CRUD_Back_BTN_Lecture
            // 
            this.CRUD_Back_BTN_Lecture.Location = new System.Drawing.Point(581, 326);
            this.CRUD_Back_BTN_Lecture.Name = "CRUD_Back_BTN_Lecture";
            this.CRUD_Back_BTN_Lecture.Size = new System.Drawing.Size(81, 37);
            this.CRUD_Back_BTN_Lecture.TabIndex = 4;
            this.CRUD_Back_BTN_Lecture.Text = "Back";
            this.CRUD_Back_BTN_Lecture.UseVisualStyleBackColor = true;
            this.CRUD_Back_BTN_Lecture.Click += new System.EventHandler(this.CRUD_Back_BTN_Lecture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(220, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 73);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lectures";
            // 
            // CRUD_Lectures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CRUD_Back_BTN_Lecture);
            this.Controls.Add(this.CRUD_Delete_BTN_Lecture);
            this.Controls.Add(this.CRUD_Update_BTN_Lecture);
            this.Controls.Add(this.CRUD_Create_BTN_Lecutre);
            this.Controls.Add(this.CRUD_View_BTN_Lecture);
            this.Name = "CRUD_Lectures";
            this.Text = "CRUD_Lectures";
            this.Load += new System.EventHandler(this.CRUD_Lectures_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CRUD_View_BTN_Lecture;
        private System.Windows.Forms.Button CRUD_Create_BTN_Lecutre;
        private System.Windows.Forms.Button CRUD_Update_BTN_Lecture;
        private System.Windows.Forms.Button CRUD_Delete_BTN_Lecture;
        private System.Windows.Forms.Button CRUD_Back_BTN_Lecture;
        private System.Windows.Forms.Label label1;
    }
}