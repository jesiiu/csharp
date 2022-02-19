using KT;
Dictionary<string, int> phonebook = new Dictionary<string, int>();
phonebook.Add("Kacper", 12345678);
phonebook.Add("Eryk", 123123123);
phonebook_functions contact = new phonebook_functions();
int user_choise = 0;

while (user_choise != 5)
{
    
    Console.WriteLine("Choose option:");
    Console.WriteLine("1: Add new contact");
    Console.WriteLine("2: Show phone numbers by name of contact");
    Console.WriteLine("3: Show all contacts");
    Console.WriteLine("4: Search contact by phone number");
    Console.WriteLine("5: Exit");
    string user_input = Console.ReadLine();
    if (int.TryParse(user_input, out user_choise))
    {
        switch (user_choise)
        {
            case 1:
                {

                    contact.add_contact(phonebook);
                    break;
                }
            case 2:
                {
                    contact.select_by_number(phonebook);
                    break;

                }
            case 3:
                {
                    contact.select_all(phonebook);
                    break;
                }
            case 4:
                {
                    contact.select_by_name(phonebook);
                    break;
                }
            case 5:
                {
                    Environment.Exit(0);
                    break;
                }
            default:
                {
                    Console.WriteLine("Choose valid option!");
                    break;
                }

        }
    }
    else
    {
        Console.WriteLine("Choose option from 1 to 5!");
    }
}


