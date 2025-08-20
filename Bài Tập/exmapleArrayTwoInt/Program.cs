public class Program
{
    public static void Main(string[] args)
    {
        int[,] matrix = new int[4, 3]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },
            { 10, 11, 12 }
        };
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            int sum = 0;
            for (var k= 0; k < matrix.GetLength(0); k++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[k, j];
                }
            }
            Console.WriteLine("\nSum of all elements: " + sum);
            //
            int sum2 = 0;
            for (var k = 0; k < matrix.GetLength(0); k++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    if (k == j) sum2 += matrix[k, j];
                }
            }
            Console.WriteLine("\nSum of all elements: " + sum2);
        }
        //
        int max = matrix[0, 0];
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                }
            }
        }
        Console.WriteLine("\nMaximum element: " + max);
    }
}
