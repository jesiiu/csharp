using KT;
Dictionary<string, int> phonebook = new Dictionary<string, int>();
phonebook.Add("Kacper", 12345678);
phonebook.Add("Eryk", 123123123);
phonebook_functions contact = new phonebook_functions();
int user_choise = 0;

while (user_choise != 5)
{
    
    Console.WriteLine("Wybierz opcje:");
    Console.WriteLine("1: Dodaj kontakt");
    Console.WriteLine("2: Wyświetl kontakt na podstawie numeru telefonu");
    Console.WriteLine("3: Wyświetl wszystkie kontakty");
    Console.WriteLine("4: Wyszukaj kontakt po nazwie");
    Console.WriteLine("5: Wyjdz");
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
                    Console.WriteLine("Nie ma takiej opcji!");
                    break;
                }

        }
    }
    else
    {
        Console.WriteLine("Wybierz opcje od 1 do 5");
    }
}


