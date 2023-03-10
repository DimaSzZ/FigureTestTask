namespace Figure;

public class Triangle : IFigure
{
    private double First { get;}
    private double Second { get;}
    private double Third { get;}

    public Triangle(double first,double second, double third)
    {
        First = first;
        Second = second;
        Third = third;
    }
    public double Calculate()
    {
        var p = (First + Second + Third) / 2;
        return Math.Sqrt(p*(p*First)*(p*Second)*(p*Third));
    }
    public bool IsRightTriangle()
    {
        return First * First + Second * Second == Third * Third |
               First * First + Third * Third == Second * Second |
               Second * Second + Third *Third == First * First;
    }
}