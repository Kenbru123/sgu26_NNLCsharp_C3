using System;

namespace Tuan1.Buoi1
{
    class Bai2
    {
        static void Main ( string[] args)
        {
            double R, S, P;
            Console.WriteLine("Nhap ban kinh R: ");
            R = double.Parse (Console.ReadLine()!);
            S = 3.14 * R * R;
            P = 2 * 3.14 * R;
            Console.WriteLine("Dien tich S = {0:F1}", S);
            Console.WriteLine("Chu vi P = {0:F1}", P);
        }
    }

}