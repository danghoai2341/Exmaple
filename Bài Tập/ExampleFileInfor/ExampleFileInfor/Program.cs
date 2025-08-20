public class Program
{
    public static void Main(string[] args)
    {
        string filePath = "D:\\FileNew";
        DirectoryInfo directoryInfo = new DirectoryInfo(filePath);
        directoryInfo.Create();
    }
}