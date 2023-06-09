using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments
{
    internal class equilatral
    {
        static void Main(string[] args)
        {
            double side, area;
            Console.WriteLine("Enter a side");
            side = Convert.ToDouble(Console.ReadLine());

            area = (1.73 * side * side) / 4;
            Console.WriteLine($"Area of equilateral triangle is {area}");
            Console.WriteLine("End Of Program");
        }
    }
}
