namespace Figure;

public static class FigureFactory
{
    public static IFigure CreateFigure(string figureType, params double[] parameters)
    {
        switch (figureType)
        {
            case "Circle":
                if (parameters.Length != 1)
                    throw new ArgumentException("Для круга требуется один параметр: радиус");
                return new Circle(parameters[0]);
            case "Triangle":
                if (parameters.Length != 3)
                    throw new ArgumentException("Треугольник требует три параметра: a, b, c");
                return new Triangle(parameters[0], parameters[1], parameters[2]);
            default:
                throw new ArgumentException("Не правильный тип фигуры");
        }
    }
    
}