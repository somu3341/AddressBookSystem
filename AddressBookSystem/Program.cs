using System;
namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Address Book Program in AddressBookMain class");
            AddressBookMain addressBookMain = new AddressBookMain();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Option\n1.Add Contact\n 2.Edit Contact\n 3.Delete Contact \n4.Search by City \n5.View Persons Using State \n6.Get Phone Number Using City and State \n7.Exit");
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
                        addressBookMain.Display();
                        break;
                    case 3:
                        addressBookMain.DeleteContact();
                        addressBookMain.Display();
                        break;
                        case 4:
                        Console.WriteLine("Enter First Name");
                       string first=Console.ReadLine();
                        Console.WriteLine("Enter City Name");
                        string city=Console.ReadLine();
                        addressBookMain.SearchPersonUsingCity(first, city);
                        break;
                    case 5:
                        Console.WriteLine("Enter City Name");
                        string ciity = Console.ReadLine();
                        Console.WriteLine("Enter State Name");
                        string state = Console.ReadLine();
                        addressBookMain.SearchingByCityAndState(ciity, state);
                        break;
                        case 6:
                        Console.WriteLine("Enter City Name");
                        string cty= Console.ReadLine();
                        addressBookMain.ByCity(cty);
                        Console.WriteLine("Enter State Name");
                        string stat = Console.ReadLine();
                        addressBookMain.ByCity(stat);
                        break;
                    case 7:
                        flag = false;
                        break;
                }
            }
        }
    }
}