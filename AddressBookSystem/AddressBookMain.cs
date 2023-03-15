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
        public void Edit()
        {
            Console.WriteLine("Select Option to edit Contct details \n 1. Edit First Name \n 2.Edit Last Name \n 3.Edit Address \n 4.Edit City \n 5.Edit State \n 6. Zip \n 7. Edit Phone Number \n 8. Edit Email ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter First Name");
                    Contacts.FirstName = Console.ReadLine();
                    Display();
                    break;
                case 2:
                    Console.WriteLine("Enter last Name");
                    Contacts.LastName = Console.ReadLine();
                    Display();
                    break;
                case 3:
                    Console.WriteLine("Enter Address");
                    Contacts.Address = Console.ReadLine();
                    Display();
                    break;
                case 4:
                    Console.WriteLine("Enter City");
                    Contacts.City = Console.ReadLine();
                    Display();
                    break;
                case 5:
                    Console.WriteLine("Enter State");
                    Contacts.State = Console.ReadLine();
                    Display();
                    break;
                case 6:
                    Console.WriteLine("Enter Zip Code");
                    Contacts.ZIP = Console.ReadLine();
                    Display();
                    break;
                case 7:
                    Console.WriteLine("Enter Phone Number");
                    Contacts.PhoneNumber = Console.ReadLine();
                    Display();
                    break;
                case 8:
                    Console.WriteLine("Enter Mail Id");
                    Contacts.Email = Console.ReadLine();
                    Display();
                    break;

            }
        }
    }
}
