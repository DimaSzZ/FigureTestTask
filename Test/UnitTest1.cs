using Figure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace Test;

public class Tests
{
    [TestMethod]
    public void TestCircle()
    {
        double radius = 2.0;
        double expectedArea = Math.PI * radius * radius;
        Circle circle = new Circle(radius);
        double actualArea = circle.Calculate();
        Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.001));
    }

    [TestMethod]
    public void TestTriangle()
    {
        double a = 3.0;
        double b = 4.0;
        double c = 5.0;
        double s = (a + b + c) / 2;
        double expectedArea = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        Triangle triangle = new Triangle(a, b, c);
        double actualArea = triangle.Calculate();
        Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.001));
    }
    [TestMethod]
    public void TestRightTriangle()
    {
        double a = 3.0;
        double b = 4.0;
        double c = 5.0;
        Triangle triangle = new Triangle(a, b, c);
        bool isRightTriangle = triangle.IsRightTriangle();
        Assert.IsTrue(isRightTriangle);
    }
}