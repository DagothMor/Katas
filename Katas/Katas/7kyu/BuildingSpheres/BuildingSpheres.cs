using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas._7katas.BuildingSpheres
{
    public class BuildingSpheres
    {
        public static void Start()
        {
            Console.WriteLine("Создаем Шар");
            Sphere S = new Sphere(2,50);
            Console.WriteLine("Радиус равен");
            Console.WriteLine(S.GetRadius());
            Console.WriteLine("масса равна");
            Console.WriteLine(S.GetMass());
            Console.WriteLine("Объем равен");
            Console.WriteLine(S.GetVolume());
            Console.WriteLine("Площадь поверхности");
            Console.WriteLine(S.GetSurfaceArea());
            Console.WriteLine("Плотность");
            Console.WriteLine(S.GetDensity());
            Console.ReadLine();

        }
        public class Sphere
        {
            public static int radius;
            public static int mass;
            public static double pi = Math.PI;
            public static double result = (double)4/3;
            public static double V = 1.25 * Math.Pow(radius, 3) * pi;
            public Sphere(int Radius, int Mass) { radius = Radius; mass = Mass; }

            public int GetRadius() { return radius; }
            public int GetMass() { return mass; }

            public double GetVolume()
            {
                return Math.Round(result * Math.Pow(radius, 3) * pi, 5);
            }

            public double GetSurfaceArea()
            {
                return Convert.ToDouble(Math.Round((4*pi*(Math.Pow(radius,2))), 5));
            }
            public double GetDensity()
            {
                return Convert.ToDouble(mass/ (result * Math.Pow(radius, 3) * pi));
            }
        }
}
}
