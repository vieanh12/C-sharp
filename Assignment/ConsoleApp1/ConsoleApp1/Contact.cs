using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Contact
    {
        private String Name {  get; set; }
        private String PhoneNumber { get; set; }

        public Contact(String Name, String PhoneNumber)
        {
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
        }

        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }

        public string GetName()
        {
            return Name;
        }

    }
}
