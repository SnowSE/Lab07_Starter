namespace Lab07.Logic;

public class Rectangle : AbstractGraphic2D
{
    public Rectangle(int v1, int v2, int v3, decimal v4)
    {
    }

    public override decimal LowerBoundX => -1;

    public override decimal UpperBoundX => -1;

    public override decimal LowerBoundY => -1;

    public override decimal UpperBoundY => -1;

    public override bool ContainsPoint(decimal x, decimal y)
    {
        return false;
    }
}