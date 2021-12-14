using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //Testing Methods in Main right now. To lazy to create ConsoleMenuUI. seems to be working

            ContactBookFunctions contactBookFunctions = new ContactBookFunctions(new DataAccess());

            contactBookFunctions.AddContact(new ContactModel("Kalle", "Fransson", "Sten gatan 16", "Kfransy@mail.com", "0712217131"));

            IList<ContactModel> contacts = contactBookFunctions.GetListOfContacts();

            foreach (var item in contacts)
            {
                Console.WriteLine($"{contacts.IndexOf(item)} {item}");
            }

            Console.WriteLine("\nEnter the number of the Contact you want to remove");
            string userInput = Console.ReadLine();

            if (Int32.TryParse(userInput.ToString(), out int num))
            {
                contactBookFunctions.DeleteContact(contacts.ElementAt(num));

            }
            else
            {
                Console.WriteLine("Invalid input");

            }
        }
    }
}
