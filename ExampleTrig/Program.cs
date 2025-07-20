//nhap 3 so a,b,c kiem tra xem 3 so da nhap co thoa man la hinh tam giac hay khong
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap gia tri a");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap gia tri b");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap gia tri c");
        int c = Convert.ToInt32(Console.ReadLine());
        if (a > 0 && b > 0 && c > 0)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("La canh cua tam giac");
            }
            else
            {
            Console.WriteLine("khong phai canh cua tam giac");
           }      
        }
        else
        {
            Console.WriteLine("Do dai cac canh phai lon hon 0");
        }
    }
}