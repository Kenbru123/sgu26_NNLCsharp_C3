using System;
namespace Buoi08.Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Moi ban nhap so luong phan tu: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
              //  Console.Write("Phan tu {0}: ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Cac phan tu chan trong mang: ");
            for (int i = n - 1; i >= 0; i--)
            {
                if (a[i] % 2 == 0)
                {
                    Console.Write(a[i] + " ");
                }
            }
        }
    }
}