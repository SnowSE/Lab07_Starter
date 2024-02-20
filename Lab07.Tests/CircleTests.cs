using Lab07.Logic;

namespace Lab07.Tests;

public class CircleTests
{
    Circle circle;
    AbstractGraphic2D shape;

    public CircleTests()
    {
        // should be x, y, and radius
        circle = new Circle(8, 10, 2);

        // should extend the abstract class
        shape = circle;
    }

    [Fact]
    public void CircleHasCorrectDimensions()
    {
        Assert.Equal(8, circle.CenterX);
        Assert.Equal(10, circle.CenterY);
        Assert.Equal(2, circle.Radius);
    }

    [Fact]
    public void HasCorrectBoundingBox()
    {
        Assert.Equal(8 - 2, shape.LowerBoundX);
        Assert.Equal(10 - 2, shape.LowerBoundY);
        Assert.Equal(8 + 2, shape.UpperBoundX);
        Assert.Equal(10 + 2, shape.UpperBoundY);
    }

    [Fact]
    public void CenterIsIncluded()
    {
        Assert.True(shape.ContainsPoint(8, 10));
    }

    [Fact]
    public void ContainsAllFourPointsOfTheCompass()
    {
        Assert.True(shape.ContainsPoint(8 - 2, 10));
        Assert.True(shape.ContainsPoint(8 + 2, 10));
        Assert.True(shape.ContainsPoint(8, 10 - 2));
        Assert.True(shape.ContainsPoint(8, 10 + 2));
    }

    [Fact]
    public void ShouldNotContainFourCorners()
    {
        Assert.False(shape.ContainsPoint(8 - 2, 10 - 2));
        Assert.False(shape.ContainsPoint(8 + 2, 10 - 2));
        Assert.False(shape.ContainsPoint(8 - 2, 10 + 2));
        Assert.False(shape.ContainsPoint(8 + 2, 10 + 2));
    }
}
