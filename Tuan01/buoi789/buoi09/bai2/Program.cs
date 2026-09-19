using System;
namespace Buoi08.Bai2
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
                Console.Write("Phan tu {0}: ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            int viTriDau = -1;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    viTriDau = i;
                    break;
                }
            }
            int viTriCuoi = -1;
            for (int i = n - 1; i >= 0; i--)
            {
                if (a[i] % 2 == 0)
                {
                    viTriCuoi = i;
                    break;
                }
            }
            if (viTriDau != -1)
            {
                Console.WriteLine(
                    "Gia tri chan dau tien o vi tri {0} co gia tri {1}.",
                    viTriDau, a[viTriDau]);
            }
            else
            {
                Console.WriteLine("Mang khong co gia tri chan.");
            }
            if (viTriCuoi != -1)
            {
                Console.WriteLine(
                    "Gia tri chan cuoi cung o vi tri {0} co gia tri {1}.",
                    viTriCuoi, a[viTriCuoi]);
            }
        }
    }
}