using System;
namespace AddressBookProgramWithCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Address Book Program\n===================================");
            AddressBookMain addingContact = new AddressBookMain();
            bool end = true;
            while (end)
            {
                Console.WriteLine("Choose an option to execute :\n1. Create Contact\n2. Add Contact\n3. Edit Contact\n4." +
                    " Delete Contact\n5. End The Program");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addingContact.AddContact();
                        Console.WriteLine("Contact has created");
                        break;
                    case 2:
                        addingContact.AddContact();
                        Console.WriteLine("Contact has added ");
                        addingContact.Display();
                        break;
                    case 3:
                        addingContact.EditContact();
                        addingContact.ViewContact();
                        break;
                    case 4:
                        addingContact.DeleteContact();
                        break;
                    case 5:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option ");
                        break;
                }
            }

        }
    }
}