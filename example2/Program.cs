// tinh dien tich hinh tron

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap ban kinh hinh tron");
        double r = Convert.ToDouble(Console.ReadLine());
        double s = Math.PI * r * r;
      Console.WriteLine("Dien tich la" + s);
    }
}