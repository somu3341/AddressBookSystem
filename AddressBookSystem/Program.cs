using System;
namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Address Book\r\nProgram in\r\nAddressBookMain class");
            AddressBookMain addressBookMain = new AddressBookMain();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Option \n1. Add Contact\n 2. Edit Contact\n 3. Delete Contact\n 4.Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the number of contacts to add");
                        int N = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < N; i++)
                        {
                            addressBookMain.addcontact();
                        }
                        addressBookMain.Display();
                        break;
                    case 2:
                        addressBookMain.Edit();
                        break;
                    case 3:
                        addressBookMain.DeleteContact();
                        addressBookMain.Display();
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}