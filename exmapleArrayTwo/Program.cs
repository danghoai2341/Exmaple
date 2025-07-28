public class Program
{
    public static void Main(string[] args)
    {
        string[,] myarray = { { "Ha noi", "HCM", "Da Nang", "Hai Phong" },
        { "Can Tho", "Nha Trang", "Hue", "Vinh"},
        { "Bac Ninh", "Bac Giang", "Thai Nguyen", "Quang Ninh" }};
        Console.WriteLine("Array Length:" + myarray.GetLength(0));
        Console.WriteLine("Array Length:" + myarray.GetLength(1));

    }
}
