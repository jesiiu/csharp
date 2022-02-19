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
            string user_input = Console.ReadLine();
            int number;
            if(int.TryParse(user_input, out number))
            {
                contact.contact_number = number;
                phonebook.Add(contact.contact_name, contact.contact_number);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Your number is invalid!");
            }
            

        }

        public void select_by_number(Dictionary<string, int> phonebook)
        {
            Console.Clear();
            Console.WriteLine("Insert phone number:");
            string user_input = Console.ReadLine();
            int number;
            if (int.TryParse(user_input, out number))
            {
                foreach (KeyValuePair<string, int> item in phonebook)
                {
                    var itemvalue = item.Value;

                    if (itemvalue == number)
                    {
                        Console.WriteLine($"{item.Key} , {item.Value}");
                        Console.WriteLine("Press any button...");
                        Console.ReadKey();
                        Console.Clear();
                    }

                }
            }
            else
            { 
                Console.WriteLine("Invalid phone number!"); 
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
            
            Console.WriteLine("Insert contact name:");
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
