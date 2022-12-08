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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbList = new System.Windows.Forms.ListBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.grbEdit = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cmbRetailers = new System.Windows.Forms.ComboBox();
            this.cmbManufacurers = new System.Windows.Forms.ComboBox();
            this.searchtxtbox = new System.Windows.Forms.TextBox();
            this.searchcmbBox = new System.Windows.Forms.ComboBox();
            this.grbList.SuspendLayout();
            this.grbEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.label5);
            this.grbList.Controls.Add(this.label4);
            this.grbList.Controls.Add(this.label3);
            this.grbList.Controls.Add(this.label2);
            this.grbList.Controls.Add(this.label1);
            this.grbList.Controls.Add(this.lbList);
            this.grbList.Location = new System.Drawing.Point(16, 332);
            this.grbList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbList.Name = "grbList";
            this.grbList.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbList.Size = new System.Drawing.Size(839, 529);
            this.grbList.TabIndex = 0;
            this.grbList.TabStop = false;
            this.grbList.Text = "Car List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(789, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Price";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Retailer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manufacturer";
            // 
            // lbList
            // 
            this.lbList.FormattingEnabled = true;
            this.lbList.ItemHeight = 16;
            this.lbList.Location = new System.Drawing.Point(8, 58);
            this.lbList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(821, 468);
            this.lbList.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(24, 289);
            this.btnView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 28);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(8, 274);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(116, 274);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 28);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(224, 274);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 28);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // grbEdit
            // 
            this.grbEdit.Controls.Add(this.txtPrice);
            this.grbEdit.Controls.Add(this.Year);
            this.grbEdit.Controls.Add(this.txtModel);
            this.grbEdit.Controls.Add(this.cmbRetailers);
            this.grbEdit.Controls.Add(this.cmbManufacurers);
            this.grbEdit.Controls.Add(this.btnRemove);
            this.grbEdit.Controls.Add(this.btnAdd);
            this.grbEdit.Controls.Add(this.btnEdit);
            this.grbEdit.Location = new System.Drawing.Point(521, 15);
            this.grbEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbEdit.Name = "grbEdit";
            this.grbEdit.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbEdit.Size = new System.Drawing.Size(333, 310);
            this.grbEdit.TabIndex = 5;
            this.grbEdit.TabStop = false;
            this.grbEdit.Text = "Add/Edit/Remove";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(163, 154);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(161, 22);
            this.txtPrice.TabIndex = 6;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(163, 89);
            this.Year.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(160, 22);
            this.Year.TabIndex = 6;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(163, 57);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(161, 22);
            this.txtModel.TabIndex = 6;
            // 
            // cmbRetailers
            // 
            this.cmbRetailers.FormattingEnabled = true;
            this.cmbRetailers.Location = new System.Drawing.Point(163, 121);
            this.cmbRetailers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRetailers.Name = "cmbRetailers";
            this.cmbRetailers.Size = new System.Drawing.Size(160, 24);
            this.cmbRetailers.TabIndex = 6;
            // 
            // cmbManufacurers
            // 
            this.cmbManufacurers.FormattingEnabled = true;
            this.cmbManufacurers.Location = new System.Drawing.Point(163, 23);
            this.cmbManufacurers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbManufacurers.Name = "cmbManufacurers";
            this.cmbManufacurers.Size = new System.Drawing.Size(160, 24);
            this.cmbManufacurers.TabIndex = 6;
            // 
            // searchtxtbox
            // 
            this.searchtxtbox.Location = new System.Drawing.Point(280, 295);
            this.searchtxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.searchtxtbox.Name = "searchtxtbox";
            this.searchtxtbox.Size = new System.Drawing.Size(161, 22);
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
            this.searchcmbBox.Location = new System.Drawing.Point(152, 292);
            this.searchcmbBox.Name = "searchcmbBox";
            this.searchcmbBox.Size = new System.Drawing.Size(121, 24);
            this.searchcmbBox.TabIndex = 8;
            this.searchcmbBox.Text = "Model";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 876);
            this.Controls.Add(this.searchcmbBox);
            this.Controls.Add(this.searchtxtbox);
            this.Controls.Add(this.grbEdit);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.grbList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbList.ResumeLayout(false);
            this.grbList.PerformLayout();
            this.grbEdit.ResumeLayout(false);
            this.grbEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox grbEdit;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cmbRetailers;
        private System.Windows.Forms.ComboBox cmbManufacurers;
        private System.Windows.Forms.TextBox searchtxtbox;
        private System.Windows.Forms.ComboBox searchcmbBox;
    }
}

