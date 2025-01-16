internal class Program
{
    delegate bool NumDeleg(int number); 
    delegate void Print();
    delegate double CalcArea(double a, double b, double c);
    private static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Even numbers: " + string.Join(", ", FilterArray(arr, IsEven)));
        Console.WriteLine("Odd numbers: " + string.Join(", ", FilterArray(arr, IsOdd)));
        Console.WriteLine("Prime numbers: " + string.Join(", ", FilterArray(arr, IsPrime)));

        Print time = cur_time;
        Print date = cur_date;
        Print dayOfWeek = cur_day_of_week;

        CalcArea triangleArea = CalcTriangleArea;
        CalcArea rectangleArea = (a, b, _) => a * b;

        time();
        date();
        dayOfWeek();

        Console.WriteLine($"Triangle area: {triangleArea(3, 4, 5)}");
        Console.WriteLine($"Rectangle area: {rectangleArea(5, 10, 0)}");

        static void cur_time() => Console.WriteLine($"Current time: {DateTime.Now:T}");

        static void cur_date() => Console.WriteLine($"Current date: {DateTime.Now:d}");

        static void cur_day_of_week() => Console.WriteLine($"current day of week: {DateTime.Now.DayOfWeek}");
    }

    static List<int> FilterArray(int[] arr_, NumDeleg pred)
    {
        List<int> res = new List<int>();
        foreach (int number in arr_)
        {
            if (pred(number))
            {
                res.Add(number);
            }
        }
        return res;
    }

    static bool IsEven(int number) => number % 2 == 0;
    static bool IsOdd(int number) => number % 2 != 0;

    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
            if (number % i == 0)
                return false;
        return true;
    }


    

    static double CalcTriangleArea(double a, double b, double c)
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

}