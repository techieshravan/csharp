using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Application6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable table1 = new DataTable("Patients");
            table1.Columns.Add("Name");
            table1.Columns.Add("Id");

            table1.Rows.Add("sam", 1);
            
            DataSet set = new DataSet("Hospital");
            set.Tables.Add(table1);
            set.Namespace = "y";
            set.Prefix = "x";
            
            Console.WriteLine(set.GetXml());

            Console.ReadKey();

            set.Tables.Add(GetPrescriptionTable());
          
            Console.WriteLine(set.GetXml());

            Console.ReadKey();
        }


        static DataTable GetPrescriptionTable()
        {
            DataTable table = new DataTable("Prescription");
            table.Columns.Add("Dosage", typeof(int));
            table.Columns.Add("Drug", typeof(string));
            table.Columns.Add("Patient", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));

            table.Rows.Add(25, "Indocin", "David", DateTime.Now);
            table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now);
            table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now);
            table.Rows.Add(21, "Combivent", "Janet", DateTime.Now);
            table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now);

            return table;
        }
    }
}
