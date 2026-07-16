using System;

public interface A
{
    void Fun1();
}

public interface B
{
    void Fun2();
}
public class C : A, B
{
    public void Fun1()
    {
        Console.WriteLine("Method of Interface A");
    }

    public void Fun2()
    {
        Console.WriteLine("Method of Interface B");
    }
}

class InterfaceDemo
{
    public static void Main(string[] args)
    {
        C obj = new C();

        obj.Fun1();
        obj.Fun2();
    }
}
