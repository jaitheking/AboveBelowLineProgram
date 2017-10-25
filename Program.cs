using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static string pointloc(double m, double b, double p1, double p2)
        {
            double left, right;
            // y = mx + b
            //Find left side
            left = p2;
            //Find right side
            right = (m * p1) + b;
            //If left > right then above
            if (left > right)
                return "ABOVE";
            else if (right == left)
                return "ON";
            else
                return "BELOW";
                
        }

        static void Main(string[] args)
        {
            double x1, x2, y1, y2, a, b;
            string temp = "";
            Console.WriteLine("Program: Identify a point above or below a line");
            Console.WriteLine("Enter x1,y1:\n(E.g. 1,4)");
            temp = Console.ReadLine();
            x1 = Convert.ToDouble(temp.Split(',')[0]);
            y1 = Convert.ToDouble(temp.Split(',')[1]);

            Console.WriteLine("Enter x2,y2:\n(E.g. 1,4)");
            temp = Console.ReadLine();
            x2 = Convert.ToDouble(temp.Split(',')[0]);
            y2 = Convert.ToDouble(temp.Split(',')[1]);

            Console.WriteLine("To find whether a point is under the line, enter a,b :\n(E.g. 1,4)");
            temp = Console.ReadLine();
            a = Convert.ToDouble(temp.Split(',')[0]);
            b = Convert.ToDouble(temp.Split(',')[1]);

            //Make a Line Equation
            //Find m and b
            double m, b1,b2,c;
            m = (y2 - y1) / (x2 - x1);
            b1 = y1 - (-1* m*(x1));
            b2 = y2 - (-1 * m * (x2));
            if (b1 == b2)
            {
                c = b1;
            }
            else
            {
                c = b2;
            }

            Console.WriteLine("Point is located " + pointloc(m, c, a, b) + " the line.");
            Console.ReadKey();
        }
    }
}
