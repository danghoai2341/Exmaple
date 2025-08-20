 public class Program
 
{
    static Dictionary<char, int> CountCharacters(string input)
    {
        Dictionary<char, int> characterCount = new Dictionary<char, int>();
        foreach (char c in input)
        {
            if (characterCount.ContainsKey(c))
            {
                characterCount[c]++;
            }
            else
            {
                characterCount[c] = 1;
            }

        }
    }
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Input Sting");
        string input = System.Console.ReadLine();
        Dictionary<char, int> result = CountCharacters(input);

        System.Console.WriteLine("Character counts:");
        foreach (var pair in result)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}