using System;

namespace cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA,sideB,sideC;
            Program user = new Program();
            sideA = user.getSide("side A");
            sideB = user.getSide("side B");
            sideC = user.getSide("side C");

            double trianglePerimeter = user.getPerimeter(sideA, sideB, sideC);
            double traingleArea = user.getArea(sideA, sideB, sideC);

            
            Console.WriteLine("Perimeter:" + trianglePerimeter);
            Console.WriteLine("Area:" + traingleArea);
        }

        public double getSide(string sideName)
        {
            double side;
            Console.WriteLine("Please input value of " + sideName);
            side = Convert.ToInt32(Console.ReadLine());

            return side;

        }

        public double getPerimeter(double sideA, double sideB, double sideC)
        {
            double perimeter = sideA + sideB + sideC;
            return perimeter;
        }

        public double getArea(double sideA, double sideB, double sideC)
        {
            double area;
            double halfPerimeter = this.getPerimeter(sideA, sideB, sideC)/2;
            //this method of calculating the area is herons formula 
            area = halfPerimeter*(halfPerimeter - sideA) * (halfPerimeter-sideB) * (halfPerimeter-sideC);

            //square root
            area = Math.Pow(area,0.5);
            return area;

        }
    }
}
