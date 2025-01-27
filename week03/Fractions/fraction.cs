using System;

namespace FractionApp
{
    public class Fraction
    {
        // Private attributes for the numerator (top) and denominator (bottom)
        private int _numerator;
        private int _denominator;

        // Constructor with no parameters, initializes to 1/1
        public Fraction()
        {
            _numerator = 1;
            _denominator = 1;
        }

        // Constructor with one parameter, initializes to n/1
        public Fraction(int numerator)
        {
            _numerator = numerator;
            _denominator = 1;
        }

        // Constructor with two parameters
        public Fraction(int numerator, int denominator)
        {
            // Ensure denominator is not zero
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be zero.");

            _numerator = numerator;
            _denominator = denominator;
        }

        // Getter and Setter for numerator
        public int Numerator
        {
            get { return _numerator; }
            set { _numerator = value; }
        }

        // Getter and Setter for denominator
        public int Denominator
        {
            get { return _denominator; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("Denominator cannot be zero.");
                _denominator = value;
            }
        }

        // Method to return the fraction as a string
        public string GetFractionString()
        {
            return $"{_numerator}/{_denominator}";
        }

        // Method to return the decimal value of the fraction
        public double GetDecimalValue()
        {
            return (double)_numerator / _denominator;
        }
    }
}
