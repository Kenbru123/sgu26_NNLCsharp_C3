using System;
namespace Tuan01.Buoi5
{
    class bai4
    {
        static void Main(String[] args)
        {
            double a;
            Console.WriteLine("Nhap vao so thuc a: ");
            a = double.Parse(Console.ReadLine()!);
            double result = 0;
            int n = 1;
            while (result <= a)
            {
                result += 1.0/n;
                n++;
            }
            Console.WriteLine($"n la: {n-1}");
        }
    }
}