namespace FigureSSS
{
    public class Triangle : ITriangle
    {
        public double CalculateArea(params double[] parameters)
        {
            if (parameters.Length != 3)
            {
                throw new ArgumentException("Ошибка параметров сторон треугольника");
            }

            double a = parameters[0];
            double b = parameters[1];
            double c = parameters[2];

            if (!IsValidTriangle(a, b, c))
            {
                throw new ArgumentException("Ошибка параметров сторон треугольника!");
            }

            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool CalculateRightAngle(params double[] parameters)
        {
            if (parameters.Length != 3)
            {
                throw new ArgumentException("Ошибка параметров сторон треугольника");
            }

            double a = parameters[0];
            double b = parameters[1];
            double c = parameters[2];

            return (a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a);
        }

        public bool IsRightAngled(double a, double b, double c)
        {
            throw new NotImplementedException();
        }

        private bool IsValidTriangle(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 && (a + b > c && b + c > a && a + c > b);
        }
    }
}