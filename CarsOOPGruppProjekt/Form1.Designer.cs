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
            this.lbList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.grbEdit = new System.Windows.Forms.GroupBox();
            this.cmbManufacurers = new System.Windows.Forms.ComboBox();
            this.cmbRetailers = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
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
            this.grbList.Location = new System.Drawing.Point(12, 270);
            this.grbList.Name = "grbList";
            this.grbList.Size = new System.Drawing.Size(629, 430);
            this.grbList.TabIndex = 0;
            this.grbList.TabStop = false;
            this.grbList.Text = "Car List";
            // 
            // lbList
            // 
            this.lbList.FormattingEnabled = true;
            this.lbList.Location = new System.Drawing.Point(6, 47);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(617, 381);
            this.lbList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manufacturer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Retailer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(592, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Price";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(18, 235);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
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
            this.grbEdit.Controls.Add(this.txtPrice);
            this.grbEdit.Controls.Add(this.Year);
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
            // cmbManufacurers
            // 
            this.cmbManufacurers.FormattingEnabled = true;
            this.cmbManufacurers.Location = new System.Drawing.Point(122, 19);
            this.cmbManufacurers.Name = "cmbManufacurers";
            this.cmbManufacurers.Size = new System.Drawing.Size(121, 21);
            this.cmbManufacurers.TabIndex = 6;
            // 
            // cmbRetailers
            // 
            this.cmbRetailers.FormattingEnabled = true;
            this.cmbRetailers.Location = new System.Drawing.Point(122, 98);
            this.cmbRetailers.Name = "cmbRetailers";
            this.cmbRetailers.Size = new System.Drawing.Size(121, 21);
            this.cmbRetailers.TabIndex = 6;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(122, 46);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(122, 20);
            this.txtModel.TabIndex = 6;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(122, 72);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(121, 20);
            this.Year.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(122, 125);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(122, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 712);
            this.Controls.Add(this.grbEdit);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.grbList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbList.ResumeLayout(false);
            this.grbList.PerformLayout();
            this.grbEdit.ResumeLayout(false);
            this.grbEdit.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

