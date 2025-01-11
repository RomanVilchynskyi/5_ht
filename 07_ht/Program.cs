using _07_ht;
internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 2, 3, 6, 7, 8, 2 };
        Arr arr = new Arr(array);

        arr.Show("Array:");

        Console.WriteLine("Less than 5: " + arr.Less(5));
        Console.WriteLine("Greater than 5: " + arr.Greater(5));

        arr.ShowEven();
        arr.ShowOdd();

        Console.WriteLine("Count of distinct values: " + arr.CountDistinct());
        Console.WriteLine("Count of values equal to 2: " + arr.EqualToValue(2));
    }
}