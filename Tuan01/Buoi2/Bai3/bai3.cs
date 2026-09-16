using System;

namespace Tuan01.Buoi2
{
    class bai3
    {
        static void Main (string[] args)
        {
            double x, x2, x3, f;
            Console.WriteLine("Moi ban nhap so thuc x: ");
            x = double.Parse(Console.ReadLine()!);
            x2 = x * x;
            x3 = x2 * x;

            f = 1 + 2 * x + 3 * x2 - 4 * x3;
            Console.WriteLine($"f({x}) = {f}");
        }
    }
}