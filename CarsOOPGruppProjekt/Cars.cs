using System;


namespace CarsOOPGruppProjekt
{
    public class Cars
    {
        public int cars_id;
        public string cars_model;
        public string manufacturers_manufacturers_name;
        public string cars_year;
        public string retailers_retailers_name;
        public int cars_price;
        public Cars(int cars_id, string cars_model, string manufacturers_manufacturers_name, string cars_year
            , string retailers_retailers_name, int cars_price)
        {
            this.cars_id = cars_id;
            this.cars_model = cars_model;
            this.manufacturers_manufacturers_name = manufacturers_manufacturers_name;
            this.cars_year = cars_year;
            this.retailers_retailers_name = retailers_retailers_name;
            this.cars_price = cars_price;
        }
    }
}
