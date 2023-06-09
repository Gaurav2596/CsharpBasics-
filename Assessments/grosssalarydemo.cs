//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Channels;
//using System.Threading.Tasks;

//namespace Assessments
//{
//    internal class grosssalarydemo
//    {
//        static void Main(string[] args)
//        {
//            int empid,salary, HRA, TA, DA, PF, PT;
//            string empname;
//            long gross_salary;
            

//            Console.WriteLine("Enter empid");
//            empid = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Enter empname");
//            empname =Console.ReadLine();

//            Console.WriteLine("Enter basic salary");
//            salary =Convert.ToInt32(Console.ReadLine());

//            HRA = salary * 40 / 100;
//            TA = salary * 20 / 100;
//            DA = salary * 10 / 100;
//            PF = salary * 12 / 100;
//            PT = 200;

//            gross_salary = salary+HRA+TA+DA-PF-PT;

//            Console.WriteLine($"Gross salary of employee is {gross_salary}");






//        }
//    }
//}
