using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
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
    }
}
