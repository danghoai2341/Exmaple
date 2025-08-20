public class ComparableCircle : Circle, IComparable<ComparableCircle>
{
    public ComparableCircle() : base()
    {
    }
    public ComparableCircle(double radius) : base(radius)
    {
    }
    public ComparableCircle(double radius, string color, bool filled) : base(radius, color, filled)
    {
    }
    public int CompareTo(ComparableCircle? other)
    {
        if (GetRadius() > other.GetRadius())
            return 1;
        else if (GetRadius() < other.GetRadius())
            return -1;
        else
            return 0;
    }
}