using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ht
{
    abstract class Car
    {
        public string Name { get; }
        public int Speed { get; set; }
        public int Position { get; set; }
        public event Action<Car> Finish;

        public Car(string name)
        {
            Name = name;
            Position = 0;
        }

        public void Move()
        {
            Position += Speed;
            if (Position >= 100)
            {
                Position = 100;
                Finish?.Invoke(this);
            }
        }

        public abstract void UpdateSpeed();
    }
}
