
using System;

namespace FiguresSquare
{
    public class Triangle : IFigure
    {
        private float _side_1
        {
            set
            {
                if (value <= 0)
                {
                    _side_1 = 1;
                    Console.WriteLine("Side most be greater than to 0");
                }

                else
                {
                    _side_1 = value;
                }

            }

            get
            {
                return _side_1;
            }
        }

        private float _side_2
        {
            set
            {
                if (value <= 0)
                {
                    _side_2 = 1;
                    Console.WriteLine("Side most be greater than to 0");
                }

                else
                {
                    _side_2 = value;
                }

            }

            get
            {
                return _side_2;
            }
        }
        private float _side_3
        {
            set
            {
                if (value <= 0)
                {
                    _side_3 = 1;
                    Console.WriteLine("Side most be greater than to 0");
                }

                else
                {
                    _side_3 = value;
                }

            }

            get
            {
                return _side_3;
            }
        }

        public Triangle(float side_1, float side_2, float side_3)
        {
            _side_1 = side_1;
            _side_2 = side_2;
            _side_3 = side_3;
        }

        public float CalculateSquare()
        {
            float _semiPerimeter = (_side_1 + _side_2 + _side_3) / 2;
            float _square = (float)(Math.Sqrt(_semiPerimeter * (_semiPerimeter - _side_1) * (_semiPerimeter - _side_2) * (_semiPerimeter - _side_3)));
            Math.Round(_square, 1);

            return (_square);
        }

        public bool CheckTriangle()
        {

            float _maxSide_1 = Math.Max(_side_1, _side_2);
            float _maxSide_2 = Math.Max(_side_2, _side_3);
            float _maxSide = Math.Max(_maxSide_1, _maxSide_2);

            if ((Math.Pow(_side_1, 2) + Math.Pow(_side_2, 2) + Math.Pow(_side_3, 2) - Math.Pow(_maxSide, 2) == Math.Pow(_maxSide, 2)))
            {
                return true;
            }

            else
            {
                return false;
            }


        }
    }
}