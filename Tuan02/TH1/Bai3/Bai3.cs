using System;

namespace Tuan02.TH1
{
    class Bai3
    {
        public static void Main (string [] args)
        {
            int x, y;
            Console.WriteLine("Nhap so nguyen x: ");
            x = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Nhap so nguyen y: ");
            y = int.Parse(Console.ReadLine()!);

            double ketqua = Math.Pow(x, y);
            
            Console.WriteLine($"ket qua {x} mu {y} la: {ketqua}");
        }
    }
}