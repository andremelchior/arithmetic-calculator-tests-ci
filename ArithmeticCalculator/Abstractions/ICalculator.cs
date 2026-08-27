using System;

namespace ArithmeticCalculator.Abstractions
{
    public interface ICalculator
    {
        public double Result { get; set; }

        public double Sum(double firstNumber, double secondNumber);

        public double Subtration(double firstNumber, double secondNumber);

        public double Multiplication(double firstNumber, double secondNumber);

        public double Division(double firstNumber, double secondNumber);
    }
}
