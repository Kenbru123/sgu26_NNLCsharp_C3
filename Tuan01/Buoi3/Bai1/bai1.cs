using System;

namespace Tuan01.Buoi3
{
    class bai1
    {
        static void Main (string [] args)
        {
            int a, b, c, d, e, max, min;
            Console.WriteLine("Moi ban nhap 5 so a, b, c, d, e: ");
            string[] input = Console.ReadLine()!.Split();
            a = int.Parse(input[0]);
            b = int.Parse(input[1]);
            c = int.Parse(input[2]);
            d = int.Parse(input[3]);
            e = int.Parse(input[4]);
            
            max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;
            
            min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            if (d < min) min = d;
            if (e < min) min = e;

            Console.WriteLine($"Gia tri lon nhat cua {a}, {b}, {c}, {d}, {e} la {max}");
            Console.WriteLine($"Gia tri nho nhat cua {a}, {b}, {c}, {d}, {e} la {min}");
        }
    }
}