using System;
using System.ComponentModel;

public class Mytest
{
    public int x = 1;
    public int y = 2;
    public bool b = false;
    public static int func(int a, int b)
    {
        return a + b;
    }
    public int func2(int a, int b)
    {
        return b*a + b+a;
    }
}



public class Myprogram
{
    static void Main(String[] args)
    {
        // Mytest RR;
        int[] number = { 5, 9, 6 };
        Mytest Mytest_Instance = new Mytest();
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
                Console.WriteLine(Mytest_Instance.func2(5, 2));
                string input = Console.ReadLine();
                Console.WriteLine("PRINT RESULT" + input);
            }

        }

    }
}