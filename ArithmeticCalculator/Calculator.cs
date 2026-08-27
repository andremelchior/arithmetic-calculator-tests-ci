using System;
using ArithmeticCalculator.Abstractions;

namespace ArithmeticCalculator
{
    public class Calculator : ICalculator
    {
	public double Result { get; set; }

	public double Sum(double firstNumber = 0, double secondNumber = 0)
	{
	    return this.Result = firstNumber + secondNumber;
	}

	public double Subtration(double firstNumber = 0, double secondNumber = 0)
        {
            return this.Result = firstNumber - secondNumber;
        }
	
	public double Multiplication(double firstNumber = 0, double secondNumber = 0)
        {
            return this.Result = firstNumber * secondNumber;
        }

	public double Division(double firstNumber = 0, double secondNumber = 0)
        {
            return this.Result = firstNumber / secondNumber;
        }
    }
}
