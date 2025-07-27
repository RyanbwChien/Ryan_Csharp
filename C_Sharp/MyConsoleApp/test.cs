using System;

public class Mytest
{
    public int x = 1;
    public int y = 2;
    public static int func(int a, int b)
    {
        return a + b;
    }
}



class Myprogram
{
    static void Main()
    {
        // Mytest RR;
        int[] number = { 5, 9, 6 };
        for (int i = 0; i <= 5; i++)
        {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Hello World");
                }
                
                else
                {
                    Console.WriteLine("Hello World");
                    Console.WriteLine(Mytest.func(5, 2));
                    
                }

        }

    }
}