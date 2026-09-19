using System;
namespace buoi08.bai3
{
    class rutgonphanso
    {
        static void Main(string[] args)
        {
            int tu, mau;
            Console.WriteLine("Nhap tu so: ");
            tu = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so: ");
            mau = int.Parse(Console.ReadLine());
            int a = tu, b = mau;
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            tu /= a;
            mau /= a;
            Console.WriteLine("Phan so rut gon: " + tu + "/" + mau);
        }
    }
}
