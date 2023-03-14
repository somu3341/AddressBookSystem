using System;
namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Address Book\r\nProgram in\r\nAddressBookMain class");
            CreateContacts createContacts = new CreateContacts();
            Console.WriteLine("Enter First Name");
            createContacts.FirstName = Console.ReadLine();
            Console.WriteLine("Enetr Last Name");
            createContacts.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            createContacts.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            createContacts.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            createContacts.Satate = Console.ReadLine();
            Console.WriteLine("Enter ZIP");
            createContacts.ZIP = Console.ReadLine();
            Console.WriteLine("Enetr Phone NUmber");
            createContacts.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email");
            createContacts.Email = Console.ReadLine();
        }
    }
}