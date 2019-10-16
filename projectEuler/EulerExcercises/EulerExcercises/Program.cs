using System;

namespace EulerExcercises
{
    class ProjectTwo
    {
        static void Main(string[] args)
        {



            ProjectFive test = new ProjectFive();

            test.Run();
        }

        public int GetUserInputValue()
        {
            Console.WriteLine("Please Input an Integer");


            int value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(value);

            return value;
        }

        public int getLargestPrimeFactor(int value)
        {

            int i;
            //Starts with the first Prime Number 2
            for (i = 2; i <= value; i++)
            {

                //If the modulo of Input value to i is 0, then it is a prime factor
                if (value % i == 0)
                {

                    //continually dividing by this factor will give you next prime factor if any exsist
                    value /= i;

                    //reduces i by one so it will be same prime factor next iteration
                    i--;

                    Console.WriteLine("Value = " + value + "; i= " + i);
                }
                Console.WriteLine("Value = " + value + "; i= " + i);
            }

            return i;
        }
    }

    class ProjectThree
    {

        public void Run()
        {
            int maxPalindrome;

            int[] limits = new int[2];

            limits = this.GetLimits(3);

            maxPalindrome = multiplyLimits(limits[1], limits[0]);

            Console.WriteLine("Max palindrome: " + maxPalindrome);

            
        }

        public Boolean PalindromeCheck(int value)
        {

            int reversedValue = this.ReverseValue(value);


            if (value - reversedValue != 0)
            {
                return false;
            }

            return true;
            
        }

        public int ReverseValue(int value)
        {
            int reverse = 0, remainder;

            
            while (value != 0)
            {
                //gets units as remaider
                remainder = value % 10;
                //add to this varaible, multiplying any previous data by 10 so unit order is preserved
                reverse = reverse * 10 + remainder;
                //divides the value by 10 so next digit is in unit position
                value /= 10;
            }
            

            return reverse;
        }

        
        public int[] GetLimits(int value)
        {
            int[] limits = new int[2];

            int upperLimit = 0, lowerLimit;

            for (int i = 1; i <= value; i++)
            {
                upperLimit *= 10;
                upperLimit += 9;

            }

            lowerLimit = (upperLimit + 1) / 10;

            limits[0] = lowerLimit;

            limits[1] = upperLimit;

            return limits;
        }

        public int multiplyLimits(int upperLimit, int lowerLimit)
        {

            int product;
            for (int i = upperLimit; i >= lowerLimit; i--)
            {
                for (int j = i; j >= lowerLimit; j--)
                {
                    product = i * j;

                    if (this.PalindromeCheck(product))
                    {
                        return product;
                    }
                }
            }

            return -1;
        }
    }

    class ProjectFour
    {


        public int SmallestMultiple()
        {
            int smallestMultiple = 0, count = 0;

            for (int i = 20; ; i++)
            {
                for (int j = 20; j > 0; j--)
                {
                    if (i % j == 0)
                    {
                        count ++;
                    }
                }

                if (count == 20)
                {
                    smallestMultiple = i;

                    return smallestMultiple;
                }
                else
                {
                    count = 0;
                }
            }

        }
    }

    class ProjectFive
    {

        public void Run() {
            int value = this.GetUserInputValue();

            int sumSquared, sequenceSquared;

            sumSquared = this.SumSquared(value);

            sequenceSquared = this.SequenceSquared(value);

            Console.WriteLine("The difference is: " + this.SquaredDifference(sumSquared, sequenceSquared));

        }
        public int SumSquared(int n)
        {
            // this formula returns the sum of 1 to n
            int sum = (n * (n + 1)) / 2;

            
            return sum*sum;
        }

        public int SequenceSquared(int n)
        {
            //adds squares of each n value to a running total
            int runningTotal = 0;
            for (int i = 1; i <= n; i++)
            {
                runningTotal = runningTotal + (i * i);
            }

            return runningTotal;
        }

        public int SquaredDifference(int sumSquared, int sequenceSquared)
        {

            //returns the difference as a positive number
            if (sumSquared > sequenceSquared)
            {
                return sumSquared - sequenceSquared;
            }else
            {
                return sequenceSquared - sumSquared;
            }

        }

        public int GetUserInputValue()
        {
            Console.WriteLine("Please Input an Integer");


            int value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(value);

            return value;
        }


    }
}
