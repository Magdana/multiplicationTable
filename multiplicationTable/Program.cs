using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("enter the number ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("multiplication table " + "on " + num);


        for (int i = 0; i <=10; i++)
        {
            Console.WriteLine(num + "*" + i + "=" + (num * i));
        }
    }
}