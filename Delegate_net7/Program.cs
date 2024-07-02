public delegate double CalculatorOperation(double a, double b);

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        CalculatorOperation add = calculator.Add;
        CalculatorOperation subtract = calculator.Subtract;
        CalculatorOperation multiply = calculator.Multiply;
        CalculatorOperation divide = calculator.Divide;

        Console.WriteLine("Addition: " + add(10, 5));
        Console.WriteLine("Subtraction: " + subtract(10, 5));
        Console.WriteLine("Multiplication: " + multiply(10, 5));
        Console.WriteLine("Division: " + divide(10, 5));
    }
}

public class Calculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

   public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }
        return a / b;
    }
}


