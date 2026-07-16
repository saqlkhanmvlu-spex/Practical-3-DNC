using System;
public class ABC
{
    ABC(int num1, int num2)
    {
        Console.WriteLine("Subtraction of Two Numbers : " + (num1 - num2));
    }
    ABC(int num, int num1, int num2)
    {
        Console.WriteLine("Addition of 3 Numbers : " + (num + num1 + num2));
    }
    public static void Main(string[] args)
    {
        ABC obj = new ABC(66, 7);
        ABC obj1 = new ABC(11, 12, 13);
    }
}
