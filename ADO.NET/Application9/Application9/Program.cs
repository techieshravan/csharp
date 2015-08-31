using System;
using System.Data;
using System.Data.SqlClient;

namespace Application9
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString =
               @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;";
            const string queryString = "SELECT CustomerID, CompanyName, ContactName FROM dbo.Customers";

            DataSet customersDataSet = new DataSet();

           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(queryString, connection);
                adapter.Fill(customersDataSet);

                SqlCommandBuilder cmdb = new SqlCommandBuilder(adapter);

                DataRow row = customersDataSet.Tables[0].NewRow();
                row["CustomerID"] = "Dummy";
                row["CompanyName"] = "Dummy Company";
                row["ContactName"] = "Dummy Contact";
                customersDataSet.Tables[0].Rows.Add(row);

                DataSet changes = customersDataSet.GetChanges();
                if (changes != null)
                    adapter.Update(changes);
            }

            Console.ReadKey();
        }
    }
}
