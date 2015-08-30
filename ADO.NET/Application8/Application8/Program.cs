using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Application8
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString1 = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;";
            SqlConnection connection1 = new SqlConnection(connectionString1);
            SqlDataAdapter custAdapter = new SqlDataAdapter("SELECT * FROM Customers", connection1);

            const string connectionString2 = @"Provider = SQLNCLI11; Data Source = (localdb)\MSSQLLocalDB; Integrated Security = SSPI; Initial Catalog = Northwind";
            OleDbConnection connection2 = new OleDbConnection(connectionString2);
            OleDbDataAdapter ordAdapter = new OleDbDataAdapter("SELECT * FROM Orders", connection2);

            DataSet customerOrders = new DataSet();

            custAdapter.Fill(customerOrders, "Customers");
            ordAdapter.Fill(customerOrders, "Orders");

            DataRelation relation = customerOrders.Relations.Add("CustOrders",
              customerOrders.Tables["Customers"].Columns["CustomerID"],
              customerOrders.Tables["Orders"].Columns["CustomerID"]);

            foreach (DataRow pRow in customerOrders.Tables["Customers"].Rows)
            {
                Console.WriteLine(pRow["CustomerID"]);

                foreach (DataRow cRow in pRow.GetChildRows(relation))
                    Console.WriteLine("\t" + cRow["OrderID"]);
            }

            Console.ReadKey();
        }
    }
}
