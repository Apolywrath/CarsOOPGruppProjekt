using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsOOPGruppProjekt
{
    public partial class Form1 : Form
    {
        sqlConnection sqlConn = new sqlConnection();
        public Form1()
        {
            InitializeComponent();
            InitializeGUI();
        }
        private void InitializeGUI()
        {
            //Fyll dropdownlistor
            List<Manufacturer> manufacturers = sqlConn.GetManufacturers();
            foreach (var manufacturer in manufacturers)
            {
                cmbManufacurers.Items.Add(manufacturer.Name); 
            }

            List<Retailer> retailers = sqlConn.GetRetailers();
            foreach (var retailer in retailers)
            {
                cmbRetailers.Items.Add(retailer.Name);
            }
            UpdateGUI();
        }

        private void UpdateGUI()
        {
            //Sätt default värde i dropdownlistor
            cmbManufacurers.SelectedIndex = 0;
            cmbRetailers.SelectedIndex = 0;

            //Sätt defaultvärden för text
            txtModel.Text = "model";
            txtPrice.Text = "0";
            txtYear.Text = "xxxx";
            txtId.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string strModel = txtModel.Text;
            string strName = cmbManufacurers.Text;
            int intYear = Convert.ToInt32(txtYear.Text);
            string strRetail = cmbRetailers.Text;
            int intPrice = Convert.ToInt32(txtPrice.Text);

            string strSql = $"CALL addCar('{strModel}','{strName}','{intYear}','{strRetail}','{intPrice}')";

            sqlConn.AddCar(strSql);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            cmbManufacurers.SelectedItem = getSelectedDataGridViewCar().manufacturer;
        }

        // Get current selected Row Data from dataGridView1 for easier handling.
        private Cars getSelectedDataGridViewCar()
        {
            Cars car = new Cars(
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()),
                dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                dataGridView1.SelectedRows[0].Cells[4].Value.ToString(),
                dataGridView1.SelectedRows[0].Cells[3].Value.ToString(), 
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[5].Value.ToString()));
                return car;
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            /*
            // Get the collection of selected rows
            
            DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;

            // Loop through the colleciton of rows
            foreach (DataGridViewRow row in rows)
            
            {
                //Get the DataRowView object for the current row

                DataRowView rowView = row.DataBoundItem as DataRowView;

                // Delete the record corresponding to the current row

                rowView.Delete();
                    
            }
            */
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            List<Cars> cars = sqlConn.getData();
            dataGridView1.Rows.Clear();
            foreach (var car in cars)
            {
                //DataGridViewRow = en rad i datagridview t.ex. en rad i Excel.
                DataGridViewRow dgvr = new DataGridViewRow();
                //Fungerar lite som i ett excel dokument. Cell[0] = id som är gömd men kan användas av oss.
                dgvr.CreateCells(dataGridView1);
                dgvr.Cells[0].Value = car.id;
                dgvr.Cells[1].Value = car.manufacturer;
                dgvr.Cells[2].Value = car.Model;
                dgvr.Cells[3].Value = car.Year;
                dgvr.Cells[4].Value = car.Retailer;
                dgvr.Cells[5].Value = car.Price;
                dataGridView1.Rows.Add(dgvr);
            }
            string id = dataGridView1.Rows[0].Cells[0].Value.ToString();
        }

        private void searchtxtbox_TextChanged(object sender, EventArgs e)
        {
            List<Cars> cars = sqlConn.searchUpdate(searchtxtbox.Text,searchcmbBox.SelectedItem.ToString());
            dataGridView1.Rows.Clear();
            foreach (var car in cars)
            {
                //DataGridViewRow = en rad i datagridview t.ex. en rad i Excel.
                DataGridViewRow dgvr = new DataGridViewRow();
                //Fungerar lite som i ett excel dokument. Cell[0] = id som är gömd men kan användas av oss.
                dgvr.CreateCells(dataGridView1);
                dgvr.Cells[0].Value = car.Id;
                dgvr.Cells[1].Value = car.manufacturer;
                dgvr.Cells[2].Value = car.Model;
                dgvr.Cells[3].Value = car.Year;
                dgvr.Cells[4].Value = car.Retailer;
                dgvr.Cells[5].Value = car.Price;
                dataGridView1.Rows.Add(dgvr);
            }
        }

        private void searchcmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbManufacurers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Hämtar data från datagrid och representerar värden till text-&comboboxes
            //try/catch hanterar situationer då index är outofbounds
            try
            {
                Cars car = getSelectedDataGridViewCar();
                txtId.Text = car.Id.ToString();
                cmbManufacurers.Text = car.Manufacturer;
                txtModel.Text = car.Model;
                txtYear.Text = car.Year;
                cmbRetailers.Text = car.Retailer;
                txtPrice.Text = car.Price.ToString();
                btnCancel.Enabled = true;
                btnAdd.Enabled = false;
            }
            catch
            {
                //Inget händer!
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Uppdaterar GUI till default & sätter knappar
            UpdateGUI();
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}