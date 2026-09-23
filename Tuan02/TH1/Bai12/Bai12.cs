using System;

namespace Tuan02.TH1
{
    class Bai11
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("Nhap chuoi: ");
            string s = Console.ReadLine()!;

            Console.WriteLine($"Chuoi thuong: {s.ToLower()}");
            Console.WriteLine($"Chuoi hoa: {s.ToUpper()}");

            string[] cacTu = s.Split(' ',
                StringSplitOptions.RemoveEmptyEntries);
            
            Console.WriteLine($"So tu trong chuoi: {cacTu.Length}");
        }
    }
}