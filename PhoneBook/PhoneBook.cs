using PhoneBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PhoneBookClass
    {

        public List<Contact> Contacts { get; set; } = new List<Contact>();


        // This method allows to add a new contact to list
        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }


        // This method allows to display information about specified contact from list 
        private void DisplayContatDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
        }

        private void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContatDetails(contact);
            }
        }

        // This method allows to display contact 
        // If contact does not exist it will display "Contact not found" 
        public void DisplayContact(string number)
        {
            var contact = Contacts.FirstOrDefault(c => c.Number == number);

            if (contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContatDetails(contact);
            }
        }

        // This method allows to display all contacts from list
        public void DisplayAllContact()
        {
            DisplayContactsDetails(Contacts);
        }

        // This method allows to search contacts by name 
        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContacts = Contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DisplayContactsDetails(matchingContacts);
        }
    }
}
