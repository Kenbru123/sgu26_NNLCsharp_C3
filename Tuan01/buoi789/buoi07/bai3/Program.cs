using System;
namespace NMLT.Buoi07
{
    class TinhSoPi
    {
        static void Main()
        {
            Console.Write("Moi ban nhap do sai so epsilon: ");
            double epsilon = double.Parse(Console.ReadLine());
            double pi = 0;
            int n = 0;
            while (4.0 / (2 * n + 1) >= epsilon)
            {
                double soHang = 4.0 / (2 * n + 1);

                if (n % 2 == 0)
                {
                    pi = pi + soHang;
                }
                else
                {
                    pi = pi - soHang;
                }
                n++;
            }
            double saiSo = Math.Abs(Math.PI - pi);
            Console.WriteLine("So pi tinh duoc la: " + pi);
            Console.WriteLine("Do sai so thuc te la: " + saiSo);
        }
    }
}