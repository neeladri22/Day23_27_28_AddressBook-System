﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book system program");
            Console.WriteLine("\n");

            // Creating the Contact
            // AddressBook.createContactPerson();

            //Adding a New Contact to addressbook
            //AddressBook.AddNewContact();

            //Edit Existing contact
            //AddressBook.EditExistingContact();

            //Delete the contact using person's name
            // AddressBook.deleteContact();

            while (true)
            {
                Console.WriteLine("\nEnter 1 to Add New Contact in AddressBook");
                Console.WriteLine("\nEnter 2 to Edit the Existing Contact in AdressBook using Person's Name");
                Console.WriteLine("\nEnter 3 to Delete the Person using Person's Name in AddressBook");
                Console.WriteLine("\nEnter 4 to Get List of Contact in AddressBook");
                Console.WriteLine("\nEnter 5 to Get List of Address Book in AddressBook");
                Console.WriteLine("\nEnter 6 to Search person in City in AddressBook");
                Console.WriteLine("\nEnter 7 to Search person in State in AddressBook");
                Console.WriteLine("\nEnter 8 to To get the list of persons belongs to same city in Address Book");
                Console.WriteLine("\nEnter 9 to To get the list of persons belongs to same State in Address Book");
                Console.WriteLine("\nEnter 10 to To get the Number of persons belongs to same city in Address Book");
                Console.WriteLine("\nEnter 11 to To get the Number of persons belongs to same State in Address Book");
                Console.WriteLine("\nEnter 12 to To get the List of entries in address book sorted by Persons Name in Address Book");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddressBook.AddNewContact(); //Adding the new contact ensured that No duplicate values entry of the ssame person in a partiucular AddressBook
                        break;
                    case 2:
                        AddressBook.EditExistingContact(); // Edit the existing contact using person's name
                        break;
                    case 3:
                        AddressBook.deleteContact(); //Delete the contact using person's name
                        break;
                    case 4:
                        AddressBook.ListOfContact(); //To get the list of contact in Addressbook
                        break;
                    case 5:
                        AddressBook.AddressBookNames(); //Display the multiple addressbook with unique name and details
                        break;
                    case 6:
                        AddressBook.SearchPersonInCity(); //Search person in City
                        break;
                    case 7:
                        AddressBook.SearchPersonInState(); //Search person in State
                        break;
                    case 8:
                        AddressBook.ListOfPersonsofSameCity(); //List of Persons belongs to same city
                        break;
                    case 9:
                        AddressBook.ListOfPersonsofSameState(); //List of Persons belongs to same state
                        break;
                    case 10:
                        AddressBook.SearchPersonInCity(); //Number of Persons belongs to same city
                        break;
                    case 11:
                        AddressBook.SearchPersonInState(); //Number of Persons belongs to same state
                        break;
                    case 12:
                        AddressBook.SortByPersonsName(); //Sort the entries in Addressbook by persons name
                        break;
                    default:
                        Console.WriteLine("Pleasee select valid input");
                        break;
                }
            }
        }
    }
}
