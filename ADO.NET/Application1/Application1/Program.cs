using System;
using System.Data.SqlClient;

namespace Application1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString =
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;";

            const string query = "SELECT TOP 10 EmployeeID ,FirstName ,LastName ,Title FROM Employees";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand
            {
                CommandText = query,
                Connection = connection
            };

           SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int employeeId = Convert.ToInt32(reader["EmployeeID"]);
                    string firstName = reader["FirstName"].ToString();
                    string lastName = reader["LastName"].ToString();
                    string title = reader["Title"].ToString();

                    var result = string.Format("EmployeeID {0}, FirstName {1}, LastName {2}, Title {3}", employeeId, firstName, lastName, title);

                    Console.WriteLine(result);
                }
            }
            connection.Close();
            Console.ReadKey();
        }
    }
}