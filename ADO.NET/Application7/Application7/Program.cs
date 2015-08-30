using System;
using System.Data;
using System.Data.SqlClient;

namespace Application7
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString =
               @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;";
            string queryString = "SELECT CustomerID, CompanyName FROM dbo.Customers";
            DataSet customers = new DataSet();


            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);
            adapter.Fill(customers, "Customers");

            DataRowCollection rows= customers.Tables["Customers"].Rows;

            foreach (DataRow row in rows)
            {
                Console.WriteLine(row["CustomerID"] +", "+row["CompanyName"]);
            }

            Console.ReadKey();
        }
    }
}
