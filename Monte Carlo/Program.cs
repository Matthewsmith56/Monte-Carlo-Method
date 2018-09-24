using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monte_Carlo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many pairs random points would you like to generate?\n 1 = 10, 2 = 100, 3 = 1000, 4 = 10000");
            int userImput = Convert.ToInt32(Console.ReadLine());

            int repetitions = 0;
            // User selects number of randomly generated pairs
            if (userImput == 1)
                repetitions = 10;
            else if (userImput == 2)
                repetitions = 100;
            else if (userImput == 3)
                repetitions = 1000;
            else if (userImput == 4)
                repetitions = 10000;
            // declaring my arrays for use 
            double[] xVar = new double[repetitions];
            double[] yVar = new double[repetitions];
            double[] xyDistance = new double[repetitions];
            double[] xyOverlap = new double[repetitions];
            Random RandomNumber = new Random();

            for (int i = 0; i < repetitions; i++)
            {
                xVar[i] = RandomNumber.Next(1, 1001)*(.001);// randomly generates an X variable and converts it to a decimal
                yVar[i] = RandomNumber.Next(1, 1001)*(.001);// randomly generates an Y variable and converts it to a decimal
                xyDistance[i] = Math.Sqrt((xVar[i] *xVar[i]) + (yVar[i] * yVar[i])); 
               // The above line calculates Pythagorean for corridnates and stores into array 
            }

            foreach (var i in xyDistance)
            {
                if (i <= 1)
                {
                    Console.WriteLine(i);
                 // The above loop iterates through array and displays only corridnates that would fall outside the circle
                }
            }

            //This is where I have been stuck for a couple hours. I am finding it difficut to count the numbers that fulfill
            // the the "if" statment or transfer them into another array. Once I can solve that problem I will then divide that 
            // number by the "repetitions" variable to find the ratio. 

            //I will continue working on this over the weekend and if I still have trouble on Monday I will bring it up in class for help, Thank you

            Console.WriteLine($"The area is " + Array.length / repetitions);

        }

}
}
