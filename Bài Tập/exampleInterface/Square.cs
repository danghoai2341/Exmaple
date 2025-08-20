public class Square : Rectangle
{
    public Square()
    {
    }
    public Square(double side) : base(side, side)
    {
    }
    public Square(double side, string color, bool filled) : base(side, side, color, filled)
    {
    }
    public void SetSize(double side)
    {
        base.SetHeight(side);
        base.SetWidth(side);
    }
    public override void SetHeight(double height)
    {
        SetSize(height);
    }
    public override void SetWidth(double width)
    {
        SetSize(width);
    }
}
