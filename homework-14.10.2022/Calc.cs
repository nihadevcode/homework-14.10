using System;
using System.Collections.Generic;
using System.Text;

namespace homework_14._10._2022
{
    class Calc
    {
        public static int Calculation()
        {
            Calc Calculator1 = new Calc();

            Console.WriteLine("Enter the first number");
            int arg1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operation (+; -; *; /)");
            string operation = (Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int arg2 = int.Parse(Console.ReadLine());

            int result = 0;

            switch (operation)
            {
                case "+": result = arg1 + arg2;
                    break;
                case "-":
                    result = arg1 - arg2;
                    break;
                case "*":
                    result = arg1 * arg2;
                    break;
                case "/":
                    result = arg1 / arg2;
                    break;
            }
            Console.WriteLine("Result:");
            return result;
        }
    }
}
