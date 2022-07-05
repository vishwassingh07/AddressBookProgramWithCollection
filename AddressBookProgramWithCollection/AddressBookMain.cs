using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgramWithCollection
{
    public class AddressBookMain
    {
        //Create dictionary to store result
        Dictionary<string, string> Contacts = new Dictionary<string, string>();

        //UC1 - Create Contact
        public void CreateContact()
        {
            Console.Write("First Name : ");
            Contacts.Add("First Name ", Console.ReadLine());

            Console.Write("Last Name : ");
            Contacts.Add("Last Name ", Console.ReadLine());

            Console.Write("Address : ");
            Contacts.Add("Address ", Console.ReadLine());

            Console.Write("City : ");
            Contacts.Add("City ", Console.ReadLine());

            Console.Write("State : ");
            Contacts.Add("State ", Console.ReadLine());

            Console.Write("Zip Code : ");
            Contacts.Add("Zip Code ", Console.ReadLine());

            Console.Write("Phone Number : ");
            Contacts.Add("Phone Number  ", Console.ReadLine());

            Console.Write("Email Address : ");
            Contacts.Add("Email Address ", Console.ReadLine());

        }
        //Display Contact
        public void Display()
        {
            foreach (var contact in Contacts)
            {
                Console.WriteLine(contact);
            }
        }
    }
}
