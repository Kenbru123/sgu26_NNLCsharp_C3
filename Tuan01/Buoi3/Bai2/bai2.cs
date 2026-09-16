using System;

namespace Tuan01.Buoi3
{
    class bai2
    {
        static void Main (string [] args)
        {
            double x, f1, f2;

            Console.WriteLine("Moi ban nhap so thuc x: ");
            x = double.Parse(Console.ReadLine()!);
            
            if (x <= 0)
            {
                f1 = 0;
            }
            else if (x <= 1)
            {
                f1 = x;
            }
            else
            {
                f1 = x * x * x * x;
            }

            if (x <= 2)
            {
                f2 = x * x + 4 * x + 5; 
            }
            else
            {
                f2 = 1 / (x * x + 4 * x + 5);
            }
            Console.WriteLine($"f1({x}) = {f1}");
            Console.WriteLine($"f2({x}) = {f2}");
        }
    }
}