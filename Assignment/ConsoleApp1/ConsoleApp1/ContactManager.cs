using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ContactManager
    {
        private Hashtable contacts = new Hashtable();

        public void AddContact()
        {
            Console.Write("Enter Name: ");
            String Name = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            String phoneNumber = Console.ReadLine();
            contacts.Add(Name, phoneNumber);
        }

        public void FindContactByName()
        {
            Console.Write("Enter Name to find: ");
            String nameToFind = Console.ReadLine();
            
            if(contacts.ContainsKey(nameToFind)) 
            {
                foreach (DictionaryEntry entry in contacts)
                {
                    Console.WriteLine("{0}                                {1}", entry.Key, entry.Value);
                }
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        public void DisplayContacts()
        {
            Console.WriteLine("Contact List:");
            foreach (DictionaryEntry entry in contacts)
            {
                Console.WriteLine("             Adress Book  ");
                Console.WriteLine("ContactName                  Phone number");
                Console.WriteLine("{0}                                {1}", entry.Key, entry.Value);
            }
        }

    }
}
