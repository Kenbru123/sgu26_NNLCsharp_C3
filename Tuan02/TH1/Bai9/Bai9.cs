using System;

namespace Tuan02.TH1
{
    class Bai9
    {
        static void TimMaxMin(double a, double b, double c, out double max, out double min)
        {
            max = a;
            min = a;

            if (b > max)
                max = b;
            if (c > max)
                max = c;
            if (b < min)
                min = b;
            if (c < min)
                min = c;
        } 

        public static void Main (string[] args)
        {
            Console.WriteLine("Nhap a: ");
            double a = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Nhap b: ");
            double b = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Nhap c: ");
            double c = double.Parse(Console.ReadLine()!);

            double max, min;
            TimMaxMin(a, b, c, out max, out min);

            Console.WriteLine($"Gia tri lon nhat la: {max}");
            Console.WriteLine($"Gia tri nho nhat la: {min}");
        }
    }
}