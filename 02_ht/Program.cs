using System.Linq;
internal class Program
{
    static int[] CreateArr(int size)
    {
        return new int[size];
    }
    static void FillRandArr(int[] arr, int left = 0, int right = 100)
    {
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(left, right);
        }
    }
    static void print(int[] arr)
    {
        Console.WriteLine("Print all");
        foreach (var item in arr)
        {
            Console.Write($"{item,-10}");
        }
        Console.WriteLine();
    }
   
    static int FPositive(int[] arr)
    {
        foreach (var item in arr)
        {
            if(item > 0)
            {
                return item;
            }
        }
        return 0;
    }
    static int countEvenElements(int[] arr)
    {
        return arr.Count(x => x % 2 == 0);
    }
    static int FindIndex(int[] arr)
    {
        return Array.FindIndex(arr, x => x % 7 == 0);
    }
    private static void Main(string[] args)
    {

        int[] arr = CreateArr(10);
        FillRandArr(arr, -15, 15);

        Console.WriteLine("Original array:");
        print(arr);

        Console.WriteLine("\nFirst positive number:");
        Console.WriteLine(FPositive(arr));

        Console.WriteLine("\nCount of even elements:");
        Console.WriteLine(countEvenElements(arr));

        Console.WriteLine("\nIndex of first multiple of 7:");
        Console.WriteLine(FindIndex(arr));
    }
}