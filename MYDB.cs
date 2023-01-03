namespace LibraryManagementSystem
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MYDB : DbContext
    {
        
        public MYDB()
            : base("name=MYDB")
        {
        }
        private MySqlConnection connection = new MySqlConnection(
            "server=localhost;port=3306;username=root;password=;database=library");
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
       public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }

        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }

   
}