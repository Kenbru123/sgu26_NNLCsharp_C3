using System;
namespace Tuan02.TH1
{
    class Bai15
    {
        static int[] NhapMang()
        {
            Console.WriteLine("Nhap so phan tu n: ");
            int n = int.Parse(Console.ReadLine()!);

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine()!);
            }
            return a;
        }
        static void InMang (int[] a)
        {
            Console.WriteLine("Mang vua nhap: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + " ");
            }
            Console.WriteLine();
        }
        static void TimMaxMin (int[] a, out int max, out int min)
        {
            max = a[0];
            min = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                    max  = a[i];

                if (a[i] < min)
                    min = a[i];
            }
        }
        static bool LaSoNguyenTo(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static List<int> MangSoNguyenTo(int[] a)
        {
            List<int> ds = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (LaSoNguyenTo(a[i]))
                {
                    ds.Add(a[i]);
                }
            }
            return ds;
        }
        public static void Main (string[] args)
        {
            int[] a = NhapMang();
            InMang(a);
            TimMaxMin(a, out int max, out int min);
            Console.WriteLine($"Phan tu lon nhat: {max}");
            Console.WriteLine($"Phan tu nho nhat: {min}");

            List<int> soNguyenTo = MangSoNguyenTo(a);
            Console.WriteLine("Mang cac so nguyen to:");
            foreach (int x in soNguyenTo)
            {
                Console.WriteLine(x + " ");
            }
        }
    }
}