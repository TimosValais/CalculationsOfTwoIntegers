using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsOfTwoIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 0, y = 0;
            //Console.WriteLine($"{x}, {y}");
            Calculator calc = new Calculator(); // default constructor
                                                //calc.TellMePleaseTheValuesOfTheFields();
                                                //Console.WriteLine(calc.Add()); // 0
                                                //Console.WriteLine(calc.Add(1, 2)); // 3

            Console.WriteLine(calc.Add(1, 2)); // 3
            Console.WriteLine(calc.Add()); // 0

            Console.WriteLine(calc.Subtract()); // 0
            Console.WriteLine(calc.Subtract(1, 3)); // -2

            Console.WriteLine(calc.Multiply()); // 0
            Console.WriteLine(calc.Multiply(1, 2)); // 2

            Console.WriteLine(calc.Divide()); // 0
            Console.WriteLine(calc.Divide(1, 2)); // 0
            Console.WriteLine(calc.Divide(0, 0)); // 0

            Calculator calc2 = new Calculator(5, 10);
            Console.WriteLine(calc2.Add()); // 15



        }
    }
}
