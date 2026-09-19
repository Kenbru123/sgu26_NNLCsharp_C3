using System;
namespace Buoi08.Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Moi ban nhap so nguyen n: ");
            n = int.Parse(Console.ReadLine());
            int[] dem = new int[10];
            while (n > 0)
            {
                int chuSo = n % 10;
                dem[chuSo]++;
                n = n / 10;
            }
            for (int i = 0; i <= 9; i++)
            {
                if (dem[i] > 0)
                {
                    Console.WriteLine("Chu so {0} xuat hien {1} lan.", 
                        i, dem[i]);
                }
            }
        }
    }
}