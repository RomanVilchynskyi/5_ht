using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ht
{
    class Race
    {
        private List<Car> cars = new List<Car>();

        public void AddCar(Car car)
        {
            car.Finish += AnnounceWinner;
            cars.Add(car);
        }

        public void StartRace()
        {
            bool raceFinished = false;

            while (!raceFinished)
            {
                foreach (var car in cars)
                {
                    car.UpdateSpeed();
                    car.Move();
                    Console.WriteLine($"{car.Name} is on position {car.Position} with speed {car.Speed}");

                    if (car.Position >= 100)
                    {
                        raceFinished = true;
                    }
                }

                Console.WriteLine(new string('-', 50));
            }
        }

        private void AnnounceWinner(Car car)
        {
            Console.WriteLine($"Winner: {car.Name}, reach the finish!");
        }
    }
}
