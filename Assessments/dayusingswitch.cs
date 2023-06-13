using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments
{
    internal class dayusingswitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose any one option");
            Console.WriteLine("0=Sunday");
            Console.WriteLine("1=Monday");
            Console.WriteLine("2=Tuesday");
            Console.WriteLine("3=Wednesday");
            Console.WriteLine("4=Thursday");
            Console.WriteLine("5=Friday");
            Console.WriteLine("6=Saturday");
            int option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 0:
                    Console.WriteLine("you have selected Sunday");
                    break;
                case 1:
                    Console.WriteLine("you have selected Monday");
                    break;
                case 2:
                    Console.WriteLine("you have selected Tuesday");
                    break;
                case 3:
                    Console.WriteLine("you have selected Wednesday");
                    break;
                case 4:
                    Console.WriteLine("you have selected Thursday");
                    break;
                case 5:
                    Console.WriteLine("you have selected Friday");
                    break;  
                case 6:
                    Console.WriteLine("you have selected Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }


        }
    }
}
