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
        public MySqlConnection MySqlConnection = new MySqlConnection();
        
        public static MySqlCommand SqlCommand;
        public static MySqlCommand MySqlCommand = new MySqlCommand();
        public DataTable SqlDataTable = new DataTable();
        public MySqlDataAdapter SqlDataAdapter = new MySqlDataAdapter();
        public MySqlDataReader SqlDataReader;
        public static readonly DataSet dataSet = new DataSet();
        public static readonly string server = "localhost";
        public static readonly string username = "root";
        public static readonly string password = "root";
        public static readonly string database = "client_schedule";
        public static readonly string sqlConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database;

        public void LoadData(string sqlQueryString, DataGridView dataGridView)
        {
            MySqlConnection.ConnectionString = sqlConnectionString;
            MySqlConnection.Open();
            MySqlCommand.Connection = MySqlConnection;
            MySqlCommand.CommandText = sqlQueryString;
            SqlDataReader = MySqlCommand.ExecuteReader();
            SqlDataTable.Load(SqlDataReader);
            SqlDataReader.Close();
            MySqlConnection.Close();
            dataGridView.DataSource = SqlDataTable;
        }
    }
}
