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

            //Declarerar connectionString till null
            string connetionString = null;
            //Delcarerar en ny MySqlConnection som används för att ansluta till Mysql
            MySqlConnection cnn;
            //Själva connectionString Vilken server, Localhost = din egna dator. Database vad cars heter. uid = User_id. pwn = lösenord
            connetionString = "server=localhost;database=cars;uid=oopgrund;pwd=programmering;";
            //Försöker att connecta misslyckas det få ett felmeddelande
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                cnn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Can not open connection ! ");
            }
            //Retunerar denna MySqlConnection så det finns i en local variable.
            return cnn;
        }

        public List<Cars> getData()
        {
            // Använder den lokala MysqlConnection för att öppna en connection
            _mysqlCon.Open();
            //Skapar en MysqlDataReader  genom att skapa en ny mysqlcommand med query + connection
            MySqlDataReader reader = new MySqlCommand("SELECT * FROM CARS", _mysqlCon).ExecuteReader();
            //Skapar en temp List med classen Cars
            List<Cars> sqlCarList = new List<Cars>();

            // Läser varje rad tills det inte finns fler rader.
            while(reader.Read())
            {
                // Lägger till i våran Lista sqlCarList med hjälp av namnen va det heter i databasen
                sqlCarList.Add(new Cars(
                    Convert.ToInt32(reader["cars_id"].ToString()),
                    reader["cars_model"].ToString(),
                    reader["manufacturers_manufacturers_name"].ToString(),
                    reader["retailers_retailers_name"].ToString(),
                    reader["cars_year"].ToString(),
                    Convert.ToInt32(reader["cars_price"])));

            }
            //Stänger mysqlconnection
            _mysqlCon.Close();
            //Retunerar en lista med alla bilar ifrån databasen
            return sqlCarList;
        }

        // Har en input query som försöker köras där man bara får tillbaka en int rowAffected hur många rader som påverkas
        public void updateData(string query)
        {
            _mysqlCon.Open();
            MySqlCommand cmd = new MySqlCommand(query,_mysqlCon);
            int rowAffected = cmd.ExecuteNonQuery();
            _mysqlCon.Close();
        }



    }
}

