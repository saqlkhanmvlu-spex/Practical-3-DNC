using System;

class Program
{
    // Delegate
    public delegate void Message();

    // Event
    public static event Message ShowMessage;

    static void Main()
    {
        ShowMessage += Display;
        ShowMessage();
    }

    static void Display()
    {
        Console.WriteLine("Hello! Delegate and Event Example.");
    }
}
