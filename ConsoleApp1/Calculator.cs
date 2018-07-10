using System;

namespace ConsoleApp1
{
    public class Calculator
    {
        double _leftNumber;
        string _sign;
        double _rightNumber;
        string _answer;
        double _result;

        public void Calculate()
        {
            do
            {
                TakeData();
                ChooseOperation();
                ShowInformation();
                Ask();
            } while (_answer == "t");
        }

        private void ChooseOperation()
        {
            switch (_sign)
            {
                case "+":
                    _result = _leftNumber + _rightNumber;
                    break;
                case "-":
                    _result = _leftNumber - _rightNumber;
                    break;
                case "*":
                    _result = _leftNumber * _rightNumber;
                    break;
                case "/":
                    _result = _leftNumber / _rightNumber;
                    break;
                default:
                    _result = _leftNumber + _rightNumber;
                    break;
            }
        }

        private void TakeData()
        {
            Console.WriteLine("Please enter first number, mathematical operation (+,-,*,/,%) and second number:");

            Console.WriteLine("Enter first number");
            _leftNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a mathematical operation +,-,*,/,%");
            _sign = Console.ReadLine();

            Console.WriteLine("Enter second number");
            _rightNumber = Convert.ToDouble(Console.ReadLine());
        }

        private void ShowInformation()
        {
            Console.WriteLine($"The result: {_result}");
            Console.WriteLine("The result: {0}", _result);
        }

        private void Ask()
        {
            Console.WriteLine("Please enter 't' if you want to start over or any other sign to quit");
            _answer = Console.ReadLine();
        }
    }
}
