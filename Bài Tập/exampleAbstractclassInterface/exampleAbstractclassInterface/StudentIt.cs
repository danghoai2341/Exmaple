

public class StudentIt : Student, IEnglishComputer
{
    public string compute { get; set; }
    public StudentIt(string name, int age, string grade, string compute) : base(name, age, grade)
    {
        this.compute = compute;
    }

    public void ReadBookEnglish(string bookTitle)
    {
        Console.WriteLine($"Reading English book: {bookTitle}");
    }

    public void ReturnBookEnglish(string bookTitle)
    {
        Console.WriteLine($"Returning English book: {bookTitle}");
    }
}


