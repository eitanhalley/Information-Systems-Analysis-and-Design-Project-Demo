namespace SAD_20
{
    partial class ViewLectures_Client
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Lectures = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectureTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatsLeftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getallLecturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_20DataSet = new SAD_20.SAD_20DataSet();
            this.lectureSearch_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.get_all_LecturesTableAdapter = new SAD_20.SAD_20DataSetTableAdapters.Get_all_LecturesTableAdapter();
            this.back_button1 = new System.Windows.Forms.Button();
            this.View_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lectures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getallLecturesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_20DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(28, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search Lecture";
            // 
            // dataGridView_Lectures
            // 
            this.dataGridView_Lectures.AllowUserToAddRows = false;
            this.dataGridView_Lectures.AllowUserToDeleteRows = false;
            this.dataGridView_Lectures.AllowUserToOrderColumns = true;
            this.dataGridView_Lectures.AutoGenerateColumns = false;
            this.dataGridView_Lectures.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Lectures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Lectures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Lectures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nameDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.lectureTypeDataGridViewTextBoxColumn,
            this.seatsLeftDataGridViewTextBoxColumn});
            this.dataGridView_Lectures.DataSource = this.getallLecturesBindingSource;
            this.dataGridView_Lectures.Location = new System.Drawing.Point(31, 119);
            this.dataGridView_Lectures.Name = "dataGridView_Lectures";
            this.dataGridView_Lectures.ReadOnly = true;
            this.dataGridView_Lectures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Lectures.Size = new System.Drawing.Size(644, 178);
            this.dataGridView_Lectures.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ActivityID";
            this.ID.HeaderText = "ActivityID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Lecture Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Date";
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
            // lectureTypeDataGridViewTextBoxColumn
            // 
            this.lectureTypeDataGridViewTextBoxColumn.DataPropertyName = "LectureType";
            this.lectureTypeDataGridViewTextBoxColumn.HeaderText = "Lecture Type";
            this.lectureTypeDataGridViewTextBoxColumn.Name = "lectureTypeDataGridViewTextBoxColumn";
            this.lectureTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seatsLeftDataGridViewTextBoxColumn
            // 
            this.seatsLeftDataGridViewTextBoxColumn.DataPropertyName = "SeatsLeft";
            this.seatsLeftDataGridViewTextBoxColumn.HeaderText = "Seats Left";
            this.seatsLeftDataGridViewTextBoxColumn.Name = "seatsLeftDataGridViewTextBoxColumn";
            this.seatsLeftDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getallLecturesBindingSource
            // 
            this.getallLecturesBindingSource.DataMember = "Get_all_Lectures";
            this.getallLecturesBindingSource.DataSource = this.sAD_20DataSet;
            // 
            // sAD_20DataSet
            // 
            this.sAD_20DataSet.DataSetName = "SAD_20DataSet";
            this.sAD_20DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lectureSearch_textBox
            // 
            this.lectureSearch_textBox.Location = new System.Drawing.Point(114, 93);
            this.lectureSearch_textBox.Name = "lectureSearch_textBox";
            this.lectureSearch_textBox.Size = new System.Drawing.Size(238, 20);
            this.lectureSearch_textBox.TabIndex = 7;
            this.lectureSearch_textBox.TextChanged += new System.EventHandler(this.lectureSearch_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(282, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lectures";
            // 
            // get_all_LecturesTableAdapter
            // 
            this.get_all_LecturesTableAdapter.ClearBeforeFill = true;
            // 
            // back_button1
            // 
            this.back_button1.Location = new System.Drawing.Point(600, 380);
            this.back_button1.Name = "back_button1";
            this.back_button1.Size = new System.Drawing.Size(75, 23);
            this.back_button1.TabIndex = 16;
            this.back_button1.Text = "Back";
            this.back_button1.UseVisualStyleBackColor = true;
            this.back_button1.Click += new System.EventHandler(this.back_button1_Click);
            // 
            // View_btn
            // 
            this.View_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.View_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.View_btn.Location = new System.Drawing.Point(297, 350);
            this.View_btn.Name = "View_btn";
            this.View_btn.Size = new System.Drawing.Size(120, 53);
            this.View_btn.TabIndex = 17;
            this.View_btn.Text = "View Details";
            this.View_btn.UseVisualStyleBackColor = false;
            this.View_btn.Click += new System.EventHandler(this.View_btn_Click);
            // 
            // ViewLectures_Client
            // 
            this.ClientSize = new System.Drawing.Size(761, 431);
            this.Controls.Add(this.View_btn);
            this.Controls.Add(this.back_button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_Lectures);
            this.Controls.Add(this.lectureSearch_textBox);
            this.Name = "ViewLectures_Client";
            this.Load += new System.EventHandler(this.ViewLectures_Client_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lectures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getallLecturesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_20DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Lectures;
        private System.Windows.Forms.TextBox lectureSearch_textBox;
        private System.Windows.Forms.Label label1;
        private SAD_20DataSet sAD_20DataSet;
        private System.Windows.Forms.BindingSource getallLecturesBindingSource;
        private SAD_20DataSetTableAdapters.Get_all_LecturesTableAdapter get_all_LecturesTableAdapter;
        private System.Windows.Forms.Button back_button1;
        private System.Windows.Forms.Button View_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectureTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatsLeftDataGridViewTextBoxColumn;
    }
}
