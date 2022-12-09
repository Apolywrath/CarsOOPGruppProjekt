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

            //Sätt default värde i dropdownlistor
            cmbManufacurers.SelectedIndex = 0;
            cmbRetailers.SelectedIndex = 0;

            //Sätt defaultvärden för text
            txtModel.Text = "model";
            txtPrice.Text = "0";
            txtYear.Text = "xxxx";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            List<Cars> cars = sqlConn.getData();
            foreach (var car in cars)
            {
                lbList.Items.Add(
                    car.Manufacturer + " " +
                    car.Model + " " +
                    car.Year + " " +
                    car.Retailer + " " +
                    car.Price + ":-");
            }
        }

        private void searchtxtbox_TextChanged(object sender, EventArgs e)
        {
            List<Cars> cars = sqlConn.searchUpdate(searchtxtbox.Text,searchcmbBox.SelectedItem.ToString());

            lbList.Items.Clear();
            foreach (var car in cars)
            {
                lbList.Items.Add(
                    car.Manufacturer + " " +
                    car.Model + " " +
                    car.Year + " " +
                    car.Retailer + " " +
                    car.Price + ":-");
            }
        }

        private void searchcmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbManufacurers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
