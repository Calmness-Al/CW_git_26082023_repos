using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_git_26082023_repos
{
    public class Calculator
    {
        double num1, num2;
        public double Add(double num1, double num2)
        {
            /*Console.WriteLine("Enter first digit:");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second digit:");
            num2 = double.Parse(Console.ReadLine());*/
            double res = 0;
            res = num1 + num2;    
            Console.WriteLine(res);
            return num1 + num2;
            Console.WriteLine(res);
        }
    }
    
    
    internal class Program
    {
        static void Main()
        {
        Calculator calculator = new Calculator();
            calculator.Add(25.0,5.0);


        Console.ReadKey();
        }
    }
}
