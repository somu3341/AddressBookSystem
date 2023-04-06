﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookMain
    {              
        List<CreateContacts> AddressBook = new List<CreateContacts>();
        CreateContacts Contacts = new CreateContacts();
        Dictionary<string, List<CreateContacts>> list = new Dictionary<string, List<CreateContacts>>();
        public void addcontact()
        {
            Console.WriteLine("Enter First Name");
            Contacts.FirstName = Console.ReadLine();
            //int a = CheckUnique(Contacts.FirstName);
            //if (a == 0)
                int b = CheckDuplicate(Contacts.FirstName);
            if (b == 0)
            {
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
                AddressBook.Add(Contacts);
                list.Add(Contacts.FirstName, AddressBook);    
            }
        }
        public int CheckUnique(string name)
        {
            int flag = 0;
            if (list.Count !=0)
            {
                foreach (var data in list)
                {
                    foreach (var item in data.Value)
                    {
                        if (data.Key == name)
                        {
                            Console.WriteLine("The Name You have given is Already Present");    
                            flag++;
                            break;
                        }
                    }
                }
            }
            return flag;
        }
        public int CheckDuplicate(string name)
        {
            int sum = 0;
            if(list.Count !=0)
            foreach (var data in list)
            {
              foreach(var item in data.Value)                 
                        if (data.Key.Any(x => x.Equals(name)))
                        {
                            Console.WriteLine("Duplicate is present");
                            sum = 1;
                            break;
                        }                    
            }
            return sum;
        }
        public void SearchPersonUsingCity(string firstname, string city)
        {
            foreach(var data in list)
            {
                if(list.Keys.Equals(firstname))
                {
                    var citylist = data.Value.Where(x => x.Equals(city));
                   foreach(var item in citylist)
                    {
                        Console.WriteLine("First Name:- "+ item.FirstName + "Last Name:- " + item.LastName +"City Name:-"+item.City +"State:- "+item.State+"ZIP code:- "+item.ZIP+"Phonenumber:- "+item.PhoneNumber+"Email:- "+item.Email);
                    }
                }
                else
                {
                    Console.WriteLine("The first doesnot exits hear");
                }
            }
        }
        public void Display()
        {
           foreach (var data in AddressBook)
            {      
                Console.WriteLine("First name: " + Contacts.FirstName + "\nLastname: " + Contacts.LastName + "\nAddress: " + Contacts.Address +
                  "\nCity: " + Contacts.City + "\nState: " + Contacts.State + "\nZIP: " + Contacts.ZIP + "\nPhone Number: " + Contacts.PhoneNumber + "\nEmail: " + Contacts.Email);
            }
        }
        public void Edit()
        {
            Console.WriteLine("Edit Using First Name");
            string name = Console.ReadLine();
            foreach (var data in AddressBook)
            {
                if (data.FirstName == name)
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
        public void DeleteContact()
        {
            Console.WriteLine("Enter name to delete contact");
            string name = Console.ReadLine();
            foreach (var data in AddressBook)
            {
                if (data.FirstName.Equals(name))
                {
                    Contacts = data;
                }
            }
            AddressBook.Remove(Contacts);
        }
    }
}
