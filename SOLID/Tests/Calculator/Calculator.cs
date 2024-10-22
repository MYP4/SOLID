/// <summary>
/// Кононов Игорь
/// 4 курс, 9 группа
/// I. Техника (от карьерных самосвалов до стиральной машины)
/// 'Tests'
/// </summary>


namespace Tech;

using System;

public class Calculator
{
    private const double PI = Math.PI;
    private const double E = Math.E;

    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    public double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    public double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    public double Divide(double num1, double num2)
    {
        if (num2 == 0)
            throw new DivideByZeroException("Деление на ноль!");
        return num1 / num2;
    }

    public double Power(double baseNumber, int exponent)
    {
        if (exponent == 0) return 1;
        if (exponent < 0) return 1 / Power(baseNumber, -exponent);
        double result = 1;
        for (int i = 0; i < Math.Abs(exponent); i++)
        {
            result *= baseNumber;
        }
        return result;
    }

    public double SquareRoot(double number)
    {
        if (number < 0)
            throw new ArgumentException("Квадратный корень из отрицательного числа не определен.");
        double x = number;
        double y = (x + 1) / 2;

        while (y < x)
        {
            x = y;
            y = (x + number / x) / 2;
        }

        return x;
    }

    public long Factorial(int number)
    {
        if (number < 0)
            throw new ArgumentException("Факториал отрицательного числа не определен.");
        if (number == 0 || number == 1)
            return 1;

        long result = 1;
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }

    public double Sin(double angleInDegrees)
    {
        return Sine(DegreesToRadians(angleInDegrees));
    }

    public double Cos(double angleInDegrees)
    {
        return Cosine(DegreesToRadians(angleInDegrees));
    }

    public double Tan(double angleInDegrees)
    {
        return Tangent(DegreesToRadians(angleInDegrees));
    }

    private double DegreesToRadians(double degrees)
    {
        return degrees * PI / 180;
    }

    private double Sine(double radians)
    {
        const int iterations = 50;
        double result = 0;
        for (int i = 0; i < iterations; i++)
        {
            double sign = (i % 2 == 0) ? 1 : -1;
            result += ((Power(radians, 2 * i + 1)) / Factorial(2 * i + 1)) * sign;
        }
        return result;
    }

    private double Cosine(double radians)
    {
        const int iterations = 50;
        double result = 0;
        for (int i = 0; i < iterations; i++)
        {
            double sign = (i % 2 == 0) ? 1 : -1;
            result += ((Power(radians, 2 * i)) / Factorial(2 * i)) * sign;
        }
        return result;
    }

    private double Tangent(double radians)
    {
        return Sine(radians) / Cosine(radians);
    }

    public int PowerOfTwo(int exponent)
    {
        return (int)Power(2, exponent);
    }

    public double LogarithmBase10(double number)
    {
        if (number <= 0)
            throw new ArgumentException("Логарифм отрицательного или нулевого числа не определен.");
        return NaturalLogarithm(number) / NaturalLogarithm(10);
    }

    public double NaturalLogarithm(double number)
    {
        if (number <= 0)
            throw new ArgumentException("Натуральный логарифм отрицательного или нулевого числа не определен.");
        double x = (number - 1) / (number + 1);
        double sum = 0;
        for (int n = 0; n < 10000; n++)
        {
            sum += Power(-1, n) * Power(x, 2 * n + 1) / (2 * n + 1);
        }
        return 2 * sum;
    }

    public double AbsoluteValue(double number)
    {
        return number >= 0 ? number : -number;
    }

    public double RoundToNearestInteger(double number)
    {
        return number >= 0 ? Math.Floor(number + 0.5) : Math.Ceiling(number - 0.5);
    }

    public double RoundToDecimalPlaces(double number, int decimalPlaces)
    {
        double multiplier = Power(10, decimalPlaces);
        return RoundToNearestInteger(number * multiplier) / multiplier;
    }

    public double CompoundInterest(double principal, double rate, int time)
    {
        return principal * Power(1 + rate, time);
    }

    public double SimpleInterest(double principal, double rate, int time)
    {
        return principal * rate * time;
    }

    public bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int)SquareRoot(number);

        for (int i = 3; i <= boundary; i += 2)
            if (number % i == 0)
                return false;

        return true;
    }

    public int GreatestCommonDivisor(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}

