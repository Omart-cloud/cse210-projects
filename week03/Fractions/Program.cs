using System;

namespace FractionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing the constructors
            Fraction fraction1 = new Fraction(); // 1/1
            Fraction fraction2 = new Fraction(6); // 6/1
            Fraction fraction3 = new Fraction(6, 7); // 6/7

            // Display the fractions and their decimal values
            Console.WriteLine("Fraction 1:");
            Console.WriteLine($"Fraction: {fraction1.GetFractionString()}");
            Console.WriteLine($"Decimal: {fraction1.GetDecimalValue()}");

            Console.WriteLine("\nFraction 2:");
            Console.WriteLine($"Fraction: {fraction2.GetFractionString()}");
            Console.WriteLine($"Decimal: {fraction2.GetDecimalValue()}");

            Console.WriteLine("\nFraction 3:");
            Console.WriteLine($"Fraction: {fraction3.GetFractionString()}");
            Console.WriteLine($"Decimal: {fraction3.GetDecimalValue()}");

            // Testing getters and setters
            fraction3.Numerator = 9;
            fraction3.Denominator = 4;

            Console.WriteLine("\nModified Fraction 3:");
            Console.WriteLine($"Fraction: {fraction3.GetFractionString()}");
            Console.WriteLine($"Decimal: {fraction3.GetDecimalValue()}");
        }
    }
}
