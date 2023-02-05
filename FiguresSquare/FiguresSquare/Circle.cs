using System;

namespace FiguresSquare
{
    public class Circle : IFigure

    {
        private const float PI = 3.14F;
        private float _radius
        {

            set
            {
                if (value <= 0)
                {
                    _radius = 1;
                    Console.WriteLine("Radius most be greater than to 0");
                }

                else
                {
                    _radius = value;
                }
            }

            get
            {
                return _radius;
            }

        }

        public Circle(float radius)
        {
            _radius = radius;
        }

        public float CalculateSquare()
        {
            float _square = PI * (float)Math.Pow(_radius, 2);
            Math.Round(_square, 1);

            return (_square);
        }
    }

}
