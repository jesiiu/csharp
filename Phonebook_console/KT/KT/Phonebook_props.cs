using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT
{
    internal class Phonebook_props
    {
       public Phonebook_props(string Name, int Number)
        {
            contact_name = Name;
            contact_number = Number;
        }
        public string contact_name { get; set; }
        public int contact_number { get; set; }
    }
}
