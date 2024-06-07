namespace FigureSSS
{
    /// <summary>
    /// Вычисление площади фигуры без знания фигуры
    /// </summary>
    public class FigureFactory
    {
        public IShape CreateFigure(FigureType figureType)
        {
            switch (figureType)
            {
                case FigureType.Triangle:
                    return new Triangle();
                case FigureType.Circle:
                    return new Circle();
                default:
                    throw new ArgumentException("Invalid figure type.");
            }
        }
    }

    public enum FigureType
    {
        Triangle,
        Circle
    }
}
