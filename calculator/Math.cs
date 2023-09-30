using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Drawing.Text;

namespace calculator
{
    public class Math
    {
        private const string pattern = @"(\d+(\.\d+)?)|(\+|\-|\*|\/)";
        public Math(string input) 
        {
            GetExpression(input);
        }

        private void GetExpression(string input)
        {
            MatchCollection matches = Regex.Matches(input, pattern);

            if (matches.Count >= 2)
            {
                string firstToken = matches[0].Value;
                string operatorToken = matches[1].Value;
                string secondToken = matches[2].Value;

                if (double.TryParse(firstToken, out double firstNumber) && double.TryParse(secondToken, out double secondNumber))
                {
                    FindResult();
                }
                else
                    Console.WriteLine("Error: Failed to convert numbers");
            }
            else
                Console.WriteLine("Error: Not enough numbers in expression");
        }

        private void FindResult(string operatorToken, double firstNumber, double secondNumber)
        {
            switch (operatorToken)
            {
                case "+":
                    Sum(firstNumber, secondNumber);
                    break;

                case "-":
                    Sub(firstNumber, secondNumber);
                    break;

                case "*":
                    Mul(firstNumber, secondNumber);
                    break;

                case "÷":
                    Div(firstNumber, secondNumber);
                    break;

                case "%":
                    DivWithRem(firstNumber, secondNumber);
                    break;

                case "√":
                    Sqrt(firstNumber);
                    break;

                case "^":
                    Pow(firstNumber, secondNumber);
                    break;
            }
        }

        private double Pow(double firstNumber, double secondNumber)
        {
            if (firstNumber == 0) { return 0; }
            else if (secondNumber == 1) { return firstNumber; }
            else if (secondNumber == 0) { return 1; }

            double res = 1;

            for (int i = 1; i <= secondNumber; i++) 
                res *= firstNumber;

            return firstNumber;
        }

        private double Sqrt(double firstNumber)
        {
            return Pow(firstNumber, 1/2);
        }

        private double DivWithRem(double firstNumber, double secondNumber)
        {
            return firstNumber % secondNumber;
        }

        private double Div(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }

        private double Mul(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        private double Sub(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        private double Sum(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
