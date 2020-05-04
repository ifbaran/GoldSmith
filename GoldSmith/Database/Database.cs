using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSmith.Database
{
    public class Database
    {
        private string ConnectionString = @"Data Source=C:\YEREL DİSK D\GoldSmith\GoldSmith\Database\GOLDSMITH.db";
        SQLiteConnection con;

        public Database()
        {
            OpenConnection();
        }

        private void OpenConnection()
        {
            con = new SQLiteConnection(ConnectionString);
            con.Open();
        }


        private void CloseConnection()
        {
            con.Close();
        }

        public int ExecuteNonQuery(string query)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            return cmd.ExecuteNonQuery();
        }

        public int ExecuteQueries(string Query_)
        {
            SQLiteCommand cmd = new SQLiteCommand(Query_, con);
            return cmd.ExecuteNonQuery();

        }


        public SQLiteDataReader DataReader(string Query_)
        {
            SQLiteCommand cmd = new SQLiteCommand(Query_, con);
            SQLiteDataReader dr = cmd.ExecuteReader();

            CloseConnection();

            return dr;
        }


        public DataTable ShowDataInGridView(string Query_)
        {
            SQLiteDataAdapter dr = new SQLiteDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            
            DataTable dataum = ds.Tables[0];
            
            CloseConnection();

            return dataum;
        }
    }
}
