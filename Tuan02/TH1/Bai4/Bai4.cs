using System;

namespace Tuan02.TH1
{
    class Bai4
    {
        public static void Main (string [] args)
        {
            int x, y;
            Console.WriteLine("Nhap so nguyen x: ");
            bool ktx = int.TryParse(Console.ReadLine()!, out x);
            Console.WriteLine("Nhap so nguyen y: ");
            bool kty = int.TryParse(Console.ReadLine()!, out y);

            if (!ktx || !kty)
            {
                Console.WriteLine("x hoac y khong phai la so nguyen!");
            }
            else
            {
                double ketQua = Math.Pow(x, y);

                Console.WriteLine($"Ket qua {x} mu {y} la: {ketQua}");
            }
        }
    }
}