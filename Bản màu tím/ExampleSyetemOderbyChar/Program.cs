using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Duy", "An", "Binh", "Cuong", "Anh", "Bao" };

        // Sắp xếp tên theo thứ tự bảng chữ cái
        var sortedNames = names.OrderBy(name => name).ToArray();

        Console.WriteLine("Danh sách tên sau khi sắp xếp:");
        foreach (var name in sortedNames)
        {
            Console.WriteLine(name);
        }
    }
}