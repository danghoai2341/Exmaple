public class Program
{
    public static void Main()
    {
        try
        {
            int x = int.Parse("abc");
        }
        catch(FormatException e) 
        {
            Console.WriteLine($"eXception{e.Message}");
        };
        try
        {
            int[] arr = new int[12];
            Console.WriteLine(arr[13]);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine($"Out range{e.Message}");
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine($"Argument{e.Message}");
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine($"ArgumentOutrange{e.Message}");
        }
        finally
        {
            Console.WriteLine("Ket thuc");
        }
    }
}