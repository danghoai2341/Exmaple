public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary.Add("key1", "Book");
        dictionary.Add("key2", "Pen");
        dictionary.Add("key3", "Notebook");
        dictionary.Add("key4", "Eraser");
        //
        foreach (var item in dictionary.Keys)
        {
            Console.WriteLine(item);
        }
        //
        foreach (var item in dictionary.Values)
        {
            Console.WriteLine(item);
        }
        //
        Console.WriteLine(dictionary["key1"]);
    }
}