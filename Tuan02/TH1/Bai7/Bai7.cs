using System;

namespace Tuan02.TH1
{
    class Bai7
    {
        static bool SoNguyenTo(int n)
        {
            if (n < 2)
                return false;
            
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public static void Main (string[] args)
        {
            Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine()!);

            if (SoNguyenTo(n))
                Console.WriteLine($"{n} la so nguyen to");
            else
                Console.WriteLine($"{n} khong phai so nguyen to");
        }
    }
}