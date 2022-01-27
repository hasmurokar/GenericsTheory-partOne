using System;
using System.Collections.Generic;

namespace GenericsTheory
{
    class Point<T>
    { 
        public T X { get; set; }
        public T Y { get; set; }
        private static int Counter = 0;

        public Point(T x, T y)
        {
            X = x;
            Y = y;
            Counter++;
        }
        public void Output()
        {
            Console.WriteLine($"Координаты точки: x = {X} y = {Y}");
        }
        public static int Count
        {
            get { return Counter; }
        }
        public static double Distance<X, Y>(X value1, Y value2)
        {
            double dValue1 = Convert.ToDouble(value1);
            double dValue2 = Convert.ToDouble(value2);
            return Math.Sqrt((dValue1 * dValue1) + (dValue2*dValue2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point<int> p1 = new Point<int>(3, 7);
            Point<double> p2 = new Point<double>(2.8, 4.6);
            Point<int> p3 = new Point<int>(4, -4);
            Point<double> p4 = new Point<double>(1.4, 2.3);
            p1.Output();
            p2.Output();
            p3.Output();
            p4.Output();
            Console.WriteLine($"Количество точек(int): {Point<int>.Count}");
            Console.WriteLine($"Количество точек(double): {Point<double>.Count}");
            Console.WriteLine($"Расстояние от точки до начала коорд.(int): {Point<int>.Distance<int,int>(p1.X, p1.Y)}");
            Console.WriteLine($"Расстояние от точки до начала коорд.(double): {Point<double>.Distance<double, double>(p2.X, p2.Y)}");

        }
    }
}
