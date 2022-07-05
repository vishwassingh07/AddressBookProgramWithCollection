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
            Console.WriteLine("Choose an option to execute :\n1. Create Contact\n2. Add Contact\n3. End The Program");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    addingContact.CreateContact();
                    Console.WriteLine("Contact has created");
                    break;
                case 2:
                    addingContact.CreateContact();
                    Console.WriteLine("Contact has added ");
                    addingContact.Display();
                    break;
                case 3:
                    end = false;
                    break;
                default:
                    Console.WriteLine("Invalid option ");
                    break;
            }
        }
    }
}