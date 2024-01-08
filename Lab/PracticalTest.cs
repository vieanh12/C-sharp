using System;
using System.Collections;

// A class to store contact information
class Contact
{
    public string Name { get; set; }
    public string Phone { get; set; }

    public Contact(string name, string phone)
    {
        Name = name;
        Phone = phone;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Phone: {Phone}";
    }
}

// A class to manage contacts using HashTable
class ContactManager
{
    // A HashTable to store contacts by name
    private HashTable contacts;

    public ContactManager()
    {
        contacts = new HashTable();
    }

    // A method to add a new contact
    public void AddContact()
    {
        Console.WriteLine("Enter the name of the contact:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the phone number of the contact:");
        string phone = Console.ReadLine();
        // Create a new Contact object
        Contact contact = new Contact(name, phone);
        // Add the contact to the HashTable with name as the key
        contacts.Add(name, contact);
        Console.WriteLine("Contact added successfully.");
    }

    // A method to find a contact by name
    public void FindContact()
    {
        Console.WriteLine("Enter the name of the contact to search:");
        string name = Console.ReadLine();
        // Check if the name exists in the HashTable
        if (contacts.ContainsKey(name))
        {
            // Get the contact from the HashTable
            Contact contact = (Contact)contacts[name];
            // Display the contact information
            Console.WriteLine("Contact found:");
            Console.WriteLine(contact);
        }
        else
        {
            // Display a message if the name is not found
            Console.WriteLine("Not found.");
        }
    }

    // A method to display all the contacts
    public void DisplayContacts()
    {
        Console.WriteLine("All contacts:");
        // Loop through the HashTable and display each contact
        foreach (DictionaryEntry entry in contacts)
        {
            Contact contact = (Contact)entry.Value;
            Console.WriteLine(contact);
        }
    }

    // A method to display the menu and get the user's choice
    public int GetChoice()
    {
        Console.WriteLine("Contact Manager Menu");
        Console.WriteLine("1. Add new contact");
        Console.WriteLine("2. Find a contact by name");
        Console.WriteLine("3. Display contacts");
        Console.WriteLine("4. Exit");
        Console.WriteLine("Enter your choice:");
        // Parse the user's input as an integer
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }

    // A method to run the program
    public void Run()
    {
        // A variable to store the user's choice
        int choice;
        // A loop to repeat until the user chooses to exit
        do
        {
            // Get the user's choice from the menu
            choice = GetChoice();
            // Perform different actions based on the choice
            switch (choice)
            {
                case 1:
                    AddContact();
                    break;
                case 2:
                    FindContact();
                    break;
                case 3:
                    DisplayContacts();
                    break;
                case 4:
                    Console.WriteLine("Thank you for using Contact Manager.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 4);
    }
}

// The main class
class Program
{
    // The main method
    static void Main(string[] args)
    {
        // Create a new ContactManager object
        ContactManager manager = new ContactManager();
        // Run the program
        manager.Run();
    }
}
