public class Program
{
    public static void Main(string[] args)
    {
        List<string> myList = new List<string> { };
        myList.Add("Orange");
        myList.Add("Banana");
        myList.Add("Apple");
        //
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }
        //
        for (var i = 0; i < myList.Count; i++)
        {
            Console.WriteLine(myList[i]);
        }
    }
}
