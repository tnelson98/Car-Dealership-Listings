using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership
{
    public static class ListingsDB
    {
        public static List<Listing> GetDefaultListings()
        {
            List<Listing> listingList = new List<Listing>();
            SqlConnection connection =  GetConnection();
            string selectStatement =
                "SELECT ListingDate, Make, Model, Color, Age, Price " +
                "FROM Cars " +
                "ORDER BY ListingDate DESC";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while(reader.Read())
                {  
                    // Create a new listing and give it a Listing Date
                    Listing listing = new Listing();
                    listing.listDate = (DateTime)reader["ListingDate"];

                    // Create the correct make of car. No need to get make specific
                    // information until the make is filtered for
                    string carMake = reader["Make"].ToString();
                    switch (carMake)
                    {
                        case "Honda":
                            Honda honda = new Honda();
                            listing.car = honda;
                            break;
                        case "Toyota":
                            Toyota toyota = new Toyota();
                            listing.car = toyota;
                            break;
                        case "BMW":
                            BMW bMW = new BMW();
                            listing.car = bMW;
                            break;
                        case "Mercedes":
                            Mercedes mercedes = new Mercedes();
                            listing.car = mercedes;
                            break;
                    }

                    // Add the general Car properties
                    listing.car.Model = reader["Model"].ToString();
                    listing.car.Color = reader["Color"].ToString();
                    listing.car.Age = (int)reader["Age"];
                    listing.car.Price = (decimal)reader["Price"];

                    // Add the finished Listing to the List
                    listingList.Add(listing);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return listingList;
        }

        public static List<Listing> FilterByMake(string make)
        {
            List<Listing> filteredList = new List<Listing>();
            SqlConnection connection = GetConnection();
            string selectStatement =
                "SELECT ListingDate, Model, Color, Age, Price, ";
            switch (make)
            {
                case "Honda":
                    selectStatement += "BatteryCap ";
                    break;
                case "Toyota":
                    selectStatement += "Mileage ";
                    break;
                case "BMW":
                    selectStatement += "Engine ";
                    break;
                case "Mercedes":
                    selectStatement += "Horsepower ";
                    break;
            }
            selectStatement += "FROM Cars WHERE Make = '" + make + "'";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    // Create a new listing and give it a Listing Date
                    Listing listing = new Listing();
                    listing.listDate = (DateTime)reader["ListingDate"];
                    switch (make)
                    {
                        case "Honda":
                            Honda honda = new Honda();
                            honda.BatteryCap = (decimal)reader["BatteryCap"];
                            listing.car = honda;
                            break;
                        case "Toyota":
                            Toyota toyota = new Toyota();
                            toyota.Mileage = (int)reader["Mileage"];
                            listing.car = toyota;
                            break;
                        case "BMW":
                            BMW bMW = new BMW();
                            bMW.Engine = reader["Engine"].ToString();
                            listing.car = bMW;
                            break;
                        case "Mercedes":
                            Mercedes mercedes = new Mercedes();
                            mercedes.Horsepower = (int)reader["Horsepower"];
                            listing.car = mercedes;
                            break;
                    }

                    // Add the general Car properties
                    listing.car.Model = reader["Model"].ToString();
                    listing.car.Color = reader["Color"].ToString();
                    listing.car.Age = (int)reader["Age"];
                    listing.car.Price = (decimal)reader["Price"];

                    // Add the finished Listing to the List
                    filteredList.Add(listing);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return filteredList;
        }

        public static List<Listing> FilterByModel(string filterValue)
        {
            List<Listing> filteredList = new List<Listing>();
            SqlConnection connection = GetConnection();
            string selectStatement =
                "SELECT ListingDate, Make, Color, Age, Price " +
                "FROM CARS WHERE Model = '" + filterValue + "'";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Listing listing = new Listing();
                    string carMake = reader["Make"].ToString();
                    switch (carMake)
                    {
                        case "Honda":
                            listing.car = new Honda();
                            break;
                        case "Toyota":
                            listing.car = new Toyota();
                            break;
                        case "BMW":
                            listing.car = new BMW();
                            break;
                        case "Mercedes":
                            listing.car = new Mercedes();
                            break;
                    }
                    listing.listDate = (DateTime)reader["ListingDate"];
                    listing.car.Color = reader["Color"].ToString();
                    listing.car.Age = (int)reader["Age"];
                    listing.car.Price = (decimal)reader["Price"];
                    filteredList.Add(listing);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return filteredList;
        }

        public static List<Listing> FilterByColor(string filterValue)
        {
            List<Listing> filteredList = new List<Listing>();
            SqlConnection connection = GetConnection();
            string selectStatement =
                "SELECT ListingDate, Make, Model, Age, Price " +
                "FROM Cars WHERE Color = '" + filterValue + "'";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while(reader.Read())
                {
                    Listing listing = new Listing();
                    listing.listDate = (DateTime)reader["ListingDate"];
                    string carMake = reader["Make"].ToString();
                    switch (carMake)
                    {
                        case "Honda":
                            listing.car = new Honda();
                            break;
                        case "Toyota":
                            listing.car = new Toyota();
                            break;
                        case "BMW":
                            listing.car = new BMW();
                            break;
                        case "Mercedes":
                            listing.car = new Mercedes();
                            break;
                    }
                    listing.car.Model = reader["Model"].ToString();
                    listing.car.Age = (int)reader["Age"];
                    listing.car.Price = (decimal)reader["Price"];
                    filteredList.Add(listing);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return filteredList;
        }

        public static List<Listing> FilterByAgeOrPrice(string filterValue)
        {
            List<Listing > filteredList = new List<Listing>();
            SqlConnection connection = GetConnection();
            string selectStatement =
                "SELECT ListingDate, Make, Model, Color, Age, Price " +
                "FROM Cars WHERE ";
            // Age and price are set options that can be accounted for individually
            switch(filterValue)
            {
                case "Under 10":
                    selectStatement += "Age < 10";
                    break;
                case "10 to 25":
                    selectStatement += "Age >= 10 AND Age <= 25";
                    break;
                case "26 to 50":
                    selectStatement += "Age >= 26 AND Age <= 50";
                    break;
                case "Over 50":
                    selectStatement += "Age > 50";
                    break;
                case "Under $5000":
                    selectStatement += "Price < 5000";
                    break;
                case "$5000 to $10000":
                    selectStatement += "Price >= 5000 AND Price <= 10000";
                    break;
                case "Over $10000":
                    selectStatement += "Price > 10000";
                    break;

            }
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Listing listing = new Listing();
                    listing.listDate = (DateTime)reader["ListingDate"];
                    string carMake = reader["Make"].ToString();
                    switch (carMake)
                    {
                        case "Honda":
                            listing.car = new Honda();
                            break;
                        case "Toyota":
                            listing.car = new Toyota();
                            break;
                        case "BMW":
                            listing.car = new BMW();
                            break;
                        case "Mercedes":
                            listing.car = new Mercedes();
                            break;
                    }
                    listing.car.Model = reader["Model"].ToString();
                    listing.car.Color = reader["Color"].ToString();
                    listing.car.Age = (int)reader["Age"];
                    listing.car.Price = (decimal)reader["Price"];
                    filteredList.Add(listing);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return filteredList;
        }

        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=TylerPC\\SQLEXPRESS;Initial Catalog=CarDealership;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
