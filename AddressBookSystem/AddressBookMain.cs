using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
   public class AddressBookMain
    {
        CreateContacts Contacts = new CreateContacts();
        public void addcontact()
        {
            Console.WriteLine("Enter First Name");
            Contacts.FirstName = Console.ReadLine();
            Console.WriteLine("Enetr Last Name");
            Contacts.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            Contacts.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            Contacts.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            Contacts.State = Console.ReadLine();
            Console.WriteLine("Enter ZIP");
            Contacts.ZIP = Console.ReadLine();
            Console.WriteLine("Enetr Phone NUmber");
            Contacts.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email");
            Contacts.Email = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("First name: " + Contacts.FirstName + "\nLastname: " + Contacts.LastName + "\nAddress: " + Contacts.Address +
                "\nCity: " + Contacts.City + "\nState: " + Contacts.State + "\nZIP: " + Contacts.ZIP + "\nPhone Number: " + Contacts.PhoneNumber + "\nEmail: " + Contacts.Email);
        }
    }
}
