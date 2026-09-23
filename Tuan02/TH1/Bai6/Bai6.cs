using System;

namespace Tuan02.TH1
{
    class Bai6
    {
        static int TimMax(int a, int b, int c)
        {
            int max = a;
            if (b > max)
                max = b;
            
            if (c > max)
                max = c;

            return max;
        }
        public static void Main (string[] args)
        {
            Console.WriteLine("Nhap a:");
            int a = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Nhap b:");
            int b = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Nhap c:");
            int c = int.Parse(Console.ReadLine()!);

            int max = TimMax(a, b, c);
            Console.WriteLine($"Gia tri lon nhat la: {max}");
        }
    }
}