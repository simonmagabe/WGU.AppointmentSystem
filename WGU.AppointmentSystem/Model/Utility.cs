using DataModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using WGU.AppointmentSystem.ViewModel;

namespace WGU.AppointmentSystem.Model
{
    public class Utility
    {
        public static Database database = new Database();
        public static BindingList<Customer> CustomersList = new BindingList<Customer>();
        public static Dictionary<int, Address> AddressesList = new Dictionary<int, Address>();
        public static Dictionary<int, City> CitiesList = new Dictionary<int, City>();
        public static Dictionary<int, Country> CountriesList = new Dictionary<int, Country>();
        public static BindingList<Appointment> AppointmentsList = new BindingList<Appointment>();

        public static DateTime currentDateTime = DateTime.Now;

        public static string allUsersQuery = "SELECT * FROM user";
        public static string allCustomersQuery = "SELECT * FROM customer";
        public static string allAddressesQuery = "SELECT * FROM address";
        public static string allCitiesQuery = "SELECT * FROM city";
        public static string allCountriesQuery = "SELECT * FROM country";

        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();

            QueryDataFromDatabase(allUsersQuery);

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
            QueryDataFromDatabase(allCustomersQuery);

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

                CustomersList.Add(new Customer(customerId, customerName, addressId, active, createdDate, createdBy, lastUpdated, lastUpdatedBy));
            }

            database.SqlConnection.Close();
            return CustomersList;
        }

        public static int AddCustomer(string name, int addressId, string user)
        {
            int active = 1;
            Customer newCustomer = new Customer(name, addressId, active, currentDateTime, user, currentDateTime, user);
            string createdDate = newCustomer.CREATEDDATE.ToUniversalTime().ToString("yy-MM-dd HH:MM:ss", DateTimeFormatInfo.InvariantInfo);
            string lastUpdated = newCustomer.LASTUPDATED.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);

            string queryString = $"INSERT INTO customer " +
                                        $"VALUES('{ newCustomer.CUSTOMERID }', " +
                                                $"'{ newCustomer.CUSTOMERNAME }', " +
                                                $"'{ newCustomer.ADDRESSID }', " +
                                                $"'{ newCustomer.ACTIVE }', " +
                                                $"'{ createdDate }', " +
                                                $"'{ newCustomer.CREATEDBY }', " +
                                                $"'{ lastUpdated }', " +
                                                $"'{ newCustomer.LASTUPDATEDBY }')";

            ExecuteNonQueryOnDatabase(queryString);
            CustomersList.Add(newCustomer);
            return newCustomer.CUSTOMERID;
        }

        public static void UpdateCustomer(Customer customerToUpdate, string customerName, string user)
        {
            string currentDate = currentDateTime.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            string queryString = $"UPDATE customer " +
                                 $"SET " +
                                        $"customerName = ' {customerName }', " +
                                        $"lastUpdate = '{ currentDate }', " +
                                        $"lastUpdateBy = '{ user }' " +
                                 $"WHERE customerId = { customerToUpdate.CUSTOMERID };";

            ExecuteNonQueryOnDatabase(queryString);
            Customer modifiedCustomer = new Customer(customerToUpdate.CUSTOMERID, customerName, customerToUpdate.ADDRESSID, customerToUpdate.ACTIVE, 
                customerToUpdate.CREATEDDATE, customerToUpdate.CREATEDBY, currentDateTime, user);
            int modifiedCustomerIndex = CustomersList.IndexOf(customerToUpdate);
            CustomersList.RemoveAt(modifiedCustomerIndex);
            CustomersList.Insert(modifiedCustomerIndex, modifiedCustomer);
        }

        public static void DeleteCustomer(Customer customer)
        {
            string queryString = $"DELETE FROM customer WHERE customerId = {customer.CUSTOMERID}";
            ExecuteNonQueryOnDatabase(queryString);
            CustomersList.Remove(customer);
        }

        public static Dictionary<int, Address> GetAddresses()
        {
            QueryDataFromDatabase(allAddressesQuery);

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

                AddressesList.Add(addressId, new Address(addressId, street1, street2, cityId, postalCode, phone, createdDate, createdBy, lastUpdated, lastUpdatedBy));
            }

            database.SqlConnection.Close();
            return AddressesList;
        }

        public static int AddAddress(string streetAddress1, string streetAddress2, int cityId, string zipCode, string phone, string username)
        {
            var newAddress = new Address(streetAddress1, streetAddress2, cityId, zipCode, phone, currentDateTime, username, currentDateTime, username);
            string createdDate = newAddress.CREATEDDATE.ToUniversalTime().ToString("yy-MM-dd HH:MM:ss", DateTimeFormatInfo.InvariantInfo);
            string lastUpdated = newAddress.LASTUPDATED.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            string queryString = $"INSERT INTO address " +
                                        $"VALUES('{ newAddress.ADDRESSID }', " +
                                                $"'{ newAddress.STREET1 }', " +
                                                $"'{ newAddress.STREET2 }', " +
                                                $"'{ newAddress.CITYID }', " +
                                                $"'{ newAddress.ZIPCODE }', " +
                                                $"'{ newAddress.PHONE }', " +
                                                $"'{ createdDate }', " +
                                                $"'{ newAddress.CREATEDBY }', " +
                                                $"'{ lastUpdated }', " +
                                                $"'{ newAddress.LASTUPDATEDBY }'" +
                                              $")";

            ExecuteNonQueryOnDatabase(queryString);
            AddressesList.Add(newAddress.ADDRESSID, newAddress);
            return newAddress.ADDRESSID;
        }

        public static void UpdateAddress(Address addressToUpdate, string streetAddress1, string streetAddress2, int cityId, string zipCode, string phone, string user)
        {
            string currentDate = currentDateTime.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            string queryString = $"UPDATE address " +
                                 $"SET " +
                                        $"address = '{ streetAddress1 }', " +
                                        $"address2 = '{ streetAddress2 }', " +
                                        $"cityId = { cityId }, " +
                                        $"postalCode = '{ zipCode }', " +
                                        $"phone = '{ phone }', " +
                                        $"lastUpdate = '{ currentDate }', " +
                                        $"lastUpdateBy = '{ user }' " +
                                 $"WHERE addressId = { addressToUpdate.ADDRESSID };";

            ExecuteNonQueryOnDatabase(queryString);
            AddressesList[addressToUpdate.ADDRESSID] = new Address(addressToUpdate.ADDRESSID, streetAddress1, streetAddress2, cityId, zipCode, phone, 
                addressToUpdate.CREATEDDATE, addressToUpdate.CREATEDBY, currentDateTime, user);
        }

        public static void DeleteAddress(int addressId)
        {
            string queryString = $"DELETE FROM  address WHERE addressId = {addressId}";
            ExecuteNonQueryOnDatabase(queryString);
            AddressesList.Remove(addressId);
        }

        public static Dictionary<int, City> GetCities()
        {
            QueryDataFromDatabase(allCitiesQuery);

            while (database.SqlDataReader.Read())
            {
                int cityId = int.Parse(database.SqlDataReader[0].ToString().Trim());
                string cityName = database.SqlDataReader[1].ToString().Trim();
                int countryId = int.Parse(database.SqlDataReader[2].ToString().Trim());
                DateTime createdDate = DateTime.Parse(database.SqlDataReader[3].ToString().Trim());
                string createdBy = database.SqlDataReader[4].ToString().Trim();
                DateTime lastUpdated = DateTime.Parse(database.SqlDataReader[5].ToString().Trim());
                string lastUpdatedBy = database.SqlDataReader[6].ToString().Trim();

                CitiesList.Add(cityId, new City(cityId, cityName, countryId, createdDate, createdBy, lastUpdated, lastUpdatedBy));
            }

            database.SqlConnection.Close();
            return CitiesList;
        }

        public static Dictionary<int, Country> GetCountries()
        {
            QueryDataFromDatabase(allCountriesQuery);

            while (database.SqlDataReader.Read())
            {
                int countryId = int.Parse(database.SqlDataReader[0].ToString().Trim());
                string countryName = database.SqlDataReader[1].ToString().Trim();
                DateTime createdDate = DateTime.Parse(database.SqlDataReader[2].ToString().Trim());
                string createdBy = database.SqlDataReader[3].ToString().Trim();
                DateTime lastUpdated = DateTime.Parse(database.SqlDataReader[4].ToString().Trim());
                string lastUpdatedBy = database.SqlDataReader[5].ToString().Trim();

                CountriesList.Add(countryId, new Country(countryId, countryName, createdDate, createdBy, lastUpdated, lastUpdatedBy));
            }

            database.SqlConnection.Close();
            return CountriesList;
        }

        public static BindingList<Appointment> GetAppointments()
        {
            string allAppointmentsQuery = $"SELECT * FROM appointment WHERE userId={FormHomePage.LOGGGED_IN_USER.USERID}";
            QueryDataFromDatabase(allAppointmentsQuery);

            while (database.SqlDataReader.Read())
            {
                try
                {
                    int appointmentId = int.Parse(database.SqlDataReader[0].ToString().Trim());
                    int customerId = int.Parse(database.SqlDataReader[1].ToString().Trim());
                    int userId = int.Parse(database.SqlDataReader[2].ToString().Trim());
                    string type = database.SqlDataReader[7].ToString().Trim();
                    DateTime startDate = DateTime.Parse(database.SqlDataReader[9].ToString().Trim()).ToLocalTime();
                    DateTime endDate = DateTime.Parse(database.SqlDataReader[10].ToString().Trim()).ToLocalTime();
                    DateTime createdDate = DateTime.Parse(database.SqlDataReader[11].ToString().Trim());
                    string createdBy = database.SqlDataReader[12].ToString().Trim();
                    DateTime lastUpdated = DateTime.Parse(database.SqlDataReader[13].ToString().Trim());
                    string lastUpdatedBy = database.SqlDataReader[14].ToString().Trim();

                    AppointmentsList.Add(new Appointment(appointmentId, customerId, userId, type, startDate, endDate, createdDate, createdBy, lastUpdated, lastUpdatedBy));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    Console.WriteLine(ex.Source);
                }
            }

            database.SqlConnection.Close();
            return AppointmentsList;
        }

        internal static void AddAppointment(int customerId, string appointmentType, DateTime startDate, DateTime endDate)
        {
            User user = FormHomePage.LOGGGED_IN_USER;
            Appointment newAppointment = new Appointment(customerId, user.USERID, appointmentType, startDate, endDate, 
                currentDateTime, user.USERNAME, currentDateTime, user.USERNAME);

            string startDateTime = newAppointment.STARTDATE.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            string endDateTime = newAppointment.ENDDATE.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            string createdDate = newAppointment.CREATEDDATE.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            string lastUpdated = newAppointment.LASTUPDATED.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);

            string queryString = $"INSERT INTO appointment " +
                                 $"VALUES ({ newAppointment.APPOINTMENTID }, " +
                                         $"{ newAppointment.CUSTOMERID }, " +
                                         $"{ newAppointment.USERID }, " +
                                         $" '{ null }', " +
                                         $" '{ null }', " +
                                         $" '{ null }', " +
                                         $" '{ null }', " +
                                         $"'{ newAppointment.TYPE }', " +
                                         $" '{ null }', " +
                                         $"'{ startDateTime }', " +
                                         $"'{ endDateTime }', " +
                                         $"'{ createdDate }', " +
                                         $"'{ newAppointment.CREATEDBY }', " +
                                         $"'{ lastUpdated }', " +
                                         $"'{ newAppointment.LASTUPDATEDBY }'" +
                                 $");";

            ExecuteNonQueryOnDatabase(queryString);
            Utility.AppointmentsList.Add(newAppointment);
        }

        internal static void UpdateAppointment(Appointment appointment, int customerId, string appointmentType, DateTime startDateTime, DateTime endDateTime)
        {
            string currentTime = currentDateTime.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            User user = FormHomePage.LOGGGED_IN_USER;
            string start = startDateTime.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);

            string queryString = $"UPDATE appointment " +
                                 $"SET " +
                                        $"customerId = {customerId}, " +
                                        $"userId = {user.USERID}, " +
                                        $"type = '{appointmentType}', " +
                                        $"start = '{start}', " +
                                        $"lastUpdate = '{currentTime}', " +
                                        $"lastUpdateBy = '{user.USERNAME}' " +
                                 $"WHERE " +
                                        $"appointmentId = {appointment.APPOINTMENTID};";

            ExecuteNonQueryOnDatabase(queryString);

            Appointment modifiedAppointment = new Appointment(appointment.APPOINTMENTID, customerId, user.USERID, appointmentType, 
                startDateTime, endDateTime, appointment.CREATEDDATE, appointment.CREATEDBY, currentDateTime, user.USERNAME);
            int indexOfModifiedAppointment = AppointmentsList.IndexOf(appointment);
            AppointmentsList.RemoveAt(indexOfModifiedAppointment);
            AppointmentsList.Insert(indexOfModifiedAppointment, modifiedAppointment);
        }

        public static void DeleteAppointment(Appointment appointment)
        {
            string queryString = $"DELETE FROM appointment WHERE appointmentId = {appointment.APPOINTMENTID};";
            ExecuteNonQueryOnDatabase(queryString);
            AppointmentsList.Remove(appointment);
        }




        // Helper methods
        private static void QueryDataFromDatabase(string queryString)
        {
            database.SqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(queryString, database.SqlConnection);
            database.SqlDataReader = mySqlCommand.ExecuteReader();
        }

        private static void ExecuteNonQueryOnDatabase(string queryString)
        {
            database.SqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(queryString, database.SqlConnection);
            mySqlCommand.ExecuteNonQuery();
            database.SqlConnection.Close();
        }
    }
}
