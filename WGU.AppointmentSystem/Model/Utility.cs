using DataModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WGU.AppointmentSystem.ViewModel;

namespace WGU.AppointmentSystem.Model
{
    public class Utility
    {
        public static Database database = new Database();
        public static BindingList<Customer> customers = new BindingList<Customer>();
        public static Dictionary<int, Address> addresses = new Dictionary<int, Address>();
        public static Dictionary<int, City> cities = new Dictionary<int, City>();
        public static Dictionary<int, Country> countries = new Dictionary<int, Country>();
        public static BindingList<Appointment> appointments = new BindingList<Appointment>();

        public static string allUsersQuery = "SELECT * FROM user";
        public static string allCustomersQuery = "SELECT * FROM customer";
        public static string allAddressesQuery = "SELECT * FROM address";
        public static string allCitiesQuery = "SELECT * FROM city";
        public static string allCountriesQuery = "SELECT * FROM country";

        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();

            QueryDatabase(allUsersQuery);

            while (database.SqlDataReader.Read())
            {
                int userId = int.Parse(database.SqlDataReader[0].ToString().Trim());
                string username = database.SqlDataReader[1].ToString().Trim();
                string password = database.SqlDataReader[2].ToString().Trim();
                int active = int.Parse(database.SqlDataReader[3].ToString().Trim());
                DateTime createdDate = DateTime.Parse(database.SqlDataReader[4].ToString().Trim());
                string createdBy = database.SqlDataReader[5].ToString().Trim();
                DateTime lastUpdated = DateTime.Parse(database.SqlDataReader[6].ToString().Trim());
                string lastUpdatedBy = database.SqlDataReader[7].ToString().Trim();

                users.Add(new User(userId, username, password, active, createdDate, createdBy, lastUpdated, lastUpdatedBy));
            }

            database.SqlConnection.Close();
            return users;
        }

        public static BindingList<Customer> GetCustomers()
        {
            QueryDatabase(allCustomersQuery);

            while (database.SqlDataReader.Read())
            {
                int customerId = int.Parse(database.SqlDataReader[0].ToString().Trim());
                string customerName = database.SqlDataReader[1].ToString().Trim();
                int addressId = int.Parse(database.SqlDataReader[2].ToString().Trim());
                int active = Convert.ToInt32(database.SqlDataReader[3]);
                DateTime createdDate = DateTime.Parse(database.SqlDataReader[4].ToString().Trim());
                string createdBy = database.SqlDataReader[5].ToString().Trim();
                DateTime lastUpdated = DateTime.Parse(database.SqlDataReader[6].ToString().Trim());
                string lastUpdatedBy = database.SqlDataReader[7].ToString().Trim();

                customers.Add(new Customer(customerId, customerName, addressId, active, createdDate, createdBy, lastUpdated, lastUpdatedBy));
            }

            database.SqlConnection.Close();
            return customers;
        }

        public static Dictionary<int, Address> GetAddresses()
        {
            QueryDatabase(allAddressesQuery);

            while (database.SqlDataReader.Read())
            {
                int addressId = int.Parse(database.SqlDataReader[0].ToString().Trim());
                string street1 = database.SqlDataReader[1].ToString().Trim();
                string street2 = database.SqlDataReader[2].ToString().Trim();
                int cityId = int.Parse(database.SqlDataReader[3].ToString().Trim());
                string postalCode = database.SqlDataReader[4].ToString().Trim();
                string phone = database.SqlDataReader[5].ToString().Trim();
                DateTime createdDate = DateTime.Parse(database.SqlDataReader[6].ToString().Trim());
                string createdBy = database.SqlDataReader[7].ToString().Trim();
                DateTime lastUpdated = DateTime.Parse(database.SqlDataReader[8].ToString().Trim());
                string lastUpdatedBy = database.SqlDataReader[9].ToString().Trim();

                addresses.Add(addressId, new Address(addressId, street1, street2, cityId, postalCode, phone, createdDate, createdBy, lastUpdated, lastUpdatedBy));
            }

            database.SqlConnection.Close();
            return addresses;
        }

        public static Dictionary<int, City> GetCities()
        {
            QueryDatabase(allCitiesQuery);

            while (database.SqlDataReader.Read())
            {
                int cityId = int.Parse(database.SqlDataReader[0].ToString().Trim());
                string cityName = database.SqlDataReader[1].ToString().Trim();
                int countryId = int.Parse(database.SqlDataReader[2].ToString().Trim());
                DateTime createdDate = DateTime.Parse(database.SqlDataReader[3].ToString().Trim());
                string createdBy = database.SqlDataReader[4].ToString().Trim();
                DateTime lastUpdated = DateTime.Parse(database.SqlDataReader[5].ToString().Trim());
                string lastUpdatedBy = database.SqlDataReader[6].ToString().Trim();

                cities.Add(cityId, new City(cityId, cityName, countryId, createdDate, createdBy, lastUpdated, lastUpdatedBy));
            }

            database.SqlConnection.Close();
            return cities;
        }

        public static Dictionary<int, Country> GetCountries()
        {
            QueryDatabase(allCountriesQuery);

            while (database.SqlDataReader.Read())
            {
                int countryId = int.Parse(database.SqlDataReader[0].ToString().Trim());
                string countryName = database.SqlDataReader[1].ToString().Trim();
                DateTime createdDate = DateTime.Parse(database.SqlDataReader[2].ToString().Trim());
                string createdBy = database.SqlDataReader[3].ToString().Trim();
                DateTime lastUpdated = DateTime.Parse(database.SqlDataReader[4].ToString().Trim());
                string lastUpdatedBy = database.SqlDataReader[5].ToString().Trim();

                countries.Add(countryId, new Country(countryId, countryName, createdDate, createdBy, lastUpdated, lastUpdatedBy));
            }

            database.SqlConnection.Close();
            return countries;
        }

        public static BindingList<Appointment> GetAppointments()
        {
            string allAppointmentsQuery = $"SELECT * FROM appointment WHERE userId={FormHomePage.LOGGGED_IN_USER.USERID}";
            QueryDatabase(allAppointmentsQuery);

            while (database.SqlDataReader.Read())
            {
                try
                {
                    int appointmentId = int.Parse(database.SqlDataReader[0].ToString().Trim());
                    int customerId = (int)database.SqlDataReader[1];
                    int userId = int.Parse(database.SqlDataReader[2].ToString().Trim());
                    string type = database.SqlDataReader[7].ToString().Trim();
                    DateTime startDate = DateTime.Parse(database.SqlDataReader[9].ToString().Trim()).ToLocalTime();
                    DateTime endDate = DateTime.Parse(database.SqlDataReader[10].ToString().Trim()).ToLocalTime();
                    DateTime createdDate = DateTime.Parse(database.SqlDataReader[11].ToString().Trim());
                    string createdBy = database.SqlDataReader[12].ToString().Trim();
                    DateTime lastUpdated = DateTime.Parse(database.SqlDataReader[13].ToString().Trim());
                    string lastUpdatedBy = database.SqlDataReader[14].ToString().Trim();

                    appointments.Add(new Appointment(appointmentId, customerId, userId, type, startDate, endDate, createdDate, createdBy, lastUpdated, lastUpdatedBy));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    Console.WriteLine(ex.Source);
                }
            }

            database.SqlConnection.Close();
            return appointments;
        }





        // Helper methods
        private static void QueryDatabase(string queryString)
        {
            database.SqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(queryString, database.SqlConnection);
            database.SqlDataReader = mySqlCommand.ExecuteReader();
        }
    }
}
