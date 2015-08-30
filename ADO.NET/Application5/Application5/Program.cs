using System;
using System.Data;

namespace Application5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DataTable table1 = new DataTable("Patients");

            table1.Columns.Add("Name");
            table1.Columns.Add("Id");

            table1.Rows.Add("Sam", 1);
            table1.Rows.Add("Mark", 2);

            DataTable table2 = new DataTable("Medications");

            table2.Columns.Add("Id");
            table2.Columns.Add("Medication");

            table2.Rows.Add(1, "atenolol");
            table2.Rows.Add(2, "amoxicillin");
            
            DataSet set = new DataSet("Hospital");
            set.Tables.Add(table1);
            set.Tables.Add(table2);

            Console.WriteLine(set.GetXml());

            Console.ReadKey();

        }
    }
}
