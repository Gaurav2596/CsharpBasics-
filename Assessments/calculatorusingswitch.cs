//using system;
//using system.collections.generic;
//using system.linq;
//using system.text;
//using system.threading.tasks;

//namespace assessments
//{
//    internal class calculatorusingswitch
//    {
//        static void main(string[] args)
//        {
//            console.writeline("enter 1st number");
//            double num1 = convert.todouble(console.readline());

//            console.writeline("enter 2nd number");
//            double num2 = convert.todouble(console.readline());

//            console.writeline("1. addition");
//            console.writeline("2. subtraction");
//            console.writeline("3..multiplication");
//            console.writeline("4. division");
//            console.writeline("5. mod");
//            console.writeline("select any one option");
//            double option = convert.todouble(console.readline());

//            switch (option)
//            {
//                case 1:
//                    double result = num1 + num2;
//                    console.writeline($"addition is {result}");
//                    break;
//                case 2:
//                    result = num1 - num2;
//                    console.writeline($"subtraction is {result}");
//                    break;
//                case 3:
//                    result = num1 * num2;
//                    console.writeline($"multiplication us {result}");
//                    break;
//                case 4:
//                    result = (double)num1 / num2;
//                    console.writeline($"division is {result}");
//                    break;
//                case 5:
//                    result = num1 % num2;
//                    console.writeline($"mod is {result}");
//                    break;
//                default:
//                    console.writeline("invalid option");
//                    break;

//            }




//        }
//    }
//}
