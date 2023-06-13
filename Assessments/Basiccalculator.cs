//using System;
//using System.Collections.Generic;
//using System.Diagnostics.CodeAnalysis;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assessments
//{
//    internal class Basiccalculator
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter 1st number");
//            int n1 = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter 2nd number");
//            int n2 = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("1. Addition");
//            Console.WriteLine("2. Subtraction");
//            Console.WriteLine("3. Multiplication");
//            Console.WriteLine("4. Division");
//            Console.WriteLine("Select any one option to perform the operation");
//            int operation = Convert.ToInt32(Console.ReadLine());

//            if (operation == 1)
//            {
//                int sum = n1 + n2;
//                Console.WriteLine($"Additiom is {sum}");
//            }
//            else if (operation == 2)
//            {
//                int sub = 0;
//                if (n1 > n2)
//                    sub = n1 - n2;
//                else 
//                    sub = n2 - n1;
                
//               Console.WriteLine($"Subtraction is {sub}");
//            }
//            else if (operation == 3)
//            {
//                int mul = n1 * n2;
//                Console.WriteLine($"Multiplication is {mul}");
//            }
//            else if (operation == 4)
//            {
//                double div = (double)n1 / n2;
//                Console.WriteLine($"Division is {div}");
//            }
//            else
//            {
//                Console.WriteLine("Invalid option");
//            }

//        }
//    }
//}
