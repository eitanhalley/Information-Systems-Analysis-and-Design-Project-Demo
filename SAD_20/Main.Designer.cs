namespace SAD_20
{
    partial class Main
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
            this.getallclientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_20DataSet = new SAD_20.SAD_20DataSet();
            this.get_all_clientsTableAdapter = new SAD_20.SAD_20DataSetTableAdapters.Get_all_clientsTableAdapter();
            this.mainTitle = new System.Windows.Forms.Label();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.Confirm_BTN = new System.Windows.Forms.Button();
            this.VisibleBtn = new System.Windows.Forms.Button();
            this.EmailTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.getallclientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_20DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // getallclientsBindingSource
            // 
            this.getallclientsBindingSource.DataMember = "Get_all_clients";
            this.getallclientsBindingSource.DataSource = this.sAD_20DataSet;
            // 
            // sAD_20DataSet
            // 
            this.sAD_20DataSet.DataSetName = "SAD_20DataSet";
            this.sAD_20DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // get_all_clientsTableAdapter
            // 
            this.get_all_clientsTableAdapter.ClearBeforeFill = true;
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainTitle.Font = new System.Drawing.Font("Ink Free", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.Location = new System.Drawing.Point(12, 471);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(230, 43);
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "Ronnie Dunetz";
            this.mainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.EmailTextbox.Location = new System.Drawing.Point(623, 95);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(170, 20);
            this.EmailTextbox.TabIndex = 3;
            this.EmailTextbox.Text = "Email";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PasswordTextbox.Location = new System.Drawing.Point(623, 121);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.Size = new System.Drawing.Size(170, 20);
            this.PasswordTextbox.TabIndex = 4;
            this.PasswordTextbox.Text = "Password";
            // 
            // Confirm_BTN
            // 
            this.Confirm_BTN.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Confirm_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_BTN.Location = new System.Drawing.Point(661, 156);
            this.Confirm_BTN.Name = "Confirm_BTN";
            this.Confirm_BTN.Size = new System.Drawing.Size(95, 31);
            this.Confirm_BTN.TabIndex = 6;
            this.Confirm_BTN.Text = "Sign In";
            this.Confirm_BTN.UseVisualStyleBackColor = false;
            this.Confirm_BTN.Click += new System.EventHandler(this.Confirm_BTN_Click);
            // 
            // VisibleBtn
            // 
            this.VisibleBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.VisibleBtn.BackgroundImage = global::SAD_20.Properties.Resources.VisiblePic;
            this.VisibleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VisibleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisibleBtn.Location = new System.Drawing.Point(799, 120);
            this.VisibleBtn.Name = "VisibleBtn";
            this.VisibleBtn.Size = new System.Drawing.Size(26, 20);
            this.VisibleBtn.TabIndex = 7;
            this.VisibleBtn.UseVisualStyleBackColor = false;
            this.VisibleBtn.Click += new System.EventHandler(this.VisibleBtn_Click);
            // 
            // EmailTimer
            // 
            this.EmailTimer.Enabled = true;
            this.EmailTimer.Interval = 100000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(620, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome, please sign in";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SAD_20.Properties.Resources.R;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(837, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VisibleBtn);
            this.Controls.Add(this.Confirm_BTN);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.mainTitle);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getallclientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_20DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SAD_20DataSet sAD_20DataSet;
        private System.Windows.Forms.BindingSource getallclientsBindingSource;
        private SAD_20DataSetTableAdapters.Get_all_clientsTableAdapter get_all_clientsTableAdapter;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Button Confirm_BTN;
        private System.Windows.Forms.Button VisibleBtn;
        private System.Windows.Forms.Timer EmailTimer;
        private System.Windows.Forms.Label label1;
    }
}

