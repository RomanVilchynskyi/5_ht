using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ht
{
    public class Money
    {
        public int WholePart { get; set; } 
        public int Kopeyks { get; set; }    

        public Money(int wholePart, int kop)
        {
            WholePart = wholePart;
            Kopeyks = kop;
        }

        public void Print()
        {
            Console.WriteLine($"Sum: {WholePart}.{Kopeyks:D2}");
        }

        public void SetValues(int wholePart, int kop)
        {
            WholePart = wholePart;
            Kopeyks = kop;
        }
    }

    public class Product : Money
    {
        public string Name { get; set; } 

        public Product(string name, int wholePart, int kop) 
            : base(wholePart, kop)
        {
            Name = name;
        }

        public void ReducePrice(int wholeReduction, int centsReduction)
        {
            int totalCents = (WholePart * 100 + Kopeyks) - (wholeReduction * 100 + centsReduction);
            if (totalCents < 0)
            {
                Console.WriteLine("Price cannot be less than 0");
                return;
            }
            WholePart = totalCents / 100;
            Kopeyks = totalCents % 100;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"Product: {Name}");
            Print();
        }
    }

}
