public abstract class BaseClass
{
    public abstract void AbstractMethod();
}
public class DerivedClass : BaseClass
    {
    public override void AbstractMethod()
    {
        // Implementation of the abstract method
        Console.WriteLine("Abstract method implemented in DerivedClass.");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Abstract Class Example");
    }
}
