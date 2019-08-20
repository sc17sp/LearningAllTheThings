using System;

namespace cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideA,sideB,sideC;
            Program user = new Program();
            sideA = user.getSide("side A");
            sideB = user.getSide("side B");
            sideC = user.getSide("side C");

            trianglePerimeter = user.getPerimeter(sideA, sideB, side)
        }

        public int getSide(string sideName)
        {
            int side;
            Console.WriteLine("Please input value of " + sideName);
            side = Convert.ToInt32(Console.ReadLine());

            return side;

        }

        public int getPerimeter(int sideA, int sideB, int sideC)
        {
            int perimeter = sideA + sideB + sideC;
            return perimeter;
        }
    }
}
