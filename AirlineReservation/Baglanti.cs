namespace AirlineReservation
{
    using System;
    using System.Data;
    using System.Data.SQLite;
    using System.IO;

    public class Baglanti
    {
        public static SQLiteConnection connection; 
        public Baglanti()
        {
            connection = new SQLiteConnection("Data Source=Db/airline.s3db");
            if(!File.Exists("Db/airline.s3db"))
            {
                SQLiteConnection.CreateFile("Db/airline.s3db");
                Console.WriteLine("Db file created");
            }
        }
        public static DataTable Select(string sql, SQLiteParameter[] parameters)
        {
            OpenConnection();
            SQLiteCommand cmd = new SQLiteCommand(sql, connection);
            if (parameters != null && parameters.Length > 0)
            {
                foreach (var param in parameters)
                {
                    cmd.Parameters.Add(param);
                }
            }
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);
            CloseConnection();
            return dt;
        }

        public static void OpenConnection()
        {
            if(connection.State != ConnectionState.Open)
                connection.Open();
        }

        public static void CloseConnection()
        {
            if(connection.State != ConnectionState.Closed)
                connection.Close();
        }

        public static int InsertOrUpdate(string sql, SQLiteParameter[] parameters)
        {
            OpenConnection();
            SQLiteCommand cmd = new SQLiteCommand(sql, connection);
            if (parameters != null && parameters.Length > 0)
            {
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.ParameterName, param.Value);
                }
            }
            int result = 0;
            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {

                throw;
            }
            CloseConnection();
            return result;
        }
    }
}
