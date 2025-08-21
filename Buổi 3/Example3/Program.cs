public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("nhap ho ten: ");
        string hoTen = Console.ReadLine();
        Console.WriteLine("nhap tuoi: ");
        int tuoi = Convert.ToInt32(Console.ReadLine());
        //
        Console.WriteLine($"Ho ten: {hoTen}, Tuoi:{tuoi} ");
    }
}
