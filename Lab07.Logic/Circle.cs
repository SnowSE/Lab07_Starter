namespace Lab07.Logic;

public class Circle : AbstractGraphic2D
{
    public Circle(decimal d1, decimal d2, decimal d3)
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
