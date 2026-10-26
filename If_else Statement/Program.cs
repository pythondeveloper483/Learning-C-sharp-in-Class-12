using System;
public class ifExample
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num%2==0)
        {
            Console.WriteLine($"{num} is even number.");
        }
        else
        {
            Console.WriteLine($"{num} is odd number.");
        }
    }
}
