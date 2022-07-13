namespace SAD_20
{
    partial class Clients_CRUD
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
            this.createNewClient_btn = new System.Windows.Forms.Button();
            this.updateClient_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.DeleteClient_btn = new System.Windows.Forms.Button();
            this.Clients_lbl = new System.Windows.Forms.Label();
            this.ViewClients_btn = new System.Windows.Forms.Button();
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
            // createNewClient_btn
            // 
            this.createNewClient_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createNewClient_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.createNewClient_btn.Location = new System.Drawing.Point(228, 199);
            this.createNewClient_btn.Name = "createNewClient_btn";
            this.createNewClient_btn.Size = new System.Drawing.Size(145, 64);
            this.createNewClient_btn.TabIndex = 3;
            this.createNewClient_btn.Text = "Create";
            this.createNewClient_btn.UseVisualStyleBackColor = false;
            this.createNewClient_btn.Click += new System.EventHandler(this.createNewClient_btn_Click);
            // 
            // updateClient_btn
            // 
            this.updateClient_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateClient_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updateClient_btn.Location = new System.Drawing.Point(409, 199);
            this.updateClient_btn.Name = "updateClient_btn";
            this.updateClient_btn.Size = new System.Drawing.Size(137, 64);
            this.updateClient_btn.TabIndex = 4;
            this.updateClient_btn.Text = "Update";
            this.updateClient_btn.UseVisualStyleBackColor = false;
            this.updateClient_btn.Click += new System.EventHandler(this.updateClient_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(604, 320);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(93, 32);
            this.Back_btn.TabIndex = 5;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // DeleteClient_btn
            // 
            this.DeleteClient_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteClient_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DeleteClient_btn.Location = new System.Drawing.Point(576, 199);
            this.DeleteClient_btn.Name = "DeleteClient_btn";
            this.DeleteClient_btn.Size = new System.Drawing.Size(121, 64);
            this.DeleteClient_btn.TabIndex = 6;
            this.DeleteClient_btn.Text = "Delete";
            this.DeleteClient_btn.UseVisualStyleBackColor = false;
            this.DeleteClient_btn.Click += new System.EventHandler(this.DeleteClient_btn_Click);
            // 
            // Clients_lbl
            // 
            this.Clients_lbl.AutoSize = true;
            this.Clients_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Clients_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Clients_lbl.Location = new System.Drawing.Point(264, 57);
            this.Clients_lbl.Name = "Clients_lbl";
            this.Clients_lbl.Size = new System.Drawing.Size(235, 73);
            this.Clients_lbl.TabIndex = 7;
            this.Clients_lbl.Text = "Clients";
            // 
            // ViewClients_btn
            // 
            this.ViewClients_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ViewClients_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ViewClients_btn.Location = new System.Drawing.Point(52, 199);
            this.ViewClients_btn.Name = "ViewClients_btn";
            this.ViewClients_btn.Size = new System.Drawing.Size(144, 64);
            this.ViewClients_btn.TabIndex = 8;
            this.ViewClients_btn.Text = "View";
            this.ViewClients_btn.UseVisualStyleBackColor = false;
            this.ViewClients_btn.Click += new System.EventHandler(this.ViewClients_btn_Click);
            // 
            // Clients_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 401);
            this.Controls.Add(this.ViewClients_btn);
            this.Controls.Add(this.Clients_lbl);
            this.Controls.Add(this.DeleteClient_btn);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.updateClient_btn);
            this.Controls.Add(this.createNewClient_btn);
            this.Name = "Clients_CRUD";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Clients_CRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getallclientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_20DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SAD_20DataSet sAD_20DataSet;
        private System.Windows.Forms.BindingSource getallclientsBindingSource;
        private SAD_20DataSetTableAdapters.Get_all_clientsTableAdapter get_all_clientsTableAdapter;
        private System.Windows.Forms.Button createNewClient_btn;
        private System.Windows.Forms.Button updateClient_btn;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Button DeleteClient_btn;
        private System.Windows.Forms.Label Clients_lbl;
        private System.Windows.Forms.Button ViewClients_btn;
    }
}