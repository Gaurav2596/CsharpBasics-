//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assessments
//{
//    internal class Displaygrade
//    {
//        static void Main(string[] args)
//        {
//            double physics, chemistry, math, total, percentage;
//            Console.WriteLine("Enter marks of PHYSICS");
//            physics = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Enter marks of CHEMISTRY");
//            chemistry = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Enter marks of MATH ");
//            math = Convert.ToDouble(Console.ReadLine());

//            total = physics + chemistry + math;
//            percentage = (total / 300) * 100;
//            Console.WriteLine($"Percentage is :- {percentage} ");

//            if (percentage > 80)
//            {
//                Console.WriteLine("Student passed with Grade A");
//            }
//            else if (percentage > 70)
//            {
//                Console.WriteLine("Student passed with Grade B");
//            }
//            else if (percentage > 60)
//            {
//                Console.WriteLine("Student passed with Grade C");
//            }
//            else if (percentage < 60)
//            {
//                Console.WriteLine("Student passed with Grade D");

//            }
//        }
//    }
//}
