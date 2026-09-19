using System;
namespace NMLT.Buoi07
{
    public class KiemTraSoHoanHao
    {
        public static bool laSoHoanHao(int n)
        {
            int i;
            int tong = 0;
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                    tong = tong + i;
            }
            return tong == n;
        }

        public static void Main(string[] args)
        {
            int n;
            bool kq;
            Console.Write("Moi ban nhap n: ");
            n = int.Parse(Console.ReadLine());
            kq = laSoHoanHao(n);
            if (kq)
                Console.WriteLine("{0} la so hoan hao.", n);
            else
                Console.WriteLine("{0} khong la so hoan hao.", n);
        }
    }
}