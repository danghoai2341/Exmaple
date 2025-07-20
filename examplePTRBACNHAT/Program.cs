//giai phuong trinh bac nhat ax+b=0;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap gia tri a");
        Double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap gia tri b");
        Double b = Convert.ToDouble(Console.ReadLine());
        //
        if(a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Phuong trinh vo so nghiem");
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
        }
        else
        {
            Double x = -b / a;
            Console.WriteLine($"phuong trinh co nghiem la {x}");
        }
    }
}
