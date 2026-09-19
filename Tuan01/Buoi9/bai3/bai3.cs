using System;
namespace Buoi08.Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Moi ban nhap so luong phan tu: ");
            n = int.Parse(Console.ReadLine());

            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu {0}: ", i);
                a[i] = double.Parse(Console.ReadLine());
            }
            int demDuong = 0;
            int demAm = 0;
            int demKhong = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > 0)
                {
                    demDuong++;
                }
                else if (a[i] < 0)
                {
                    demAm++;
                }
                else
                {
                    demKhong++;
                }
            }
            Console.WriteLine(
                "Day so co {0} so am, {1} so khong va {2} so duong.",
                demAm, demKhong, demDuong);
        }
    }
}