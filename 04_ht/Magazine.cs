using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ht
{
    internal class Magazine
    {
        private string name = "No name";
        private int year = 0;
        private string description = "No description";
        private int phone = 111111111;
        private string email = "no email";

        public Magazine()
        {
        }
        public Magazine(string name, int year, string description, int phone, string email)
        {
            this.name = name;
            this.year = year;
            this.description = description;
            this.phone = phone;
            this.email = email;
        }

        public void SetName(string name) => this.name = name;
        public void SetYear(int year) => this.year = year;
        public void SetDescription(string description) => this.description = description;
        public void SetPhone(int phone) => this.phone = phone;
        public void SetEmail(string email) => this.email = email;

        public string GetName() => name;
        public int GetYear() => year;
        public string GetDescription() => description;
        public int GetPhone() => phone;
        public string GetEmail() => email;

        public void print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Year of Establishment: {year}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"Phone: {phone}");
            Console.WriteLine($"Email: {email}");
        }
    }
}
