namespace SAD_20
{
    partial class ViewWorkshops_Client
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
            this.View_btn = new System.Windows.Forms.Button();
            this.back_button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Workshops = new System.Windows.Forms.DataGridView();
            this.ActivityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatsLeftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getallworkshopsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_20DataSet = new SAD_20.SAD_20DataSet();
            this.WorkshopSearch_textBox = new System.Windows.Forms.TextBox();
            this.get_all_workshopsTableAdapter = new SAD_20.SAD_20DataSetTableAdapters.Get_all_workshopsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Workshops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getallworkshopsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_20DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // View_btn
            // 
            this.View_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.View_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.View_btn.Location = new System.Drawing.Point(297, 315);
            this.View_btn.Name = "View_btn";
            this.View_btn.Size = new System.Drawing.Size(120, 53);
            this.View_btn.TabIndex = 23;
            this.View_btn.Text = "View Details";
            this.View_btn.UseVisualStyleBackColor = false;
            this.View_btn.Click += new System.EventHandler(this.View_btn_Click);
            // 
            // back_button1
            // 
            this.back_button1.Location = new System.Drawing.Point(547, 392);
            this.back_button1.Name = "back_button1";
            this.back_button1.Size = new System.Drawing.Size(75, 23);
            this.back_button1.TabIndex = 22;
            this.back_button1.Text = "Back";
            this.back_button1.UseVisualStyleBackColor = true;
            this.back_button1.Click += new System.EventHandler(this.back_button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(275, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 33);
            this.label1.TabIndex = 21;
            this.label1.Text = "Workshops";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(56, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Search Workshop";
            // 
            // dataGridView_Workshops
            // 
            this.dataGridView_Workshops.AllowUserToAddRows = false;
            this.dataGridView_Workshops.AllowUserToDeleteRows = false;
            this.dataGridView_Workshops.AllowUserToOrderColumns = true;
            this.dataGridView_Workshops.AutoGenerateColumns = false;
            this.dataGridView_Workshops.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Workshops.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Workshops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Workshops.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActivityID,
            this.nameDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.seatsLeftDataGridViewTextBoxColumn});
            this.dataGridView_Workshops.DataSource = this.getallworkshopsBindingSource;
            this.dataGridView_Workshops.Location = new System.Drawing.Point(59, 131);
            this.dataGridView_Workshops.Name = "dataGridView_Workshops";
            this.dataGridView_Workshops.ReadOnly = true;
            this.dataGridView_Workshops.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Workshops.Size = new System.Drawing.Size(598, 178);
            this.dataGridView_Workshops.TabIndex = 19;
            // 
            // ActivityID
            // 
            this.ActivityID.DataPropertyName = "ActivityID";
            this.ActivityID.HeaderText = "ActivityID";
            this.ActivityID.Name = "ActivityID";
            this.ActivityID.ReadOnly = true;
            this.ActivityID.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seatsLeftDataGridViewTextBoxColumn
            // 
            this.seatsLeftDataGridViewTextBoxColumn.DataPropertyName = "SeatsLeft";
            this.seatsLeftDataGridViewTextBoxColumn.HeaderText = "Seats Left";
            this.seatsLeftDataGridViewTextBoxColumn.Name = "seatsLeftDataGridViewTextBoxColumn";
            this.seatsLeftDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getallworkshopsBindingSource
            // 
            this.getallworkshopsBindingSource.DataMember = "Get_all_workshops";
            this.getallworkshopsBindingSource.DataSource = this.sAD_20DataSet;
            // 
            // sAD_20DataSet
            // 
            this.sAD_20DataSet.DataSetName = "SAD_20DataSet";
            this.sAD_20DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // WorkshopSearch_textBox
            // 
            this.WorkshopSearch_textBox.Location = new System.Drawing.Point(155, 105);
            this.WorkshopSearch_textBox.Name = "WorkshopSearch_textBox";
            this.WorkshopSearch_textBox.Size = new System.Drawing.Size(238, 20);
            this.WorkshopSearch_textBox.TabIndex = 18;
            this.WorkshopSearch_textBox.TextChanged += new System.EventHandler(this.lectureSearch_textBox_TextChanged_1);
            // 
            // get_all_workshopsTableAdapter
            // 
            this.get_all_workshopsTableAdapter.ClearBeforeFill = true;
            // 
            // ViewWorkshops_Client
            // 
            this.ClientSize = new System.Drawing.Size(702, 436);
            this.Controls.Add(this.View_btn);
            this.Controls.Add(this.back_button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_Workshops);
            this.Controls.Add(this.WorkshopSearch_textBox);
            this.Name = "ViewWorkshops_Client";
            this.Load += new System.EventHandler(this.ViewWorkshops_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Workshops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getallworkshopsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_20DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button View_btn;
        private System.Windows.Forms.Button back_button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Workshops;
        private System.Windows.Forms.TextBox WorkshopSearch_textBox;
        private SAD_20DataSet sAD_20DataSet;
        private System.Windows.Forms.BindingSource getallworkshopsBindingSource;
        private SAD_20DataSetTableAdapters.Get_all_workshopsTableAdapter get_all_workshopsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatsLeftDataGridViewTextBoxColumn;
    }
}
