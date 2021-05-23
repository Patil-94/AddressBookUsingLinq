using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingLinq
{
   public  class AddressBookDataTable
    {
        //Creating DataTable for addressbook problem UC1
        DataTable dataTable = new DataTable();

        /// Create the Address Book table and add attributes.

        public DataTable createAddressBookTable()
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
           // displayAddressBook();
            return dataTable;
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
        public void addContact(Contact contact)
        {
            dataTable.Rows.Add(contact.FirstName, contact.LastName, contact.Address, contact.City,
            contact.State, contact.ZipCode, contact.PhoneNumber, contact.Email);
            Console.WriteLine("Added contact successfully");
        }

        public void editContact(DataTable dataTable)
        {
            var recordData = dataTable.AsEnumerable().Where(data => data.Field<string>("FirstName") == "Pratibha");
            foreach (var contact in recordData)
            {
                contact.SetField("LastName", "Karande");
                contact.SetField("Address", "Seawoods");
                Console.WriteLine("Updated contact");
                displayAddressBook();
            }
        }
        public void deleteParticularContact(Contact contact)
        {
            var recordData = dataTable.AsEnumerable().Where(data => data.Field<string>("FirstName") == contact.FirstName).First();
            if (recordData != null)
            {
                recordData.Delete();
                Console.WriteLine("Delete contact successfully");
                displayAddressBook();

            }
        }
        public void retrieveContactByState(Contact contact)
        {
            var records = from dataTable in dataTable.AsEnumerable().Where(dataTable => dataTable.Field<string>("State") == contact.State) select dataTable;
            foreach (var record in records.AsEnumerable())
            {
                Console.WriteLine("\nFirstName:-" + record.Field<string>("FirstName"));
                Console.WriteLine("LastName:-" + record.Field<string>("LastName"));
                Console.WriteLine("Address:-" + record.Field<string>("Address"));
                Console.WriteLine("City:-" + record.Field<string>("City"));
                Console.WriteLine("State:-" + record.Field<string>("State"));
                Console.WriteLine("ZipCode:-" + record.Field<int>("ZipCode"));
                Console.WriteLine("PhoneNumber:-" + record.Field<long>("PhoneNumber"));
                Console.WriteLine("Email:-" + record.Field<string>("Email"));
                displayAddressBook();

            }
        }

        public void retrieveContactByCity(Contact contact)
        {
            var records = from dataTable in dataTable.AsEnumerable().Where(dataTable => dataTable.Field<string>("City") == contact.City) select dataTable;
            foreach (var record in records.AsEnumerable())
            {
                Console.WriteLine("\nFirstName:-" + record.Field<string>("FirstName"));
                Console.WriteLine("LastName:-" + record.Field<string>("LastName"));
                Console.WriteLine("Address:-" + record.Field<string>("Address"));
                Console.WriteLine("City:-" + record.Field<string>("City"));
                Console.WriteLine("State:-" + record.Field<string>("State"));
                Console.WriteLine("ZipCode:-" + record.Field<int>("ZipCode"));
                Console.WriteLine("PhoneNumber:-" + record.Field<long>("PhoneNumber"));
                Console.WriteLine("Email:-" + record.Field<string>("Email"));
                displayAddressBook();

            }
        }
        public void sortContactByGivenCity(Contact contact)
        {
            var records = dataTable.AsEnumerable().Where(x => x.Field<string>("City") == contact.City).OrderBy(x => x.Field<string>("FirstName")).ThenBy(x => x.Field<string>("LastName"));
            foreach (var record in records)
            {
                Console.WriteLine("\nFirstName:-" + record.Field<string>("FirstName"));
                Console.WriteLine("LastName:-" + record.Field<string>("LastName"));
                Console.WriteLine("Address:-" + record.Field<string>("Address"));
                Console.WriteLine("City:-" + record.Field<string>("City"));
                Console.WriteLine("State:-" + record.Field<string>("State"));
                Console.WriteLine("ZipCode:-" + record.Field<int>("ZipCode"));
                Console.WriteLine("PhoneNumber:-" + record.Field<long>("PhoneNumber"));
                Console.WriteLine("Email:-" + record.Field<string>("Email"));
                displayAddressBook();

            }
        }
    }

}      
    

