using PhoneBook;
using System;
using System.Diagnostics;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the PhoneBook app!");

            Console.WriteLine("1. Add contact");
            Console.WriteLine("2. Display contact by number");
            Console.WriteLine("3. Display all contacts");
            Console.WriteLine("4. Search contact by name");
            Console.WriteLine("X. Exit");

            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBookClass();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Insert number");
                        var number = Console.ReadLine();
                        Console.WriteLine("Insert name");
                        var name = Console.ReadLine();
                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);
                        break;

                    case "2":
                        Console.WriteLine("Insert number");
                        var numberToSearch = Console.ReadLine();
                        phoneBook.DisplayContact(numberToSearch);
                        break;

                    case "3":
                        phoneBook.DisplayAllContact();
                        break;

                    case "4":
                        Console.WriteLine("Insert search phrase");
                        var searchPhrase = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(searchPhrase);
                        break;

                    case "X":
                        return;

                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
                Console.WriteLine("Select operation");
                userInput = Console.ReadLine();
            }


        }
    }
}
