using exampleGenericT;

// Define the missing Product class to fix CS0246
public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public override string ToString() => $"{Name}: ${Price}";
}

public class Program
{
    public static void Main(string[] args)
    {
        Repository<Product> repository = new Repository<Product>();
        repository.Add(new Product { Name = "Laptop", Price = 999.99 });
        repository.Add(new Product { Name = "Smartphone", Price = 499.99 });
        repository.Add(new Product { Name = "Tablet", Price = 299.99 });
        repository.Add(new Product { Name = "Smartwatch", Price = 199.99 });
        repository.Add(new Product { Name = "Headphones", Price = 99.99 });
        //
        foreach (var item in repository.GetAll())
        {
            Console.WriteLine(item);
        }
    }
}
