using calculator;
using System.Text.RegularExpressions;

public class MathCalculator
{
    private Calculator calculator;
    private const string pattern = @"(\d+(\.\d+)?)|(\+|\-|\*|\/|\^|%|√)";

    public MathCalculator(string input, Calculator calculator)
    {
        this.calculator = calculator;
        CalculateExpression(input);
    }

    private void CalculateExpression(string input)
    {
        try
        {
            Stack<double> numbers = new Stack<double>();
            Stack<string> operators = new Stack<string>();

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                string token = match.Value;

                if (double.TryParse(token, out double number))
                {
                    numbers.Push(number);
                }
                else
                {
                    while (operators.Count > 0 && OperatorPrecedence(operators.Peek()) >= OperatorPrecedence(token))
                    {
                        double b = numbers.Pop();
                        double a = numbers.Pop();
                        string op = operators.Pop();
                        double result = ApplyOperator(a, b, op);
                        numbers.Push(result);
                    }
                    operators.Push(token);
                }
            }

            while (operators.Count > 0)
            {
                double b = numbers.Pop();
                double a = numbers.Pop();
                string op = operators.Pop();
                double result = ApplyOperator(a, b, op);
                numbers.Push(result);
            }

            if (numbers.Count == 1)
            {
                ShowResult(numbers.Pop());
            }
            else
            {
                MessageBox.Show("Invalid expression");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}");
        }
    }

    private int OperatorPrecedence(string op)
    {
        switch (op)
        {
            case "+":
            case "-":
                return 1;
            case "*":
            case "/":
                return 2;
            default:
                return 0;
        }
    }

    private double ApplyOperator(double a, double b, string op)
    {
        switch (op)
        {
            case "+":
                return a + b;
            case "-":
                return a - b;
            case "*":
                return a * b;
            case "/":
                if (b != 0)
                    return a / b;
                else
                    throw new DivideByZeroException();
            case "^":
                return Math.Pow(a, b);
            case "√":
                return Math.Sqrt(a);
            case "%":
                if (b != 0)
                    return a % b;
                else
                    throw new DivideByZeroException();
            default:
                throw new ArgumentException("Invalid operator");
        }
    }


    private void ShowResult(double res)
    {
        try
        {
            string Result = res.ToString();
            calculator.SetFieldValue(Result);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}");
        }
    }
}
