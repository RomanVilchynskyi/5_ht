using _10_ht;

internal class Program
{
    private static void Main(string[] args)
    {
        Race race = new Race();

        race.AddCar(new SportsCar("Sports car"));
        race.AddCar(new PassengerCar("Passenger car"));
        race.AddCar(new Truck("Truck"));
        race.AddCar(new Bus("Bus"));

        Console.WriteLine("Race started!");
        race.StartRace();
    }
}