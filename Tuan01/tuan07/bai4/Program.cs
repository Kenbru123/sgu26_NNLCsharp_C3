using System;

namespace NMLT.Buoi07
{
    class NgayTruoc
    {
        static void Main()
        {
            Console.Write("Moi ban nhap ngay: ");
            int ngay = int.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap thang: ");
            int thang = int.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap nam: ");
            int nam = int.Parse(Console.ReadLine());

            int ngayBanDau = ngay;
            int thangBanDau = thang;
            int namBanDau = nam;

            if (ngay > 1){
                ngay--;
            }
            else{
                if (thang > 1){
                    thang--;
                }
                else{
                    thang = 12;
                    nam--;
                }

                if (thang == 4 || thang == 6 || thang == 9 || thang == 11){
                    ngay = 30;
                }
                else if (thang == 2){
                    if ((nam % 400 == 0) || 
                        (nam % 4 == 0 && nam % 100 != 0))
                    {
                        ngay = 29;
                    }
                    else
                    {
                        ngay = 28;
                    }
                }
                else
                {
                    ngay = 31;
                }
            }
            Console.WriteLine("Ngay truoc ngay " +
                ngayBanDau + "/" + thangBanDau + "/" + namBanDau +
                " la ngay " +
                ngay + "/" + thang + "/" + nam + ".");
        }
    }
}