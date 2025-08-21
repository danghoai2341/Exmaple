public class Program
{
    public static void Main(string[] args)
    {
        float width;
        float height;
        Console.WriteLine("Hay nhap gia tri cho chieu rong:");
        width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hay nhap gia tri cho chieu cao:");
        height = Convert.ToInt32(Console.ReadLine());
        float area = width * height;
        Console.WriteLine("Dien tich hinh chu nhat la: " + area);
    }
}
