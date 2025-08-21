//tinh dien tich hinh tron khi biet ban kinh

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap ban kinh hinh tron: ");
        double r = Convert.ToDouble(Console.ReadLine());
        double s = Math.PI * r * r;
        Console.WriteLine("Dien tich hinh tron la: " + s);
    }
}
        
