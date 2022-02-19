using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT
{
    internal class phonebook_functions
    {
        public static List<Phonebook_props> phonebook { get; set; } = new List<Phonebook_props>();
        
        public void add_contact(Phonebook_props new_contact)
        {
            phonebook.Add(new_contact);
        }
        private void Contact_Details(Phonebook_props contact)
        {
            Console.WriteLine($"Contact name: {contact.contact_name}, contact number: {contact.contact_number}");
        }
        private void DisplayContacts(List<Phonebook_props> contacts)
        {
            foreach (var contact in contacts)
            {
                Contact_Details(contact);
            }
        }
        public void select_by_number(int number)
        {
            var contact = phonebook.FirstOrDefault(c => (c.contact_number == number));
            if(contact == null)
            {
                Console.WriteLine("Contact not found!");
            }
            else
            {
                Contact_Details(contact);
            }
        }

        public void select_all()
        {
            DisplayContacts(phonebook);
        }


        public void select_by_name(string search)
        {
            var contact_by_name = phonebook.Where(c => c.contact_name.Contains(search)).ToList();
            DisplayContacts(contact_by_name);

        }


    }
}
