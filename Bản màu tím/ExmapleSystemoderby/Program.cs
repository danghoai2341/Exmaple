using System.Linq;

class Program
{
       static void Main(string[] args)
    {
       int[] numbers = { 1, 2, 3, 4, 5,7,8,3,7,5,1,10 };
        var sortedNumbers = numbers.OrderBy(n => n);
       foreach (var number in sortedNumbers)
        {
            Console.WriteLine(number);
        }
    }
}