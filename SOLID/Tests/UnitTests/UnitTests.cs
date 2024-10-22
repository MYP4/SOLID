using Xunit;
using Tech;

namespace UnitTests;

public class UnitTests
{
    private readonly Calculator _calculator = new Calculator();

    [Fact]
    public void Add_TwoPositiveNumbers_ReturnsSum()
    {

        double num1 = 5;
        double num2 = 7;


        double result = _calculator.Add(num1, num2);


        Assert.Equal(12, result);
    }

    [Fact]
    public void Subtract_PositiveAndNegativeNumber_ReturnsDifference()
    {

        double num1 = 10;
        double num2 = -3;


        double result = _calculator.Subtract(num1, num2);


        Assert.Equal(13, result);
    }

    [Fact]
    public void Multiply_TwoDecimalNumbers_ReturnsProduct()
    {

        double num1 = 4.5;
        double num2 = 2.75;


        double result = _calculator.Multiply(num1, num2);


        Assert.Equal(12.375, result);
    }

    [Fact]
    public void Divide_DivisionByZero_ThrowsDivideByZeroException()
    {

        double num1 = 10;
        double num2 = 0;

        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(num1, num2));
    }

    [Fact]
    public void Power_PositiveBaseAndExponent_ReturnsCorrectResult()
    {

        double baseNumber = 2;
        int exponent = 3;


        double result = _calculator.Power(baseNumber, exponent);


        Assert.Equal(8, result);
    }

    [Fact]
    public void SquareRoot_NegativeNumber_ThrowsArgumentException()
    {

        double number = -4;


        Assert.Throws<ArgumentException>(() => _calculator.SquareRoot(number));
    }

    [Fact]
    public void Factorial_ZeroOrOne_ReturnsOne()
    {

        int number = 0;


        long result = _calculator.Factorial(number);


        Assert.Equal(1L, result);
    }

    [Fact]
    public void Factorial_PositiveNumber_ReturnsCorrectResult()
    {

        int number = 5;


        long result = _calculator.Factorial(number);


        Assert.Equal(120L, result);
    }

    [Fact]
    public void Sin_RightAngle_ReturnsOne()
    {

        double angleInDegrees = 90;


        double result = _calculator.Sin(angleInDegrees);


        Assert.Equal(1, result);
    }

    [Fact]
    public void Cos_RightAngle_ReturnsZero()
    {

        double angleInDegrees = 90;


        double result = _calculator.Cos(angleInDegrees);


        Assert.Equal(0, result);
    }

    [Fact]
    public void Tan_RightAngle_ThrowsOverflowException()
    {

        double angleInDegrees = 90;


        Assert.Throws<OverflowException>(() => _calculator.Tan(angleInDegrees));
    }

    [Fact]
    public void PowerOfTwo_PositiveExponent_ReturnsCorrectResult()
    {

        int exponent = 3;


        int result = _calculator.PowerOfTwo(exponent);


        Assert.Equal(8, result);
    }

    [Fact]
    public void LogarithmBase10_NegativeNumber_ThrowsArgumentException()
    {

        double number = -1;


        Assert.Throws<ArgumentException>(() => _calculator.LogarithmBase10(number));
    }

    [Fact]
    public void NaturalLogarithm_NegativeNumber_ThrowsArgumentException()
    {

        double number = -1;


        Assert.Throws<ArgumentException>(() => _calculator.NaturalLogarithm(number));
    }

    [Fact]
    public void AbsoluteValue_NegativeNumber_ReturnsPositive()
    {

        double number = -5;


        double result = _calculator.AbsoluteValue(number);


        Assert.Equal(5, result);
    }

    [Fact]
    public void RoundToNearestInteger_DecimalNumber_ReturnsNearestInteger()
    {

        double number = 4.7;


        double result = _calculator.RoundToNearestInteger(number);


        Assert.Equal(5, result);
    }

    [Fact]
    public void RoundToDecimalPlaces_TwoDecimalPlaces_ReturnsCorrectResult()
    {

        double number = 3.14159;
        int decimalPlaces = 2;


        double result = _calculator.RoundToDecimalPlaces(number, decimalPlaces);


        Assert.Equal(3.14, result);
    }

    [Fact]
    public void CompoundInterest_PositiveValues_ReturnsCorrectResult()
    {

        double principal = 1000;
        double rate = 0.05;
        int time = 5;


        double result = _calculator.CompoundInterest(principal, rate, time);


        Assert.Equal(1276.78, result, 2); // Проверяем с точностью до двух знаков после запятой
    }

    [Fact]
    public void SimpleInterest_PositiveValues_ReturnsCorrectResult()
    {

        double principal = 1000;
        double rate = 0.05;
        int time = 5;


        double result = _calculator.SimpleInterest(principal, rate, time);


        Assert.Equal(250, result);
    }

    [Fact]
    public void IsPrime_PrimeNumber_ReturnsTrue()
    {

        int number = 7;


        bool result = _calculator.IsPrime(number);


        Assert.True(result);
    }

    [Fact]
    public void IsPrime_CompositeNumber_ReturnsFalse()
    {

        int number = 6;


        bool result = _calculator.IsPrime(number);


        Assert.False(result);
    }

    [Fact]
    public void GreatestCommonDivisor_TwoNumbers_ReturnsGCD()
    {

        int a = 48;
        int b = 18;


        int result = _calculator.GreatestCommonDivisor(a, b);


        Assert.Equal(6, result);
    }
}