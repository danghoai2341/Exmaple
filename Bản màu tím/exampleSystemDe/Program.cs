class Program
{
    static void Main(string[] args)
    {
        int[] arrays = {1,2,5,7,3,4,6,8,9,10};
        var sortedArray = arrays.OrderByDescending(n => n);
        foreach (var item in sortedArray)
        {
            Console.WriteLine(item);
        }
    }
}