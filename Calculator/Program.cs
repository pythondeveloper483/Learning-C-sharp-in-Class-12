using System;
class Calculator
{
    public static void Main(String[] args)
    {
        double num1, num2, sum, subtract, multiply, division, square;
        Console.Write("Enter the number.: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the number.: ");
        num2 = Convert.ToDouble(Console.ReadLine());
        sum = num1+num2;
        Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
        subtract = num1-num2;
        Console.WriteLine($"The subtract of {num1} and {num2} is {subtract}");
        multiply = num1*num2;
        Console.WriteLine($"The multiply of {num1} and {num2} is {multiply}");
        division = (double)num1/num2;
        Console.WriteLine($"The division of {num1} and {num2} is {division}");
        Console.Write("If you want to continue..... Then type [y/n]: ");
        string? user = Console.ReadLine();
        if(user?.ToLower() == "y")
        {
            square = num1*num1;
            Console.WriteLine($"The square of {num1} is {square}");
            Console.WriteLine("Thanks for visiting our calculator💖✌️🏆. ");
        }
    }
}
