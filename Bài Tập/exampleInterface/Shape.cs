public class Shape
{
    private string color = "green";
    private bool filled = true;

    public Shape()
    {
    }

    public Shape(string color, bool filled)
    {
        this.color = color;
        this.filled = filled;
    }

    public string GetColor()
    {
        return color;
    }

    public bool IsFilled()
    {
        return filled;
    }
    public void SetFilled(bool filled)
    {
        this.filled = filled;
    }
    public void SetColor(string color)
    {
        this.color = color;
    }
    public override string ToString()
    { 
        return "Getcolor"+this.color+this.filled;
    }
}
