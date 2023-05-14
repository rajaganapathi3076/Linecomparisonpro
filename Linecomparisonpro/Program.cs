using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linecomparisonpro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparison problemUC2");
            Console.WriteLine("Plese enter the value of x1 and y1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Plese enter the value of x2 and y2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Plese enter the value of x3 and y3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Plese enter the value of x4 and y4");
            int x4 = Convert.ToInt32(Console.ReadLine());
            int y4 = Convert.ToInt32(Console.ReadLine());

            int distance1 = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1));
            int distance2 = ((x4 - x3) * (x4 - x3)) + ((y4 - y3) * (y4 - y3));
            Console.WriteLine("The length of the  1st line :%.4F" + Math.Sqrt(distance1));
            Console.WriteLine("The length of the  2st line :%.4F" + Math.Sqrt(distance2));

            if (distance1 == distance2)
            {
                Console.WriteLine("The line length  is Equals");
            }
            else
            {
                Console.WriteLine("The line is not Equals");
            }
            Console.ReadLine();

        }
    }
}
