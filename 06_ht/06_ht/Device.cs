using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ht
{
    public class Device
    {
        public string Name { get; set; }
        public string Characteristics { get; set; }

        public Device(string name, string characteristics)
        {
            Name = name;
            Characteristics = characteristics;
        }

        public virtual void Sound()
        {
            Console.WriteLine("sound");
        }

        public void Show()
        {
            Console.WriteLine($"Name: {Name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Characteristics: {Characteristics}");
        }
    }

    public class Kettle : Device
    {
        public Kettle(string name, string characteristics) 
            : base(name, characteristics) { }

        public override void Sound()
        {
            Console.WriteLine("kettle sound");
        }
    }

    public class Microwave : Device
    {
        public Microwave(string name, string characteristics) 
            : base(name, characteristics) { }

        public override void Sound()
        {
            Console.WriteLine("Microwave sound");
        }
    }

    public class Car : Device
    {
        public Car(string name, string characteristics) 
            : base(name, characteristics) { }

        public override void Sound()
        {
            Console.WriteLine("Car sound");
        }
    }

    public class Steamship : Device
    {
        public Steamship(string name, string characteristics) 
            : base(name, characteristics) { }

        public override void Sound()
        {
            Console.WriteLine("Streamship sound");
        }
    }
}
