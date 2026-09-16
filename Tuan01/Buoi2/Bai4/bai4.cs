using System;

namespace Tuan01.Buoi2
{
    class bai4
    {
        static void Main (string [] args)
        {
            int thang;
            Console.WriteLine("Moi ban nhap thang: ");
            thang = int.Parse(Console.ReadLine()!);

            if (thang >= 1 && thang <= 3)
            {
                Console.WriteLine($"Thang {thang} thuoc qui 1");
            }
            else if (thang >= 4 && thang <= 6)
            {
                Console.WriteLine($"Thang {thang} thuoc qui 2");
            }
            else if (thang >= 7 && thang <= 9)
            {
                Console.WriteLine($"Thang {thang} thuoc qui 3");
            }
            else if (thang >= 10 && thang <= 12)
            {
                Console.WriteLine($"Thang {thang} thuoc qui 4");
            }
            else
            {
                Console.WriteLine("Thang khong hop le");
            }
        }
    }
}