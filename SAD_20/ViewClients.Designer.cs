namespace SAD_20
{
    partial class ViewClients
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
            this.dataGridView_Clients = new System.Windows.Forms.DataGridView();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfWorkshopsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfLecturesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastActivityDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getallclientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_20DataSet = new SAD_20.SAD_20DataSet();
            this.clientSearch = new System.Windows.Forms.TextBox();
            this.get_all_clientsTableAdapter = new SAD_20.SAD_20DataSetTableAdapters.Get_all_clientsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.Back_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getallclientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_20DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-136, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search Client";
            // 
            // dataGridView_Clients
            // 
            this.dataGridView_Clients.AllowUserToAddRows = false;
            this.dataGridView_Clients.AllowUserToDeleteRows = false;
            this.dataGridView_Clients.AutoGenerateColumns = false;
            this.dataGridView_Clients.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Clients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Clients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn,
            this.emailClientDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.addressCountryDataGridViewTextBoxColumn,
            this.addressCityDataGridViewTextBoxColumn,
            this.numOfWorkshopsDataGridViewTextBoxColumn,
            this.numOfLecturesDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.lastActivityDateDataGridViewTextBoxColumn});
            this.dataGridView_Clients.DataSource = this.getallclientsBindingSource;
            this.dataGridView_Clients.Location = new System.Drawing.Point(12, 152);
            this.dataGridView_Clients.MultiSelect = false;
            this.dataGridView_Clients.Name = "dataGridView_Clients";
            this.dataGridView_Clients.ReadOnly = true;
            this.dataGridView_Clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Clients.Size = new System.Drawing.Size(1174, 263);
            this.dataGridView_Clients.TabIndex = 2;
            this.dataGridView_Clients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Clients_CellContentClick);
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailClientDataGridViewTextBoxColumn
            // 
            this.emailClientDataGridViewTextBoxColumn.DataPropertyName = "Email_Client";
            this.emailClientDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailClientDataGridViewTextBoxColumn.Name = "emailClientDataGridViewTextBoxColumn";
            this.emailClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressCountryDataGridViewTextBoxColumn
            // 
            this.addressCountryDataGridViewTextBoxColumn.DataPropertyName = "AddressCountry";
            this.addressCountryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.addressCountryDataGridViewTextBoxColumn.Name = "addressCountryDataGridViewTextBoxColumn";
            this.addressCountryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressCityDataGridViewTextBoxColumn
            // 
            this.addressCityDataGridViewTextBoxColumn.DataPropertyName = "AddressCity";
            this.addressCityDataGridViewTextBoxColumn.HeaderText = "City";
            this.addressCityDataGridViewTextBoxColumn.Name = "addressCityDataGridViewTextBoxColumn";
            this.addressCityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numOfWorkshopsDataGridViewTextBoxColumn
            // 
            this.numOfWorkshopsDataGridViewTextBoxColumn.DataPropertyName = "NumOfWorkshops";
            this.numOfWorkshopsDataGridViewTextBoxColumn.HeaderText = "Workshops";
            this.numOfWorkshopsDataGridViewTextBoxColumn.Name = "numOfWorkshopsDataGridViewTextBoxColumn";
            this.numOfWorkshopsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numOfLecturesDataGridViewTextBoxColumn
            // 
            this.numOfLecturesDataGridViewTextBoxColumn.DataPropertyName = "NumOfLectures";
            this.numOfLecturesDataGridViewTextBoxColumn.HeaderText = "Lectures";
            this.numOfLecturesDataGridViewTextBoxColumn.Name = "numOfLecturesDataGridViewTextBoxColumn";
            this.numOfLecturesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastActivityDateDataGridViewTextBoxColumn
            // 
            this.lastActivityDateDataGridViewTextBoxColumn.DataPropertyName = "LastActivityDate";
            this.lastActivityDateDataGridViewTextBoxColumn.HeaderText = "Last Activity ";
            this.lastActivityDateDataGridViewTextBoxColumn.Name = "lastActivityDateDataGridViewTextBoxColumn";
            this.lastActivityDateDataGridViewTextBoxColumn.ReadOnly = true;
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
            // clientSearch
            // 
            this.clientSearch.Location = new System.Drawing.Point(204, 126);
            this.clientSearch.Name = "clientSearch";
            this.clientSearch.Size = new System.Drawing.Size(238, 20);
            this.clientSearch.TabIndex = 3;
            this.clientSearch.TextChanged += new System.EventHandler(this.clientSearch_TextChanged);
            // 
            // get_all_clientsTableAdapter
            // 
            this.get_all_clientsTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(128, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search Client";
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(1042, 470);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(75, 23);
            this.Back_btn.TabIndex = 7;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(482, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 55);
            this.label3.TabIndex = 8;
            this.label3.Text = "Clients";
            // 
            // ViewClients
            // 
            this.ClientSize = new System.Drawing.Size(1192, 521);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Clients);
            this.Controls.Add(this.clientSearch);
            this.Name = "ViewClients";
            this.Load += new System.EventHandler(this.ViewClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getallclientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_20DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Clients;
        private System.Windows.Forms.TextBox clientSearch;
        private SAD_20DataSet sAD_20DataSet;
        private System.Windows.Forms.BindingSource getallclientsBindingSource;
        private SAD_20DataSetTableAdapters.Get_all_clientsTableAdapter get_all_clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfWorkshopsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfLecturesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastActivityDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Label label3;
    }
}
