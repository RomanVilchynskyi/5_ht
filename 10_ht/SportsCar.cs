using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ht
{
    class SportsCar:Car
    {
        private static Random rnd = new Random();
        public SportsCar(string name) 
            : base(name) { }

        public override void UpdateSpeed()
        {
            Speed = rnd.Next(10, 21); 
        }
    }

    class PassengerCar : Car
    {
        private static Random rnd = new Random();
        public PassengerCar(string name) 
            : base(name) { }

        public override void UpdateSpeed()
        {
            Speed = rnd.Next(5, 16); 
        }
    }

    class Truck : Car
    {
        private static Random rnd = new Random();
        public Truck(string name) 
            : base(name) { }

        public override void UpdateSpeed()
        {
            Speed = rnd.Next(3, 11); 
        }
    }

    class Bus : Car
    {
        private static Random rnd = new Random();
        public Bus(string name) 
            : base(name) { }

        public override void UpdateSpeed()
        {
            Speed = rnd.Next(4, 13); 
        }
    }
}
