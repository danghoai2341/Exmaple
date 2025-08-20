public class Program
{
    public static void Main(string[] args)
    {
        string[] student = { "John", "Jane", "Doe", "Alice", "Bob" };
        Console.WriteLine("Ban hay nhap vao mot cai ten");
        string inputName = Console.ReadLine();
        bool isExit = false;
        for (var i = 0; i < student.Length; i++)
        {
            if (student[i].Equals(inputName))
            {
                Console.WriteLine($"Co ten do trong mang cos vi tri la {i} ");
                isExit = true;
                break;
            }
        }
        if (!isExit)
        {
            Console.WriteLine("Khong co ten do trong mang");
        }
    }
}