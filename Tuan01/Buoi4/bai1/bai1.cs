using System;
namespace Tuan1.Buoi4
{
    class bai1
    {
        static void Main (String[] args)
        {
            double ly;
            double toan;
            double hoa;
            Console.WriteLine("Moi ban nhap diem toan, ly, hoa: ");
            toan = double.Parse(Console.ReadLine()!);
            ly = double.Parse(Console.ReadLine()!);
            hoa = double.Parse(Console.ReadLine()!);
            double dtb;
            dtb = (toan * 2 + ly * 3 + hoa) /6;
            if (dtb >= 8 && dtb <= 10)
            {
                Console.WriteLine($"Ban co diem trung binh {dtb} duoc xep loai gioi");
            }
            if (dtb >= 6.5 && dtb < 8)
            {
                Console.WriteLine($"Ban co diem trung binh {dtb} duoc xep loai kha");
            }
            if (dtb >= 5 && dtb < 6.5)
            {
                Console.WriteLine($"Ban co diem trung binh {dtb} duoc xep loai Trung binh");
            }
            if (dtb < 5)
            {
                Console.WriteLine($"Ban co diem trung binh {dtb} duoc xep loai yeu");
            }
        }
    }
}