using System;
using System.Text;

namespace Tuan02.TH1
{
    class Bai11
    {
        static string DaoChuoi(string s)
        {
            StringBuilder kq = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                kq.Append(s[i]);
            }
            return kq.ToString();
        }
        public static void Main (string[] args)
        {
            Console.WriteLine("Nhap chuoi: ");
            string s = Console.ReadLine()!;

            Console.WriteLine($"Chuoi dao: {DaoChuoi(s)}");
        }
    }
}