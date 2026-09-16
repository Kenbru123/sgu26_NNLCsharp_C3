using System;

namespace Tuan1.Buoi2
{
    class bai1
    {
        static void Main (string [] args)
        {
            int a, b, tong;
            Console.WriteLine("Moi ban nhap so a: ");
            a = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Moi ban nhap so b: ");
            b = int.Parse(Console.ReadLine()!);

            if (a <= b)
            {
                tong = b * (b+1) / 2 - (a-1) * a / 2;
                Console.WriteLine($"Tong cac so trong doan [{a}, {b}] la {tong}");
            }
            else
            {
                Console.WriteLine("Khong hop le, phai nhap a <= b");
            }
        }
    }
}