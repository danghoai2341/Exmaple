public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int maxNumber = Max(numbers);
        System.Console.WriteLine($"The maximum number is: {maxNumber}");
    }
    static int Max(int[] arr)
    {
        if (arr == null || arr.Length == 0)
            return 0;
        int max = arr[0];
        foreach (int num in arr)
        {
            if (num > max)
                max = num;
        }
        return max;
    }

}