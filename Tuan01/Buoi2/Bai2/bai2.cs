using System;

namespace Tuan01.Buoi2
{
    class bai2
    {
        static void Main (string [] args)
        {
            double a, a2, a4, a5, a8, a16, a17;
            Console.WriteLine("Moi ban nhap so thuc a: ");
            a = double.Parse(Console.ReadLine()!);

            a2 = a * a;
            a4 = a2 * a2;
            a5 = a4 * a;
            a8 = a4 * a4;
            a16 = a8 * a8;
            a17 = a16 * a;

            Console.WriteLine($"Ket qua: {a}^2={a2}, {a}^5={a5}, {a}^17={a17}");
        }
    }
}