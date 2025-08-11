using System.Text.RegularExpressions;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Score { get; set; }
}
public class Program
{
    public static void Main(string[] args)
    {
        var students = new List<Student>
        {
            new Student { Name = "Tham", Age = 20, Score = 8 },
            new Student { Name = "Khanh", Age = 22, Score = 9 },
            new Student { Name = "Tuan", Age = 21, Score = 7 },
            new Student { Name = "Nam", Age = 23, Score = 10 },
            new Student { Name = "Hanh", Age = 19, Score = 6 },
            new Student { Name = "Linh", Age = 24, Score = 5 },
            new Student { Name = "An", Age = 18, Score = 4 },
            new Student { Name = "Binh", Age = 25, Score = 3 }
        };
        var group = students.GroupBy(s =>
        {
            if (s.Score > 8) return "A";
            else if (s.Score > 6.5) return "B";
            else if (s.Score > 4) return "C";
            else return "D";
        });
        foreach (var g in group)
        {
            Console.WriteLine($"Group{g.Key}");
            foreach (var student in g)
            {
                Console.WriteLine($"- {student.Name}, Age: {student.Age}, Score: {student.Score}");
            }
        }
    }
}

