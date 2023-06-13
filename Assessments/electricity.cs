//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assessments
//{
//    internal class electricity
//    {
//        static void Main(string[] args)
//        {
//            double unit,result,surcharge,totalbill;
//            Console.WriteLine("Enter electricity consumption");
//            unit = Convert.ToDouble(Console.ReadLine());

//            if (unit <= 50)
//            {
//                result = unit * 0.50;
//            }
//            else if (unit > 50 && unit <= 150)
//            {
//                result = unit * 0.75;
//            }
//            else if (unit > 150 && unit <= 250) 
//            {
//                result = unit * 1.20;
//            }
//            else
//            {
//                result = unit * 1.50;
//            }
//            surcharge = result * 20 / 100;
//            totalbill = result + surcharge;
//            Console.WriteLine($"Total bill is {totalbill}");







//        }

//    }
//}
