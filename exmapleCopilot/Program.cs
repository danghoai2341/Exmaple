class Program
{
    static void Main()
    {
        int rows = 4;
        int cols = 3;
        int[,] arr = new int[rows, cols];
        Random rand = new Random();

        // Khởi tạo mảng với giá trị ngẫu nhiên từ 0 đến 100
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr[i, j] = rand.Next(0, 101);
            }
        }

        // Hiển thị mảng
        Console.WriteLine("Ma trận 4x3 với các phần tử ngẫu nhiên:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Tính tổng các phần tử trong mảng
        int sum = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sum += arr[i, j];
            }
        }

        Console.WriteLine($"Tổng các phần tử trong mảng là: {sum}");
    }
}
