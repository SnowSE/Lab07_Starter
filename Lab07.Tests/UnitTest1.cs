using Lab07.Logic;

namespace Lab07.Tests;


public class RectangleTests
{
    Rectangle rectangle;
    AbstractGraphic2D shape;

    public void RectangleTests()
    {
        rectangle = new Rectangle(3, 4, 5, 6);
        shape = rectangle;
    }

    [Fact]
    public void EnsurePropertiesAreCorrect()
    {
        Assert.Equal(3, rectangle.Left);
        Assert.Equal(4, rectangle.Top);
        Assert.Equal(5, rectangle.Width);
        Assert.Equal(6, rectangle.Height);
    }

    [Fact]
    public void CheckLowerBounds()
    {
        // lower bound is the smallest x that needs to be checked when drawing the shape
        Assert.Equal(3, shape.LowerBoundX);
        Assert.Equal(4, shape.LowerBoundY);
    }

    [Fact]
    public void CheckUpperBounds()
    {
        // upper bound is the largest x that needs to be checked when drawing the shape
        Assert.Equal(3 + 5, shape.UpperBoundX);
        Assert.Equal(4 + 6, shape.UpperBoundY);
    }

    [Fact]
    public void MiddleOfShapeIsIncluded()
    {
        Assert.True(shape.ContainsPoint(5.5m, 7));
    }

    [Theory]
    [InlineData(3, 4, true)]
    [InlineData(8, 4, true)]
    [InlineData(3, 10, true)]
    [InlineData(8, 10, true)]
    [InlineData(3 - 0.1, 4, false)]
    [InlineData(8, 4 - 0.1, false)]
    [InlineData(3, 10 + 0.1, false)]
    [InlineData(8 + 0.1, 10, false)]
    public void CornersIncluded(decimal x, decimal y, bool isContained)
    {
        Assert.Equal(isContained, shape.ContainsPoint(x, y));
    }
}