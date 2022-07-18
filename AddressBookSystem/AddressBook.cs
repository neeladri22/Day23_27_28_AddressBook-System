﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        // Creating list for Storing the Contacts of Each Persons details
        public static List<Contact> AddressDetails = new List<Contact>();

        // Creating the dictionary to save the Multiple conatact in Addressbook
        public static Dictionary<string, Contact> ContactsDetails = new Dictionary<string, Contact>();

        public static Contact person = new Contact();

        //Creating the method for creating the contact person
        public static void createContactPerson()
        {
            Contact contact = new Contact();

            contact.FirstName = "Neeladri";

            contact.LastName = "pulakala";

            contact.Address = "d.no:365, Icchapuram";

            contact.City = "Srikakulam";

            contact.State = "Andhra";

            contact.ZipCode = 532312;

            contact.MobileNumber = 7855465987;

            contact.Email = "neela22@gmail.com";

             PrintContact(contact);
            Console.WriteLine("\n************************************\n");

        }
        // Display the Person Details
        public static void PrintContact(Contact person)
        {
            Console.WriteLine("First Name :" + person.FirstName);
            Console.WriteLine("Last Name :" + person.LastName);
            Console.WriteLine("Address :" + person.Address);
            Console.WriteLine("City :" + person.City);
            Console.WriteLine("State :" + person.State);
            Console.WriteLine("Zip Code :" + person.ZipCode);
            Console.WriteLine("Mobile Number :" + person.MobileNumber);
            Console.WriteLine("E-Mail :" + person.Email);
        }

        // Creating the method for Adding new contact
        public static void AddNewContact()
        {
            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Address : ");
            person.Address = Console.ReadLine();

            Console.Write("Enter City: ");
            person.City = Console.ReadLine();

            Console.Write("Enter State: ");
            person.State = Console.ReadLine();

            Console.Write("Enter Zip Code: ");
            person.ZipCode = int.Parse(Console.ReadLine());

            Console.Write("Enter Mobile Number: ");
            person.MobileNumber = long.Parse(Console.ReadLine());

            Console.Write("Enter E-Mail: ");
            person.Email = Console.ReadLine();

            Console.WriteLine("\n************************************\n");
            PrintContact(person);
           
            AddressDetails.Add(person);
        }

        // /Creating the method for editing the existing contact
        public static void EditExistingContact()
        {
            Console.WriteLine("Enter the First Name of the person you would like to Edit.");

            string firstName = Console.ReadLine();
            Contact person = AddressDetails.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower());
            if (person == null)
            {
                Console.WriteLine("That person could not be found. Press any key to continue");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("\nDetails of the entered person is:\n");
             PrintContact(person);
            Console.WriteLine("\n************************************\n");

            Console.WriteLine("\n");
            Console.WriteLine("Are you sure you want to Edit this person from your address book? (Y/N)");
            string c = Console.ReadLine().ToLower();
            if (c == "y")
            {
                AddressDetails.Remove(person);
            }
            AddressBook.AddNewContact();
            Console.WriteLine("Person details Edited Successfully. Press any key to continue.");
            Console.ReadKey();

        }
    }
