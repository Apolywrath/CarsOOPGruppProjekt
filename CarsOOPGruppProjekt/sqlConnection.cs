using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CarsOOPGruppProjekt
{
    internal class sqlConnection
    {

        public MySql.Data.MySqlClient.MySqlConnection _mysqlCon;

        public sqlConnection()
        {
            _mysqlCon = mysqlCon();
        }
        private MySql.Data.MySqlClient.MySqlConnection mysqlCon()
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=cars;uid=oopgrund;pwd=programmering;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                //MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Can not open connection ! ");
            }
            return cnn;
        }

        public List<Cars> getData()
        {
            _mysqlCon.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM CARS";
            cmd.Connection = _mysqlCon;
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Cars> test = new List<Cars>();
            while(reader.Read())
            {
                /* Cars volvo = new Cars(Int32.Parse(reader["cars_id"].ToString()), reader["cars_model"].ToString(), reader["manufacturers_manufacturers_name"].ToString(),
                     reader["cars_year"].ToString() , reader["retailers_retailers_name"].ToString(), Int32.Parse(reader["cars_price"].ToString())
                     );
                 test.Add(volvo); */

                test.Add(new Cars(
                    Convert.ToInt32(reader["cars_id"].ToString()),
                    reader["cars_model"].ToString(),
                    reader["manufacturers_manufacturers_name"].ToString(),
                    reader["retailers_retailers_name"].ToString(),
                    reader["cars_year"].ToString(),
                    Convert.ToInt32(reader["cars_price"])));

            }
            _mysqlCon.Close();
            return test;
        }

        public void updateData(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query,_mysqlCon);
            int rowAffected = cmd.ExecuteNonQuery();
        }



    }
}

