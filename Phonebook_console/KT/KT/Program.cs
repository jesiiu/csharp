using KT;
int user_choise = 0;

while (user_choise != 5)
{
    
    Console.WriteLine("Choose option:");
    Console.WriteLine("1: Add new contact");
    Console.WriteLine("2: Display contacts by number");
    Console.WriteLine("3: Dispaly all contacts");
    Console.WriteLine("4: Search contact by name");
    Console.WriteLine("5: Exit");
    string user_input = Console.ReadLine();
    if (int.TryParse(user_input, out user_choise))
    {
        var phonebook = new phonebook_functions();
        switch (user_choise)
        {
            case 1:
                {

                    Console.Write("Insert name:");
                    var user_name = Console.ReadLine();
                    Console.Write("Insert number:");
                    string user_number = Console.ReadLine();
                    int number;
                    if (int.TryParse(user_number, out number))
                    {
                        var new_contact = new Phonebook_props(user_name, number);
                        phonebook.add_contact(new_contact);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number!");
                    }
                    break;
                }
            case 2:
                {
                    Console.Write("Insert contact number:");
                    var user_number = Console.ReadLine();
                    int number;
                    if (int.TryParse(user_number, out number))
                    {
                        phonebook.select_by_number(number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number!");
                    }
                    break;

                }
            case 3:
                {
                    phonebook.select_all();
                    break;
                }
            case 4:
                {
                    Console.Write("Insert contact name: ");
                    var user_name = Console.ReadLine();
                    phonebook.select_by_name(user_name);
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


