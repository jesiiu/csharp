using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT
{
    internal class phonebook_functions : Phonebook
    {

        public void add_contact(Dictionary<string, int> phonebook)
        {
            Console.Clear();
            phonebook_functions contact = new phonebook_functions();
            Console.Write("Insert name:");
            string name = Console.ReadLine();
            contact.contact_name = name;
            Console.Write("Insert number:");
            int number = int.Parse(Console.ReadLine());
            contact.contact_number = number;
            phonebook.Add(contact.contact_name, contact.contact_number);
            Console.Clear();

        }

        public void select_by_number(Dictionary<string, int> phonebook)
        {
            Console.Clear();
            Console.WriteLine("Wpisz numer telefonu:");
            int user_number = int.Parse(Console.ReadLine());
            
            foreach (KeyValuePair<string, int> item in phonebook)
            {
                var itemvalue = item.Value;

                if (itemvalue == user_number)
                {
                    Console.WriteLine($"{item.Key} , {item.Value}");
                }

            }
            
        }

        public void select_all(Dictionary<string, int> phonebook)
        {
            
            foreach (KeyValuePair<string, int> item in phonebook)
            {
                var itemkey = item.Key;
                var itemvalue = item.Value;
                Console.WriteLine($"{itemkey} {itemvalue}");
            }
            
        }


        public void select_by_name(Dictionary<string, int> phonebook)
        {
            
            Console.WriteLine("Wpisz nazwe kontaktu:");
            string user_name = Console.ReadLine();

            foreach (KeyValuePair<string, int> item in phonebook)
            {
                var itemkey = item.Key;

                if (itemkey == user_name)
                {
                    Console.WriteLine($"{item.Key} , {item.Value}");
                }
            }
        }


    }
}
