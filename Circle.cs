namespace FigureSSS
{
    public class Circle : ICircle
    {
        private const double PI = Math.PI;

        /// <summary>
        /// Вычисляет площать круга по радиусу
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        

        public double CalculateArea(params double[] parameters)
        {
            if (parameters.Length != 1)
            {
                throw new ArgumentException("Circle requires 1 parameter (radius).");
            }

            double radius = parameters[0];

            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be a positive number.");
            }

            return PI * radius * radius;
        }
    }
}

