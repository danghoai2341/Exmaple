class Program
{
    // Hàm tìm giá trị nhỏ nhất trong mảng
    static int TimGiaTriNhoNhat(int[] arr)
    {
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
                min = arr[i];
        }
        return min;
    }

    static void Main(string[] args)
    {
        int[] mang = { 5, 2, 8, 1, 9, 3 };
        int giaTriNhoNhat = TimGiaTriNhoNhat(mang);
        Console.WriteLine("Giá trị nhỏ nhất trong mảng là: " + giaTriNhoNhat);
    }
}