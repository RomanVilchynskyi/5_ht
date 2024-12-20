internal class Program
{
    static void task2()
    {
        Console.Write("Enter A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Enter B: ");
        int B = int.Parse(Console.ReadLine());

        if (A >= B)
        {
            Console.WriteLine("A must be smaller than B");
            return;
        }

        for (int i = A; i <= B; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
    static void task3()
    {
        int spaceCount = 0, digitCount = 0, letterCount = 0, otherCount = 0;

        Console.WriteLine("Enter symbols: ");

        while(true)
        {
            int input = Console.Read();
            char symbol = (char)input;

            if (symbol == '.')
                break;

            if (char.IsWhiteSpace(symbol))
                spaceCount++;
            else if (char.IsDigit(symbol))
                digitCount++;
            else if (char.IsLetter(symbol))
                letterCount++;
            else
                otherCount++;
        }

        Console.WriteLine($"Spaces: {spaceCount}");
        Console.WriteLine($"Digits: {digitCount}");
        Console.WriteLine($"Letters: {letterCount}");
        Console.WriteLine($"Other symbols: {otherCount}");
    }
    static void task4()
    {
        Console.WriteLine("Enter: ");
        string input = Console.ReadLine();
        string result = "";

        foreach (char i in input)
        {
            if (char.IsLower(i))
                result += char.ToUpper(i);
            else if (char.IsUpper(i))
                result += char.ToLower(i);
            else
                result += i;
        }

        Console.WriteLine("Result: " + result);

    }
    private static void Main(string[] args)
    {
        /*Console.Write("Enter position: ");
        string position = Console.ReadLine();

        Console.Write("Enter the amount of hours: ");
        int hours = int.Parse(Console.ReadLine());

        double rate = 0;

        switch (position.ToLower())
        {
            case "maneger":
                rate = 50; 
                break;
            case "programmer":
                rate = 80; 
                break;
            case "librarian":
                rate = 30; 
                break;
            default:
                Console.WriteLine("Error");
                return;
        }

        double salary = rate * hours;
        Console.WriteLine($"Worker's salary: {salary} grn");*/

        //task2();
        //task3();
        task4();
    }
}