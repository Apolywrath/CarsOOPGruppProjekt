namespace CarsOOPGruppProjekt
{
    partial class Form1
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
            this.grbList = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retailers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.grbEdit = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cmbRetailers = new System.Windows.Forms.ComboBox();
            this.cmbManufacurers = new System.Windows.Forms.ComboBox();
            this.searchtxtbox = new System.Windows.Forms.TextBox();
            this.searchcmbBox = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.dataGridView1);
            this.grbList.Location = new System.Drawing.Point(12, 270);
            this.grbList.Name = "grbList";
            this.grbList.Size = new System.Drawing.Size(629, 430);
            this.grbList.TabIndex = 0;
            this.grbList.TabStop = false;
            this.grbList.Text = "Car List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Manufacturer,
            this.Model,
            this.Year,
            this.Retailers,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(6, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(615, 292);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Manufacturer
            // 
            this.Manufacturer.HeaderText = "Manufacturer";
            this.Manufacturer.MinimumWidth = 6;
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // Retailers
            // 
            this.Retailers.HeaderText = "Retailers";
            this.Retailers.MinimumWidth = 6;
            this.Retailers.Name = "Retailers";
            this.Retailers.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(18, 235);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(87, 223);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(168, 223);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // grbEdit
            // 
            this.grbEdit.Controls.Add(this.btnCancel);
            this.grbEdit.Controls.Add(this.txtId);
            this.grbEdit.Controls.Add(this.txtPrice);
            this.grbEdit.Controls.Add(this.txtYear);
            this.grbEdit.Controls.Add(this.txtModel);
            this.grbEdit.Controls.Add(this.cmbRetailers);
            this.grbEdit.Controls.Add(this.cmbManufacurers);
            this.grbEdit.Controls.Add(this.btnRemove);
            this.grbEdit.Controls.Add(this.btnAdd);
            this.grbEdit.Controls.Add(this.btnEdit);
            this.grbEdit.Location = new System.Drawing.Point(391, 12);
            this.grbEdit.Name = "grbEdit";
            this.grbEdit.Size = new System.Drawing.Size(250, 252);
            this.grbEdit.TabIndex = 5;
            this.grbEdit.TabStop = false;
            this.grbEdit.Text = "Add/Edit/Remove";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(196, 150);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(46, 20);
            this.txtId.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(122, 125);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(122, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(122, 72);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(121, 20);
            this.txtYear.TabIndex = 6;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(122, 46);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(122, 20);
            this.txtModel.TabIndex = 6;
            // 
            // cmbRetailers
            // 
            this.cmbRetailers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRetailers.FormattingEnabled = true;
            this.cmbRetailers.Location = new System.Drawing.Point(122, 98);
            this.cmbRetailers.Name = "cmbRetailers";
            this.cmbRetailers.Size = new System.Drawing.Size(121, 21);
            this.cmbRetailers.TabIndex = 6;
            // 
            // cmbManufacurers
            // 
            this.cmbManufacurers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbManufacurers.FormattingEnabled = true;
            this.cmbManufacurers.Location = new System.Drawing.Point(122, 19);
            this.cmbManufacurers.Name = "cmbManufacurers";
            this.cmbManufacurers.Size = new System.Drawing.Size(121, 21);
            this.cmbManufacurers.TabIndex = 6;
            this.cmbManufacurers.SelectedIndexChanged += new System.EventHandler(this.cmbManufacurers_SelectedIndexChanged);
            // 
            // searchtxtbox
            // 
            this.searchtxtbox.Location = new System.Drawing.Point(211, 237);
            this.searchtxtbox.Name = "searchtxtbox";
            this.searchtxtbox.Size = new System.Drawing.Size(122, 20);
            this.searchtxtbox.TabIndex = 7;
            this.searchtxtbox.TextChanged += new System.EventHandler(this.searchtxtbox_TextChanged);
            // 
            // searchcmbBox
            // 
            this.searchcmbBox.DisplayMember = "Model";
            this.searchcmbBox.FormattingEnabled = true;
            this.searchcmbBox.Items.AddRange(new object[] {
            "Model",
            "Year",
            "Price"});
            this.searchcmbBox.Location = new System.Drawing.Point(114, 237);
            this.searchcmbBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchcmbBox.Name = "searchcmbBox";
            this.searchcmbBox.Size = new System.Drawing.Size(92, 21);
            this.searchcmbBox.TabIndex = 8;
            this.searchcmbBox.Text = "Model";
            this.searchcmbBox.SelectedIndexChanged += new System.EventHandler(this.searchcmbBox_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(87, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 682);
            this.Controls.Add(this.searchcmbBox);
            this.Controls.Add(this.searchtxtbox);
            this.Controls.Add(this.grbEdit);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.grbList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbEdit.ResumeLayout(false);
            this.grbEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbList;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox grbEdit;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cmbRetailers;
        private System.Windows.Forms.ComboBox cmbManufacurers;
        private System.Windows.Forms.TextBox searchtxtbox;
        private System.Windows.Forms.ComboBox searchcmbBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Retailers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCancel;
    }
}

