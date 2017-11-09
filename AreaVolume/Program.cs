using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Calculator calculator1 = new Calculator();
                //Console.WriteLine("The Area of Circle = {0}", calculator1.GetCircleArea(10));
                //Console.WriteLine("The Volume of Cylinder = {0}", calculator1.GetCylinderVolume(10, 5));
                //Console.WriteLine("The Volume of Cone = {0}", calculator1.GetConeVolume(10, 5));
                Console.WriteLine("《⊙＿⊙《 (⊙＿⊙) (@口@) ∑(@)(￣?￣)+ ∑(⊙▽⊙a"); 
                Console.WriteLine("Please input the Radius of Circle:");
                double r1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The Area of Circle = {0}", calculator1.GetCircleArea(r1));
                Console.WriteLine("***************************************");
                Console.WriteLine("Please input the Radius of Cylinder:");
                double r2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please input the High of Cylinder:");
                double h2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The Volume of Cylinder = {0}",calculator1.GetCylinderVolume(r2,h2));
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("Please input the Radius of Cone");
                double r3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please input the High of Cone");
                double h3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The Volume of Cone = {0}",calculator1.GetConeVolume(r3,h3));
                Console.WriteLine("The End!<(￣）￣)> []~(￣▽￣)~* (￣﹏￣) (￣ˇ￣) ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

    class Calculator
    {
        public double GetCircleArea(double r)
        {
            return Math.PI * r * r;
        }
        public double GetCylinderVolume(double r, double h)
        {
            return GetCircleArea(r) * h;
        }
        public double GetConeVolume(double r, double h)
        {
            return GetCylinderVolume(r, h) / 3;
        }
    }
}
