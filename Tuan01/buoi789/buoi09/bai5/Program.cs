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
                Console.Write("Phan tu {0}: ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            int soLuong = 0;
            int tong = 0;

            for (int i = 0; i < n; i++)
            {
                int demUoc = 0;
                for (int j = 1; j <= a[i]; j++)
                {
                    if (a[i] % j == 0)
                    {
                        demUoc++;
                    }
                }
                if (demUoc == 2)
                {
                    soLuong++;
                    tong = tong + a[i];
                }
            }
            if (soLuong > 0)
            {
                double trungBinh = (double)tong / soLuong;
                Console.WriteLine("So luong: " + soLuong);
                Console.WriteLine("Tong: " + tong);
                Console.WriteLine("Trung binh cong: " + trungBinh);
            }
            else
            {
                Console.WriteLine("Day khong co so nguyen to.");
            }
        }
    }
}
