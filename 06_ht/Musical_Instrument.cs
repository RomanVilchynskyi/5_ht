using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ht
{
    public class Musical_Instrument
    {
        public string Name { get; set; }
        public string Characteristics { get; set; }

        public Musical_Instrument(string name, string characteristics)
        {
            Name = name;
            Characteristics = characteristics;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Musical instrument sound");
        }

        public void Show()
        {
            Console.WriteLine($"Name: {Name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Characteristics: {Characteristics}");
        }

        public virtual void History()
        {
            Console.WriteLine("No history");
        }
    }

    public class Violin : Musical_Instrument
    {
        public Violin(string name, string characteristics) : base(name, characteristics) { }

        public override void Sound()
        {
            Console.WriteLine("Violin sound");
        }

        public override void History()
        {
            Console.WriteLine("Violin originates in 16 century in Italy");
        }
    }

    public class Trombone : Musical_Instrument
    {
        public Trombone(string name, string characteristics) : base(name, characteristics) { }

        public override void Sound()
        {
            Console.WriteLine("Trombone sound");
        }

        public override void History()
        {
            Console.WriteLine("Trombone developed during the Renaissance");
        }
    }

    public class Ukulele : Musical_Instrument
    {
        public Ukulele(string name, string characteristics) : base(name, characteristics) { }

        public override void Sound()
        {
            Console.WriteLine("Ukulele sound");
        }

        public override void History()
        {
            Console.WriteLine("Ukulele was made in 19 centure on Hawayas");
        }
    }

    public class Cello : Musical_Instrument
    {
        public Cello(string name, string characteristics) : base(name, characteristics) { }

        public override void Sound()
        {
            Console.WriteLine("Cello sound");
        }

        public override void History()
        {
            Console.WriteLine("Cello appeared in 16 century");
        }
    }

}
