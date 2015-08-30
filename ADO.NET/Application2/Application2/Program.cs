using System;
using System.Data.SqlClient;

namespace Application2
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString =
               @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;";

            const string query = "INSERT INTO Employees (LastName ,FirstName ,Title) VALUES ('Kasagoni','Shravan','CTO')";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand
            {
                CommandText = query,
                Connection = connection
            };

            int rows = command.ExecuteNonQuery();
            
            Console.WriteLine("No of rows effected: " + rows);

            connection.Close();
            Console.ReadKey();
        }
    }
}
