using System;

namespace Tuan02.TH1
{
    class NhanVien
    {
        public string hoTen;
        public double Luong;
        public int Songayvang;
    }
    class Bai14
    {
        public static void Main (string[] args)
        {
            NhanVien nv = new NhanVien();
            Console.WriteLine("Nhap hoten nhan vien: ");
            nv.hoTen = Console.ReadLine()!;
            Console.WriteLine("Nhap muc luong: ");
            nv.Luong = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Nhap so ngay vang: ");
            nv.Songayvang = int.Parse(Console.ReadLine()!);
            double LuongDuocNhan = nv.Luong - nv.Songayvang * 100000;

            Console.WriteLine($"\n THONG TIN NHAN VIEN");
            Console.WriteLine($"ho ten: {nv.hoTen}");
            Console.WriteLine($"muc luong: {nv.Luong}");
            Console.WriteLine($"so ngay vang: {nv.Songayvang}");
            Console.WriteLine($"Luong duoc nhan: {LuongDuocNhan}");
        }
    }
}