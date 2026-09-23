using System;

namespace Tuan02.TH1
{
    class SinhVien
    {
        public double Mssv;
        public string hoTen;
        public string namhoc;
    }
    class Bai13
    {
        public static void Main (string[] args)
        {
            SinhVien sv = new SinhVien();

            Console.WriteLine("Nhap mssv: ");
            sv.Mssv = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Nhap hoten sinh vien: ");
            sv.hoTen = Console.ReadLine()!;
            Console.WriteLine("Nhap nam hoc cua sinh vien: ");
            sv.namhoc = Console.ReadLine()!;
            
            Console.WriteLine("\nThong tin sinh vien");
            Console.WriteLine($"Mssv la: {sv.Mssv}");
            Console.WriteLine($"hoten sinh vien la: {sv.hoTen}");
            Console.WriteLine($"Nam hoc cua sinh vien la: {sv.namhoc}");
        }
    }
}