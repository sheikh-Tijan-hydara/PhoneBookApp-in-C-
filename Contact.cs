using System;

namespace PhoneBookApp{
    public class Contact{
        string Name;
        string Number;

        public Contact(string Name, string Number){
            this.Name = Name;
            this.Number = Number;
        }

        public string GetNumber(){
            return this.Number;
        }

        public string GetName(){
            return this.Name;
        }

        public void SetName(string Name){
            this.Name = Name;
        }

        public void SetNumber(string Number){
            this.Number = Number;
        }
    }
}