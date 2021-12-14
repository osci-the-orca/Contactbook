using System.Collections.Generic;

namespace ClassLibrary
{
    public interface IDataManager
    {
        void InsertContact(ContactModel contact);

        IList<ContactModel> ShowAllContacts();

        void RemoveContact(ContactModel contact);
    }
}