using System;

namespace SimpleCalculatorC
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            cal.TakeData(out double no1, out string sign, out double no2);
            cal.ShowInformaton();
            cal.Ask();
            Console.ReadKey();
        }
    }
    class Calculator
    {
        
        double no1;
        string sign;
        double no2;
        string answer;
        double result;
        public double result()
        {
            if (sign == "+")
            {
                result= x * y;
            }
            else if (sign == "-")
            {
                result= x - y;
            }
            else if (sign == "*")
            {
                result= x * y;
            }
            else if (sign == "/")
            {
                result= x / y;
            }
            else if (sign == "%")
            {
                result= x % y;
            }
            else
            {
                Console.WriteLine("Wrong sign!");
            }
            do {
                public void TakeData(out double no1, out string sign, out double no2)
                {
                    Console.WriteLine("Please enter first number, mathematical operation (+,-,*,/,%) and second number:")
                    Console.WriteLine("Enter first number");
                    no1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter a mathematical operation +,-,*,/,%");
                    sign = Console.ReadLine();
                    Console.WriteLine("Enter second number");
                    no2 = Convert.ToDouble(Console.ReadLine());
                }
                public void ShowInformation()
                {
                    Console.WriteLine("The result: ", result);
                }
                public void Ask()
                {
                    Console.WriteLine("Please enter 't' if you want to start over or any other sign to quit");
                    answer = Console.ReadLine();
                }
            } while answer == "t";
        }
    
    
    }
}
   
