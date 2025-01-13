using _08_ht;

internal class Program
{
    private static void Main(string[] args)
    {
        Vector3d vector1 = new Vector3d(2, 3, 4);
        Vector3d vector2 = new Vector3d(1, 1, 1);

        Vector3d mv = vector1.MultByNum(2);
        Console.WriteLine($"Multiplication: {mv}");

        Vector3d av = vector1.Add(vector2);
        Console.WriteLine($"Addition: {av}");

        Vector3d sv = vector1.Sub(vector2);
        Console.WriteLine($"Subtraction: {sv}");
    }
}