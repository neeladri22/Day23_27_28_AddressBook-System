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
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddressBook.AddNewContact(); //Adding the new contact
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
                    default:
                        Console.WriteLine("Pleasee select valid input");
                        break;
                }

            }

        }
    }
}
