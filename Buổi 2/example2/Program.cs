public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap so nguyen thu nhat: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so nguyen thu hai: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int tong = a + b;
        Console.WriteLine("Tong hai so la: " + tong);
    }
}