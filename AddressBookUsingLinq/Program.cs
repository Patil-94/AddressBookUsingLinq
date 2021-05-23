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
            Console.WriteLine("Enter the City  ");
            contact.City = Console.ReadLine();
            addressBookDataTable.retrieveContactByCity(contact);

            //Console.WriteLine("Enter the first name = ");
            //contact.FirstName = Console.ReadLine();
            //addressBookDataTable.deleteParticularContact(contact);

            Console.Read();
        }
    }
}
