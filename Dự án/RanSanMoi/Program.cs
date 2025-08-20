using System.Globalization;

public class Program
{
    const int width = 30;
    const int height = 30; 
    static char[,] screen = new char[width, height];
    static int[] x = new int[50];
    static int[] y = new int[50];
    static int fruitX, fruitY;
    static int tall;
    static bool gameOver;
    static int score;
    static ConsoleKeyInfo keyInfo=new ConsoleKeyInfo();

    static void Setup()
    {
        gameOver = false;
        Random rand= new Random();
        fruitX = rand.Next(1, width);
        fruitY = rand.Next(1, height);
        x[0]= width / 2;
        y[0] = height / 2;    
        tall = 0;
        score = 0;
    }
    static void Draw()
    {
        Console.Clear();
        // Vẽ màn hình game
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                {
                    screen[i, j] = '#';
                }
                else
                {
                    screen[i, j] = ' ';
                }
            }
        }
        screen[y[0], x[0]] = 'O'; // Vẽ đầu rắn
        screen[fruitY, fruitX] = 'F'; // Vẽ quả
        for (int k = 1; k < tall; k++)
        {
            screen[y[k], x[k]] = 'O'; // Vẽ thân rắn
        }
        for (int i = 0; i < height; i++)
        {
            for (int j=0; j<width; j++)
            {
                Console.Write(screen[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Score: " + score);
        Console.WriteLine("Press 'W', 'A', 'S', 'D' to move, 'Q' to quit.");
    }
    static void Input()
    {
        if (Console.KeyAvailable)
        {
            if (Console.KeyAvailable)
                keyInfo = Console.ReadKey(true);
        }
    }
         static void Logic()
        {
            Thread.Sleep(500);
            if (keyInfo.Key == ConsoleKey.RightArrow)
                x[0]++;
            if (keyInfo.Key == ConsoleKey.LeftArrow)
                x[0]--;
            if (keyInfo.Key == ConsoleKey.UpArrow)
                y[0]--;
            if (keyInfo.Key == ConsoleKey.DownArrow)
                y[0]++;
            if (keyInfo.Key == ConsoleKey.Q)
                gameOver = true;
            Console.WriteLine(" ");
            if (x[0] == fruitX && y[0] == fruitY)
            {
                Random rand = new Random();
                fruitX = rand.Next(1, width);
                fruitY = rand.Next(1, height);
                tall++;
                score++;
            }
            if (tall == 3)
            {
                Setup();
            }
            if (x[0] >= width || x[0] < 0 || y[0] >= height || y[0] < 0)
                gameOver = true;
            for (int i = 1; i < tall; i++)
            {
                if (x[i] == x[0] && y[1] == y[0])
                    gameOver = true;
            }
        
    }
            static void Main(string[] args)
        {
            Setup();
            while (!gameOver)
            {
                Draw();
                Input();
                Logic();
            }
            Console.Clear();
            Console.WriteLine("Game Over! Your score: " + score);
        }
}
