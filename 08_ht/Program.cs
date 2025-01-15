using _08_ht;

internal class Program
{
    private static void Main(string[] args)
    {
        Vector3d arr1 = new Vector3d(2, 2, 2);
        arr1.FillArray((x, y, z) => x + y + z);

        Console.WriteLine("Arr 1:");
        arr1.Print();

        Vector3d arr2 = new Vector3d(2, 2, 2);
        arr2.FillArray((x, y, z) => x + y + z);

        Console.WriteLine("Arr 2:");
        arr2.Print();

        Vector3d ra = arr1.Add(arr2);
        Console.WriteLine("Addition:");
        ra.Print();

        Vector3d rs = arr1.Sub(arr2);
        Console.WriteLine("Subtraction:");
        rs.Print();

        Vector3d rm = arr1.MultByNum(2);
        Console.WriteLine("Multiplication:");
        rm.Print();
    }
}