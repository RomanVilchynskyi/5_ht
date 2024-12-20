using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _05_ht
{
    public class CreditCard
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string ExpirationDate { get; set; }
        public string CVV { get; set; }

        public CreditCard(string name, string number, string expirationDate, string cvv)
        {
            Name = name;
            Number = number;
            ExpirationDate = expirationDate;
            CVV = cvv;

            Validate();
        }
        private void Validate()
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new ArgumentException("Name cannot be empty");

            if (Number.Length != 16 || !IsAllDigits(Number))
                throw new ArgumentException("Card number must be a 16-digit number");

            if (!IsValidExpirationDate(ExpirationDate))
                throw new ArgumentException("Expiration date must be in MM/YY format");

            if (CVV.Length != 3 || !IsAllDigits(CVV))
                throw new ArgumentException("CVV must be a 3-digit number");

        }

        private bool IsAllDigits(string input)
        {
            foreach (char i in input)
            {
                if (!char.IsDigit(i))
                    return false;
            }
            return true;
        }

        private bool IsValidExpirationDate(string date)
        {
            if (date.Length != 5 || date[2] != '/')
                return false;

            string[] days = date.Split('/');

            if (days.Length != 2)
                return false;

            if (!IsAllDigits(days[0]) || !IsAllDigits(days[1]))
                return false;

            int month = int.Parse(days[0]);
            if (month < 1 || month > 12)
                return false;

            return true;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Card Number: {Number}, Expiration Date: {ExpirationDate}, CVV: ***";
        }
    }
}   
