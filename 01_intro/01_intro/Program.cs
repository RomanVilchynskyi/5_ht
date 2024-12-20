using System.Diagnostics;
using System.Security.Cryptography;

internal class Program
{
    static void TaskConsole()
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.CursorTop = 11;
        Console.CursorLeft = 20;
    }
    static void WriteLineWays()
    {
        int num = 10;
        double d = 12.1;
        decimal dd = 12.123m;
        float f = 213.23f;

        System.String line = "Hello";
        string str = "C# language is a popular language .NET";

        //way 1
        Console.WriteLine("Money :: " + dd + "\t fvalue :: " + f);

        //way 2
        Console.WriteLine("float value :: {0}; \t {0} \t {0} \t\t Sqrt = {1}", f, Math.Sqrt(f));

        //way 3
        Console.WriteLine($"money ::{dd}; number ^ 2 = {Math.Pow(num, 2)}");
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine(str);
    }
    static void ReadNumbers()
    {
        string num = Console.ReadLine();
        int res = Convert.ToInt32(num);
        res += 10;
        Console.WriteLine($"Result :: {res}");

        double ss = double.Parse(Console.ReadLine());
        ss++;
        Console.WriteLine($"Result :: {ss}");

        int result;
        if(int.TryParse(Console.ReadLine(), out result)) 
        {
            Console.WriteLine($"Result :: {result}");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
    private static void Main(string[] args)
    {
        /*TaskConsole();*/
        /*ReadChar(); */
        /*WriteLineWays();*/
        //ReadNumbers();

        //int day = Convert.ToInt32(Console.ReadLine());
        /*if(day == 1)
        {
            Console.WriteLine("Monday");
        }
        else if(day == 2)
        {
            Console.WriteLine("Tuesday");
        }
        else if(day == 3)
        {
            Console.WriteLine("Wednesday");
        }
        else
        {
            Console.WriteLine("Error");
        }*/

        /*switch(day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            default:
                Console.WriteLine("Error");
                break;
        }*/
        /*int i = 0;
        for(;;)
        {
            i++;
            Console.WriteLine(i + ".Hello");
            if(i == 5)
                break;
        }
        Console.WriteLine("End :: " + i);*/
        /*ConsoleKey key;
        while((key = Console.ReadKey().Key) != ConsoleKey.Escape)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("Press leftArrow");
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("Press rigthArrow");
                    break;
                case ConsoleKey.UpArrow:
                    Console.WriteLine("Press UpArrow");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("Press DownArrow");
                    break;
                default:
                    break;
            }

        }*/
        /*int res;
        do
        {
            Console.WriteLine("2 + 2 = ");
            res = int.Parse(Console.ReadLine());

        }while(res != 4);  */

        Console.WriteLine("It's easy to win forgiveness for being wrong;");
        Console.WriteLine("being right is what gets you into real trouble.");
        Console.WriteLine("Bjarne Stroustrup");

        Console.WriteLine("Enter 5 digits:");
        int sum = 0, product = 1;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Digit {i}: ");
            int number = int.Parse(Console.ReadLine());

            sum += number;
            product *= number;
        }

        Console.WriteLine($"\nSum: {sum}");
        Console.WriteLine($"Product: {product}");

        Console.Write("Enter: ");
        int num = int.Parse(Console.ReadLine());

        if (num >= 100000 && num <= 999999)
        {
            int reverse = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reverse = reverse * 10 + digit;
                num /= 10; 
            }

            Console.WriteLine($"Reverse number: {reverse}");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }

    static void ReadChar()
    {
        Console.Write("Enter symbol :: ");
        char symbol = (char)Console.Read();
        Console.WriteLine("Symbol \t :: " + symbol);
        Console.WriteLine("Isletter Symbol \t :: " + char.IsLetter(symbol));
        Console.WriteLine("IsUpper Symbol \t :: " + char.IsUpper(symbol));
        Console.WriteLine("IsDigit Symbol \t :: " + char.IsDigit(symbol));

    }
}