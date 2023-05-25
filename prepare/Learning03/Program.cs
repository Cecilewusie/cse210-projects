using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fractionOne = new Fraction();
        Console.WriteLine(fractionOne.GetFractionString());
        Console.WriteLine(fractionOne.GetDecimalValue());

        Fraction fractionTwo = new Fraction(5);
        Console.WriteLine(fractionTwo.GetFractionString());
        Console.WriteLine(fractionTwo.GetDecimalValue());

        Fraction fractionthree = new Fraction(1, 3);
        Console.WriteLine(fractionthree.GetFractionString());
        Console.WriteLine(fractionthree.GetDecimalValue());

        // Fraction FractionFour = new Fraction(1 / 3);
        // Console.WriteLine(FractionFour.GetFractionString());
        // Console.WriteLine(FractionFour.GetDecimalValue());
    
    //calling the getters and setters and displaying them to the terminal window
    //fractionOne.setTop(9);
    //Console.WriteLine($"The numerator is {fractionOne.getTop()}");
    //fractionOne.setBottom(5);
    //Console.WriteLine($"The denomenator is {fractionOne.getBottom()}");

    //caling the methods in the fraction class




    }
}