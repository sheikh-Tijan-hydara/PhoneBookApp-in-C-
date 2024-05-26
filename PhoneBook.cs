using System;

namespace PhoneBookApp
{
    
    public class PhoneBook{

        private List<Contact> _contacts {get; set;} = new List<Contact>();
       public void AddContact(){
            Console.WriteLine("Enter the Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the Number:");
            string Number = Console.ReadLine();

            _contacts.Add(new Contact(Name, Number));
            Console.WriteLine("Contact added successfully");
            Console.WriteLine("**************************************");
            
        }
        private void DisplayContactDetails(Contact contact){
            Console.WriteLine("**************************************");
            Console.WriteLine("Name: " + contact.GetName());
            Console.WriteLine("Number: " + contact.GetNumber());
            Console.WriteLine("**************************************");
        }

       public void DisplayAllContacts(){
            foreach(var contact in _contacts){
                DisplayContactDetails(contact);
            }
        }
       public void DisplayContactByNumber(string number){
           var contact = _contacts.FirstOrDefault(c => c.GetNumber() == number);
              if(contact != null){
                    DisplayContactDetails(contact);
              }
              else{
                 Console.WriteLine("**************************************");
                  Console.WriteLine("Sorry contact not found");
              }
        }

      public void SearchContactByName(string name){
            var contact = _contacts.Where(c => c.GetName().Contains(name)).ToList();
            if(contact != null){
                foreach(var c in contact){
                    DisplayContactDetails(c);
                }
            }
            else{
                Console.WriteLine("Contact not found");
            }
        }
       public void DisplayOptions(){
            Console.WriteLine("Choose an option from the following: ");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Display All Contacts");
            Console.WriteLine("3. Display Contact By Number");
            Console.WriteLine("4. Search Contact By Name");
            Console.WriteLine("5. Exit");
        }
    }
}