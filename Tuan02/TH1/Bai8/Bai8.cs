using System;

namespace Tuan02.TH1
{
    class Bai8
    {
        static void HoanVi (ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        public static void Main (string[] args)
        {
            Console.WriteLine("Nhap a: ");
            double a = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Nhap b: ");
            double b = double.Parse(Console.ReadLine()!);

            Console.WriteLine($"Trc khi hoan vi: a = {a}, b = {b}");
            HoanVi (ref a, ref b);

            Console.WriteLine($"Sau khi hoan vi: a = {a}, b = {b}");
        }
    }
}