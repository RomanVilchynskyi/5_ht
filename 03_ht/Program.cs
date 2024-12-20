internal class Program
{
    static void Fill(double[,] arr)
    {
        Random rnd = new Random();
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = Math.Round(rnd.NextDouble() * 10, 1);
                Console.Write($"{arr[i, j],6} ");
            }
            Console.WriteLine();
        }
    }
    static void Fill2(int[,] arr)
    {
        Random rnd = new Random();
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = rnd.Next(-100, 100);
                Console.Write($"{arr[i, j],6} ");
            }
            Console.WriteLine();
        }
    }
    static void Print(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write($"{item,-10}");
        }
        Console.WriteLine();
    }

    static void PrintM(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j],4} ");
            }
            Console.WriteLine();
        }
    }
    private static void Main(string[] args)
    {
        /*int[] A = new int[5];
        double[,] B = new double[3, 4];
        Console.WriteLine("After you enter a digit press enter and do it 5 times:");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = ");
            A[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nArr A:");
        Print(A);

        Console.WriteLine("\nArr B:");
        Fill(B);

        double maxElement = A[0], minElement = A[0];
        foreach (var item in A)
        {
            if (item > maxElement)
                maxElement = item;
            if (item < minElement)
                minElement = item;
        }

        foreach (var item in B)
        {
            if (item > maxElement)
                maxElement = item;
            if (item < minElement)
                minElement = item;
        }

        double tsum = 0, tproduct = 1;
        foreach (var item in A)
        {
            tsum += item;
            tproduct *= item;
        }
        foreach (var item in B)
        {
            tsum += item;
            tproduct *= item;
        }
        int sumA = 0;
        foreach (var e in A)
        {
            if (e % 2 == 0)
                sumA += e;
        }

        double oddCol = 0;

        for (int q = 0; q < B.GetLength(1); q++)
        {
            if (q % 2 != 0)
            {
                for (int j = 0; j < B.GetLength(0); j++)
                {
                    oddCol += B[j, q];
                }
            }

        }

        Console.WriteLine($"\nMax element: {maxElement}");
        Console.WriteLine($"Min element: {minElement}");
        Console.WriteLine($"Total sum: {tsum}");
        Console.WriteLine($"Total product: {tproduct}");
        Console.WriteLine($"Sum of even elements in arr A: {sumA}");
        Console.WriteLine($"Sum of elements in odd columns of arr B: {oddCol}");*/

        /*int[,] arr = new int[5,5];
        Fill2(arr);

        int min = arr[0, 0];
        int max = arr[0, 0];

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] < min)
                    min = arr[i, j];
                if (arr[i, j] > max)
                    max = arr[i, j];
            }
        }

        Console.WriteLine($"\nМінімальний елемент: {min}");
        Console.WriteLine($"Максимальний елемент: {max}");*/
        int[,] matrix1 = { { 2, 2 }, { 3, 6 } };
        int[,] matrix2 = { { 1, 4 }, { 8, 5 } };
        int number = 2;

        Console.WriteLine("Print matrix1: ");
        PrintM(matrix1);
        Console.WriteLine("Print matrix2: ");
        PrintM(matrix2);

        Console.WriteLine($"\nMultiplication matrix 1 on {number}:");
        PrintM(MultiplyMN(matrix1, number));

        Console.WriteLine("\nAddition:");
        PrintM(AdditionM(matrix1, matrix2));

        Console.WriteLine("\nMultiplication:");
        PrintM(MultM(matrix1, matrix2));

    }
    static int[,] MultiplyMN(int[,] matrix, int number)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] res = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                res[i, j] = matrix[i, j] * number;
            }
        }
        return res;
    }

    static int[,] AdditionM(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        int[,] res = new int[rows, cols];

        for(int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                res[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return res;
    }

    static int[,] MultM(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        int[,] res = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                for (int q = 0; q < cols1; q++)
                {
                    res[i, j] += matrix1[i, q] * matrix2[q, j];
                }
            }
        }
        return res;
    }
}

