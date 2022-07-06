﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgramWithCollection
{
    public class MultipleAddressBook
    {
        List<EngineerDetails> contactDetailsList;
        private Dictionary<string, EngineerDetails> contactDetailsMap;
        private Dictionary<string, Dictionary<string, EngineerDetails>> multipleAddressBookMap;


        public MultipleAddressBook()
        {
            contactDetailsList = new List<EngineerDetails>();
            contactDetailsMap = new Dictionary<string, EngineerDetails>();
            multipleAddressBookMap = new Dictionary<string, Dictionary<string, EngineerDetails>>();
        }

        public void ContactList()
        {
            EngineerDetails personEntered = new EngineerDetails();
            Console.Write("Enter First name : ");
            string firstName = Console.ReadLine();
            personEntered.FirstName = Console.ReadLine();

            Console.Write("Enter Last name : ");
            string lastName = Console.ReadLine();

            if (contactDetailsList.Find(i => personEntered.Equals(i)) != null)
            {
                Console.WriteLine("Person already Exists, enter new person!");
                return;
            }

            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            personEntered.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            personEntered.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            personEntered.State = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            int zip = Convert.ToInt32(Console.ReadLine());
            string zipString = zip.ToString();
            personEntered.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter phoneNumber");
            long phoneNumber = Convert.ToInt32(Console.ReadLine());
            string phoneNumberString = phoneNumber.ToString();
            personEntered.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            personEntered.Email = Console.ReadLine();
            contactDetailsList.Add(personEntered);
        }
        public List<EngineerDetails> AddDetails(string addressBook, string firstName, string LastName, string address, string city, string state, int zip, long phoneNumber, string email)
        {
            EngineerDetails contactDetails = new EngineerDetails();
            contactDetailsList.Add(contactDetails);
            return contactDetailsList;
        }
        public void AddressBook(string addressBook)
        {
            multipleAddressBookMap.Add(addressBook, contactDetailsMap);
        }
        //Searching a Person
        public Dictionary<string, EngineerDetails> Search()
        {
            Console.Write(" Enter state : ");
            string state = Console.ReadLine();
            var stateCheck = contactDetailsList.FindAll(x => x.State == state);
            Console.Write(" Enter city : ");
            string city = Console.ReadLine();
            var cityCheck = stateCheck.FindAll(x => x.City == city);
            Console.Write(" Find Person : ");
            string firstName = Console.ReadLine();
            var person = cityCheck.Where(x => x.FirstName == firstName).FirstOrDefault(); //Returns the First Element 
            if (person != null)
            {
                Console.WriteLine(firstName + " is  in " + city);
            }
            else
            {
                Console.WriteLine(firstName + " is not  in " + city);
            }


            Dictionary<string, EngineerDetails> detailCity = new Dictionary<string, EngineerDetails>();
            Dictionary<string, EngineerDetails> detailState = new Dictionary<string, EngineerDetails>();
            detailCity.Add(city, person);
            detailState.Add(state, person);
            foreach (KeyValuePair<string, EngineerDetails> i in detailCity)
            {
                Console.WriteLine("City: {0}  {1}", i.Key, i.Value.toString());
            }

            foreach (KeyValuePair<string, EngineerDetails> i in detailState)
            {
                Console.WriteLine("State: {0}  {1}", i.Key, i.Value.toString());
            }

            Console.WriteLine(detailCity.Count());
            return detailCity;
        }
        public void Count()
        {
            Console.WriteLine(" Enter state ");
            string state = Console.ReadLine();
            var stateCheck = contactDetailsList.FindAll(x => x.State == state);
            Console.WriteLine(" No of contacts from the state: " + state + " are " + stateCheck.Count);
        }
        public void ComputeDetails()
        {
            foreach (EngineerDetails book in contactDetailsList)
            {
                Console.WriteLine(book.toString());
            }
        }
    }
    
}
