using AreaLib.Figures;

namespace AreaLib.Tests;

public class TriangleTests
{
    [Test]
    [TestCase(3, 4, 5, true)]
    [TestCase(3, 4, 6, false)]
    public void TestIsRight(double a, double b, double c, bool expected)
    {
        // Arrange
        var circle = new Triangle();
        circle.SetParameters(a, b, c);

        // Act
        var result = circle.IsRight();

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}