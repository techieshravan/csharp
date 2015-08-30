using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Application3
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString =
               @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;";

            Console.Write("Enter Title Of Courtesy: ");
            var titleOfCourtesy = Console.ReadLine();

            string query = "UPDATE Employees SET  TitleOfCourtesy = @courtesy WHERE EmployeeID = 11";
            
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand
            {
                CommandText = query,
                Connection = connection
            };

            command.Parameters.AddWithValue("@courtesy", titleOfCourtesy);

            int rows = command.ExecuteNonQuery();

            Console.WriteLine("No of rows effected: " + rows);

            connection.Close();
            Console.ReadKey();
        }
    }
}
