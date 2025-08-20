public class Player : IDamagable , IDestroy
{
    private int health;

    public Player(int initialHealth)
    {
        health = initialHealth;
    }
    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health < 0) health = 0; // Ensure health doesn't go below 0
    }
    public void Dead()
    {
        if (health <= 0)
        {
            Console.WriteLine("Player is dead.");
        }
    }

    public void Destroy()
    {
        Console.WriteLine("Player destroyed.");
        health = 0;
    }

    public void Burn()
    {
        throw new NotImplementedException();
    }

    public int Health => health;
}
public class Program
{
    public static void Main(string[] args)
    {

        Player player = new Player(100);
        Console.WriteLine($"Initial Health: {player.Health}");
        player.TakeDamage(10);
        Console.WriteLine($"Health after taking damage: {player.Health}");
        player.TakeDamage(20);
        Console.WriteLine($"Health after taking more damage: {player.Health}");
        player.Destroy();
        Console.WriteLine($"Health after destroy: {player.Health}");
        player.Dead();
        Console.ReadLine();
    }
}
