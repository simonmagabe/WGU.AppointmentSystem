using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DataModel
{
    public class Database
    {
        //
        // add Database conncetions here
        //
        public MySqlConnection SqlConnection = new MySqlConnection(sqlConnectionString);
        
        public static MySqlCommand SqlCommand;
        public DataTable SqlDataTable = new DataTable();
        public string SqlQuery;
        public MySqlDataAdapter SqlDataAdapter = new MySqlDataAdapter();
        public MySqlDataReader SqlDataReader;
        public static readonly DataSet dataSet = new DataSet();
        public static readonly string server = "localhost";
        public static readonly string username = "root";
        public static readonly string password = "root";
        public static readonly string database = "client_schedule";
        public static readonly string sqlConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database;

        public void LoadData(string sqlQeuryCommandText)
        {
            SqlConnection.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database;

            SqlConnection.Open();
            SqlCommand.Connection = SqlConnection;
            SqlCommand.CommandText = sqlQeuryCommandText;
            SqlDataReader = SqlCommand.ExecuteReader();
            SqlDataTable.Load(SqlDataReader);
            SqlDataReader.Close();
            SqlConnection.Close();
        }
    }
}
