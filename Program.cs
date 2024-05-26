using System;
using System.Security.Cryptography.X509Certificates;
namespace PhoneBookApp{
    public class Program{
        public static void Main(string[] args){
            Console.WriteLine("Welcome to PhoneBookApp");
            Console.WriteLine("**************************************");
            PhoneBook phoneBook = new PhoneBook();

            while(true){
                phoneBook.DisplayOptions();
                Console.WriteLine("**************************************");
                int option = int.Parse(Console.ReadLine());
                
                switch(option){
                    case 1:
                        Console.WriteLine("Enter the Contact Details You Want to Add: ");
                        phoneBook.AddContact();
                        break;
                    case 2:
                        phoneBook.DisplayAllContacts();
                        break;
                    case 3:
                        Console.WriteLine("Enter the Number you want to display:");
                        string number = Console.ReadLine();
                        phoneBook.DisplayContactByNumber(number);
                        break;
                    case 4:
                        Console.WriteLine("Enter the Name:");
                        string name = Console.ReadLine();
                        phoneBook.SearchContactByName(name);
                        break;
                    case 5:
                        Console.WriteLine("Thank you for Using our PhoneBookApp");
                        return;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }



            }
            
        }
    }
}