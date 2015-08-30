using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Application9
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString =
               @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;";
            //string queryString = "SELECT CustomerID, CompanyName, ContactName FROM dbo.Customers";

            DataSet customersDataSet = new DataSet();
            
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = CreateCustomerAdapter(connection);
            adapter.Fill(customersDataSet, "Customers");

            adapter.InsertCommand.Parameters.Add("CompanyName", OleDbType.VarChar, 40, "CompanyName");
            adapter.InsertCommand.Parameters.Add("Phone", OleDbType.VarChar, 24, "Phone");

            DataRow row = customersDataSet.Tables["Customers"].NewRow();
            row["CompanyName"] = "XYZABC";
            row["ContactName"] = "Bond";
            customersDataSet.Tables["Customers"].Rows.Add(row);

            adapter.Update(customersDataSet, "Customers");

            Console.ReadKey();
        }

        public static SqlDataAdapter CreateCustomerAdapter(SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            // Create the SelectCommand.
            SqlCommand command = new SqlCommand("SELECT * FROM Customers", connection);

            //SqlCommand command = new SqlCommand("SELECT * FROM Customers WHERE Country = @Country AND City = @City", connection);
            // Add the parameters for the SelectCommand.
            //command.Parameters.Add("@Country", SqlDbType.NVarChar, 15);
            //command.Parameters.Add("@City", SqlDbType.NVarChar, 15);

            adapter.SelectCommand = command;

            // Create the InsertCommand.
            command = new SqlCommand("INSERT INTO Customers (CustomerID, CompanyName)  VALUES (@CustomerID, @CompanyName)", connection);

            // Add the parameters for the InsertCommand.
            command.Parameters.Add("@CustomerID", SqlDbType.NChar, 5, "CustomerID");
            command.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 40, "CompanyName");

            adapter.InsertCommand = command;

            // Create the UpdateCommand.
            command = new SqlCommand("UPDATE Customers SET CustomerID = @CustomerID, CompanyName = @CompanyName WHERE CustomerID = @oldCustomerID", connection);

            // Add the parameters for the UpdateCommand.
            command.Parameters.Add("@CustomerID", SqlDbType.NChar, 5, "CustomerID");
            command.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 40, "CompanyName");
            SqlParameter parameter = command.Parameters.Add("@oldCustomerID", SqlDbType.NChar, 5, "CustomerID");
            parameter.SourceVersion = DataRowVersion.Original;

            adapter.UpdateCommand = command;

            // Create the DeleteCommand.
            command = new SqlCommand("DELETE FROM Customers WHERE CustomerID = @CustomerID", connection);

            // Add the parameters for the DeleteCommand.
            parameter = command.Parameters.Add("@CustomerID", SqlDbType.NChar, 5, "CustomerID");
            parameter.SourceVersion = DataRowVersion.Original;

            adapter.DeleteCommand = command;

            return adapter;
        }
    }
}
