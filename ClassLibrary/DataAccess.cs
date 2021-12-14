using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;


namespace ClassLibrary
{
    public class DataAccess : IDataManager
    {
        public IList<ContactModel> ShowAllContacts()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ContactBookDB")))
            {
                return connection.Query<ContactModel>("dbo.Get_All_Contacts").ToList();
            }
        }

        public void InsertContact(ContactModel contact)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ContactBookDB")))
            {
                connection.Execute("dbo.Insert_Contact @FirstName, @LastName, @StreetAddress, @EmailAddress, @PhoneNumber", contact);
            }
        }

        public void RemoveContact(ContactModel contact)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ContactBookDB")))
            {
                connection.Execute("dbo.Delete_Contact @Id", contact);
            }
        }

    }
}