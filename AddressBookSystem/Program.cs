using System;
using System.Runtime.Loader;

namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Address Book\r\nProgram in\r\nAddressBookMain class");
            AddressBookMain addressBookMain = new AddressBookMain();
            addressBookMain.addcontact();
            addressBookMain.Display(); 
            addressBookMain.Edit();
        }
    }
}