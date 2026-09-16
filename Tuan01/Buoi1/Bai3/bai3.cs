using System;

namespace Tuan01.Buoi1
{
    class bai3
    {
        static void Main ( string [] args)
        {
            int h, m, s, tongGiay;
            Console.WriteLine("Nhap so gio: ");
            h = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Nhap so phut: ");
            m = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Nhap so giay: ");
            s = int.Parse(Console.ReadLine()!);
            tongGiay = h * 3600 + m * 60 + s;
            Console.WriteLine(
                $"Tong so giay cua {h}:{m}:{s} la {tongGiay} giay");
        }
    }
}