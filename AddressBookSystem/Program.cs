using System;
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
            AddressBook.createContactPerson();
        }
    }
}
