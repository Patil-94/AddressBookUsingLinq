using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingLinq
{
    class AddressBookDataTable
    {
        //Creating DataTable for addressbook problem UC1
        DataTable dataTable = new DataTable();

        /// Create the Address Book table and add attributes.

        public void createAddressBookTable()
        {
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("ZipCode", typeof(int));
            dataTable.Columns.Add("PhoneNumber", typeof(long));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Rows.Add("Pratibha", "Mastud", "nerul", "navimumbai", "maharashtra", 400705, 9987932434, "Mastud@gmail.com");
            dataTable.Rows.Add("Pranli", "Chouhan", "ghansoli", "navimumbai", "maharashtra", 400701, 9987932434, "Chouhan@gmail.com");
            dataTable.Rows.Add("ritesh", "mahatre", "thane", "navimumbai", "maharashtra", 400703, 9987932434, "mahatre@gmail.com");
            dataTable.Rows.Add("sonali", "padme", "dombivli", "Mumbai", "maharashtra", 400710, 9987932434, "padme@gmail.com");
            dataTable.Rows.Add("rahul", "sable", "chembor", "Mumbai", "maharashtra", 400703, 9987932434, "sable@gmail.com");
            dataTable.Rows.Add("kartik", "bhoir", " koper khairne", "navimumbai", "maharashtra", 400701, 9987932434, "bhoir@gmail.com");
            dataTable.Rows.Add("priyanka", "parde", "vashi", "navimumbai", "maharashtra", 400701, 9987932434, "parde@gmail.com");
            displayAddressBook();
        }

        public void displayAddressBook()
        {
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine("\nFirstName:-" + row.Field<string>("FirstName"));
                Console.WriteLine("LastName:-" + row.Field<string>("LastName"));
                Console.WriteLine("Address:-" + row.Field<string>("Address"));
                Console.WriteLine("City:-" + row.Field<string>("City"));
                Console.WriteLine("State:-" + row.Field<string>("State"));
                Console.WriteLine("ZipCode:-" + row.Field<int>("ZipCode"));
                Console.WriteLine("PhoneNumber:-" + row.Field<long>("PhoneNumber"));
                Console.WriteLine("Email:-" + row.Field<string>("Email"));
            }
        }
    }

}      
    

