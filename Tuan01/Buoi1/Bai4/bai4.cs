using System;

namespace Tuan1.Buoi1
{
    class bai4
    {
        static void Main( string [] args)
        {
            int tongGiay, h, m, s;
            Console.WriteLine("Nhap tong so giay: ");
            tongGiay = int.Parse(Console.ReadLine()!);

            h = tongGiay / 3600;
            m = (tongGiay % 3600) / 60;
            s = tongGiay % 60;

            Console.WriteLine($"{tongGiay} giay co dang {h}:{m}:{s}");
        }
    }
}