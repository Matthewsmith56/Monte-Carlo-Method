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
            List<double> xyOverlap = new List<double>();
            Random RandomNumber = new Random();

            for (int i = 0; i < repetitions; i++)
            {
                xVar[i] = RandomNumber.NextDouble();// randomly generates an X variable and converts it to a decimal
                yVar[i] = RandomNumber.NextDouble();// randomly generates an Y variable and converts it to a decimal
                xyDistance[i] = Math.Sqrt((xVar[i] *xVar[i]) + (yVar[i] * yVar[i])); 
               // The above line calculates Pythagorean for corridnates and stores into array 
            }

            Array.Sort(xyDistance);
            foreach (var i in xyDistance)
            {
                if (i <= 1)
                {
                    xyOverlap.Add(i);
                 // The above loop iterates through array and displays only corridnates that would fall inside the circle
                }
            }

            Console.WriteLine("The estimate area is: " + 4 * (xyOverlap.Count/Convert.ToDouble(repetitions)));

           

        }

}
}
