namespace Figure;

public class Circle : IFigure
{
    private double Radius { get;}

    public Circle(double radius)
    {
        Radius = radius;
    }
    
    public double Calculate()
    {
        return 3.14 * (Radius*Radius);
    }
}