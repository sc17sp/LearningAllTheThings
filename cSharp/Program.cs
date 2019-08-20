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
            bool check = user.triangleCheck(sideA, sideB, sideC);
            double angleC = user.useCosineRule(sideA, sideB, sideC);
            double angleB = user.useSineRule(sideC, angleC, sideB);
            double angleA = user.useSineRule(sideC, angleC, sideA);

            Console.WriteLine("True Triangle :" + check);
            Console.WriteLine("Perimeter:" + trianglePerimeter);
            Console.WriteLine("Area:" + traingleArea);
            Console.WriteLine("Triangle Type: " + user.getType(sideA, sideB, sideC));
            Console.WriteLine("Angle C in degrees:" + angleC);
            Console.WriteLine("Angle C in degrees:" + angleB);
            Console.WriteLine("Angle C in degrees:" + angleA);
        }

        public bool triangleCheck(double sideA, double sideB, double sideC)
        {
            
            if(sideA + sideB <= sideC)
                return false;

            if(sideB + sideC <= sideA)
                return false;

            if(sideC + sideA <= sideB)
                return false;

            return true;
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

        public string getType(double sideA, double sideB, double sideC)
        {

            //an equilateral triangle has 3 sides of equal length
            if(sideA == sideB && sideA == sideC && sideC == sideB)
                return "Equilateral";
            

            //Scalene has 3 sides all of unequal length
            if(sideA != sideB && sideB != sideC && sideC != sideA)
               return "Scalene";
            

            //Isoscele has 2 sides equal and one unequal in length
            return "Isoscele";
        }

        public double useCosineRule(double sideA, double sideB, double sideC)
        {
            //here a re-arranged cosine rule is used to find a single area
            //cosine rule rearranged angleC = arcCos[v/t]
            //v = sideA^2 + sideB^2 - sideC^2
            //t = 2*sideA*sideB
            double angleC,numerator,denominator;

            numerator = Math.Pow(sideA,2) + Math.Pow(sideB,2) - Math.Pow(sideC,2);

            denominator = 2 * sideA * sideB;
            //Math.Acos returns in radians
            angleC = Math.Acos(numerator/denominator);

            return angleC;
        }

        public double useSineRule(double sideA, double angleA, double sideB)
        {
            //here we use a re-arranged sine rule to calculate the angleB which is returned
            double arcSineInput = (sideB * Math.Sin(angleA))/sideA;

            double angleB = Math.Asin(arcSineInput);

            return angleB;
        }
    }
}
