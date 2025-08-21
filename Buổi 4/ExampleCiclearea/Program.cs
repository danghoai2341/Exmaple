//nhap ban kinh hinh tron va tinh dien tich chu vi

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Nhap ban kinh hinh tron: ");
        Double r = Convert.ToDouble(Console.ReadLine());
        Double area = Math.PI * r * r;
        Double pre = 2 * Math.PI * r;
        Console.WriteLine($"Chu vi la: {pre}");
        Console.WriteLine($"Dien tich la: {area}");
    }
}