using System;
namespace buoi08.bai1
{
    class tinhgiaithua
    {
        static int giaithua(int n, int k)
        {
            if (k == 0 || k == n)
                return 1;
            else
                return giaithua(n - 1, k - 1) + giaithua(n - 1, k);
        }
        static void Main(string[] args)
        {
            int n, k;
            Console.WriteLine("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap k: ");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("To hop chap {0} cua {1} la: {2}", k, n, giaithua(n, k));
        }
    }
}
