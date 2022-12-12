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
    public partial class RandomDataForm : Form
    {
        public RandomDataForm()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if(txtboxCount.TextLength > 0)
            {
                int result = 0;
                Int32.TryParse(txtboxCount.Text, out result);
                List<Cars> cars = GeneratedData.generatedCars(result);
                sqlConnection sqlconn = new sqlConnection();
                foreach(Cars car in cars)
                {
                    string strSql = $"CALL addCar('{car.model}','{car.manufacturer}','{car.year}','{car.retailer}','{car.price}')";
                    sqlconn.AddCar(strSql);
                }
            }
            this.Hide();
        }
    }
}
