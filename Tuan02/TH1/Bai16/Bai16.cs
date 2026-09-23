using System;

namespace Tuan02.TH1
{
    class Bai16
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("Nhap so nguoi n: ");
            int n = int.Parse(Console.ReadLine()!);

            string[] hoTen = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap ho ten nguoi thu {i+1}: ");
                hoTen[i] = Console.ReadLine()!;
            }
            Array.Sort(hoTen);
            Console.WriteLine("\nDanh sach sau khi sap xep:");
            foreach (string ten in hoTen)
            {
                Console.WriteLine(ten);
            }
        }
    }
}