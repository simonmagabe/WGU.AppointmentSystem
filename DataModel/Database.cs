using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DataModel
{
    public class Database
    {
        //
        // add Database conncetions here
        //
        public MySqlConnection SqlConnection = new MySqlConnection(sqlConnectionString);
        public MySqlDataReader SqlDataReader;

        public static readonly string server = "localhost";
        public static readonly string username = "root";
        public static readonly string password = "root";
        public static readonly string database = "client_schedule";
        public static readonly string sqlConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database;

        public void LoadAllCustomersAppointmentsReport(string sqlQueryString, DataGridView dataGridView)
        {
            MySqlConnection sqlConnection = new MySqlConnection();
            MySqlCommand sqlCommand = new MySqlCommand();
            DataTable sqlDataTable = new DataTable();

            sqlConnection.ConnectionString = sqlConnectionString;
            sqlConnection.Open();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = sqlQueryString;
            SqlDataReader = sqlCommand.ExecuteReader();
            sqlDataTable.Load(SqlDataReader);
            SqlDataReader.Close();
            sqlConnection.Close();
            dataGridView.DataSource = sqlDataTable;
        }

        public void LoadConsultantReport(string sqlQueryString, DataGridView dataGridView)
        {
            MySqlConnection sqlConnection = new MySqlConnection();
            MySqlCommand sqlCommand = new MySqlCommand();
            DataTable sqlDataTable = new DataTable();

            sqlConnection.ConnectionString = sqlConnectionString;
            sqlConnection.Open();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = sqlQueryString;
            SqlDataReader = sqlCommand.ExecuteReader();
            sqlDataTable.Load(SqlDataReader);
            SqlDataReader.Close();
            sqlConnection.Close();
            dataGridView.DataSource = sqlDataTable;
        }

        public void LoadAppointmentsByMonthReport(string sqlQueryString, DataGridView dataGridView)
        {
            MySqlConnection sqlConnection = new MySqlConnection();
            MySqlCommand sqlCommand = new MySqlCommand();
            DataTable sqlDataTable = new DataTable();

            sqlConnection.ConnectionString = sqlConnectionString;
            sqlConnection.Open();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = sqlQueryString;
            SqlDataReader = sqlCommand.ExecuteReader();
            sqlDataTable.Load(SqlDataReader);
            SqlDataReader.Close();
            sqlConnection.Close();
            dataGridView.DataSource = sqlDataTable;
        }
    }
}
