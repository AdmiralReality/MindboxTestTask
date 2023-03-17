using AreaLib.Figures;

namespace AreaLib.Tests;

public class FiguresTests
{
    [Test]
    [TestCase(3, 28.27)]
    public void TestCircle(double radius, double expected)
    {
        // Arrange
        var circle = new Circle();
        circle.SetParameters(radius);

        // Act
        var area = Math.Round(circle.GetArea(), 2);

        //Assert
        Assert.That(area, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(3, 4, 5, 6)]
    public void TestRectangle(double a, double b, double c, double expected)
    {
        // Arrange
        var circle = new Triangle();
        circle.SetParameters(a, b, c);

        // Act
        var area = Math.Round(circle.GetArea(), 2);

        //Assert
        Assert.That(area, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(2, 1, 2, 4, 6, 1, 6)]
    public void TestTrianglePolygon(double x1, double y1, double x2, double y2, double x3, double y3, double expected)
    {
        // Arrange
        var circle = new Polygon();
        circle.SetParameters(x1, y1, x2, y2, x3, y3);

        // Act
        var area = Math.Round(circle.GetArea(), 2);

        //Assert
        Assert.That(area, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(2, 1, 2, 4, 6, 4, 6, 1, 12)]
    public void TestTrianglePolygon(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, double expected)
    {
        // Arrange
        var circle = new Polygon();
        circle.SetParameters(x1, y1, x2, y2, x3, y3, x4, y4);

        // Act
        var area = Math.Round(circle.GetArea(), 2);

        //Assert
        Assert.That(area, Is.EqualTo(expected));
    }
}