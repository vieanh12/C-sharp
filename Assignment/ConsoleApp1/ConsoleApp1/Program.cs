using ConsoleApp1;

class Program
{
    static void Main()
    {
        ContactManager contactManager = new ContactManager();

        while (true)
        {
            Console.WriteLine("Contact Manager Menu:");
            Console.WriteLine("1. Add new contact");
            Console.WriteLine("2. Find a contact by name");
            Console.WriteLine("3. Display contacts");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    contactManager.AddContact();
                    break;

                case 2:
                    contactManager.FindContactByName();
                    break;

                case 3:
                    contactManager.DisplayContacts();
                    break;

                case 4:
                    Console.WriteLine("Exiting the Contact Manager.");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }
}