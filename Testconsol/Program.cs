using System;
public class Test
{
    public static void Main(string[] args)
    {
        int a = 20;
        int b = 10;
        int sum = 0;
        Addition(a, b, sum);
        Console.WriteLine(sum);
    }
    public static void Addition(int a, int b, int sum)
    {
        sum=a+b;
        Console.WriteLine(sum);
    }
}
