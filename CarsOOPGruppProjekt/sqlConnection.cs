﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarsOOPGruppProjekt
{
    internal class sqlConnection
    {

        public MySql.Data.MySqlClient.MySqlConnection _mysqlCon;

        public sqlConnection()
        {
            //Kör functionen mysqlCon som sedan deklareras _mysqlCon
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
        public void updateSqlData(string query)
        {
            _mysqlCon.Open();
            MySqlCommand cmd = new MySqlCommand(query,_mysqlCon);
            int rowAffected = cmd.ExecuteNonQuery();

            _mysqlCon.Close();
        }

        public List<Cars> searchUpdate(string keyWord, string comboString)
        {
            //Om man raderar allt = att den kör vanliga getData();
            if(keyWord == "")
            {
                return getData();
            }
            // Ändrar om så vi får rätt colummnamn i databasen
            string columName = columNameFixer(comboString);
            // SQL Query
            string query = String.Format("SELECT * FROM CARS WHERE {0} LIKE @colValue", columName);
            // Skapar ett sql command som sedan ändrar om value på @colValue till det som är i variable. 
            MySqlCommand cmd = new MySqlCommand(query, _mysqlCon);
            cmd.Parameters.AddWithValue("@colValue", "%"+keyWord+"%");
            //Öppnar SQL connection
            _mysqlCon.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            //Skapar en temp List med classen Cars
            List<Cars> sqlCarList = new List<Cars>();

            // Läser varje rad tills det inte finns fler rader.
            while (reader.Read())
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
            _mysqlCon.Close();
            return sqlCarList;
        }

        public List<Manufacturer> GetManufacturers()
        {
            //Lägger till tillverkare i lista med tillverkare och returnerar listan
            List<Manufacturer> manufacturers = new List<Manufacturer>();
            _mysqlCon.Open();
            MySqlDataReader reader = new MySqlCommand("SELECT * FROM MANUFACTURERS", _mysqlCon).ExecuteReader();
            

            while (reader.Read())
            {
                manufacturers.Add(new Manufacturer(reader["Manufacturers_name"].ToString()));
            }

            return manufacturers;
        }

        public string columNameFixer(string columName)
        {
            // Simpel Switch case. Får den in "Model" så retunerar den cars_model etc.
            switch(columName)
                {
                case "Model":
                    return "cars_model";
                case "Year":
                    return "cars_Year";
                case "Price":
                    return "cars_Price";
            }

            return null;
        }



    }
}

