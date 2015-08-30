using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Application4
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString =
              @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;";

            string query = "DELETE FROM Employees  WHERE EmployeeID = 10";

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
