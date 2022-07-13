namespace SAD_20
{
    partial class AboutCEO
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
            this.About_richTextBox = new System.Windows.Forms.RichTextBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "About Ronnie";
            // 
            // About_richTextBox
            // 
            this.About_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.About_richTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.About_richTextBox.Location = new System.Drawing.Point(40, 94);
            this.About_richTextBox.Name = "About_richTextBox";
            this.About_richTextBox.ReadOnly = true;
            this.About_richTextBox.Size = new System.Drawing.Size(457, 240);
            this.About_richTextBox.TabIndex = 2;
            this.About_richTextBox.Text = "";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(612, 437);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 3;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // AboutCEO
            // 
            this.BackgroundImage = global::SAD_20.Properties.Resources.Background_ronnie;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 489);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.About_richTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AboutCEO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox About_richTextBox;
        private System.Windows.Forms.Button back_btn;
    }
}
