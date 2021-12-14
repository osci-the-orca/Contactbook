using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class ContactBookFunctions
    {
        private List<ContactModel> contacts = new List<ContactModel>();

        private readonly IDataManager dataManager;

        public ContactBookFunctions(IDataManager iDataManager)
        {
            dataManager = iDataManager;
        }

        public IList<ContactModel> GetListOfContacts()
        {
            return dataManager.ShowAllContacts();
        }
        public void AddContact(ContactModel contact)
        {
            dataManager.InsertContact(contact);
        }

        public List<ContactModel> SearchContact(string input)
        {
            return contacts.FindAll(c => c.ToString().Contains(input, StringComparison.OrdinalIgnoreCase));
        }

        public void DeleteContact(ContactModel contact)
        {
            dataManager.RemoveContact(contact);
        }
    }
}