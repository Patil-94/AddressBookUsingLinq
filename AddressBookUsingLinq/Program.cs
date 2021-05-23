using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************Welcome To AddressBook Using Linq*************");
            AddressBookDataTable addressBookDataTable = new AddressBookDataTable();
            DataTable table = addressBookDataTable.createAddressBookTable();


            Contact contact = new Contact();
            contact.City = Console.ReadLine();
            addressBookDataTable.sortContactByGivenCity(contact);

            Console.Read();
        }
    }
}
