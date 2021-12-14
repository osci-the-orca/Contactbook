using System;

namespace ClassLibrary
{
    public class ContactModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StreetAddress { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        public ContactModel()
        {

        }
        public ContactModel(string firstName, string lastName, string streetAddress, string emailAddress, string phoneNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.StreetAddress = streetAddress;
            this.EmailAddress = emailAddress;
            this.PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
