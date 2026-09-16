using System;

namespace Tuan01.Buoi3
{
    class bai4
    {
        static void Main (string [] args)
        {
            int thang;
            string tenThang;

            Console.WriteLine("Moi ban nhap vao thang: ");
            thang = int.Parse(Console.ReadLine()!);

            switch (thang)
            {
                case 1:
                    tenThang = "january";
                    break;

                case 2:
                    tenThang = "February";
                    break;

                case 3:
                    tenThang = "March";
                    break;

                case 4:
                    tenThang = "April";
                    break;

                case 5:
                    tenThang = "May";
                    break;

                case 6:
                    tenThang = "June";
                    break;

                case 7:
                    tenThang = "July";
                    break;

                case 8:
                    tenThang = "August";
                    break;

                case 9:
                    tenThang = "September";
                    break;

                case 10:
                    tenThang = "October";
                    break;

                case 11:
                    tenThang = "November";
                    break;
                
                case 12:
                    tenThang = "December";
                    break;

                default:
                    tenThang = "Khong hop le";
                    break;
            }
            if (thang >= 1 && thang <= 12)
            {
                Console.WriteLine($"Tieng anh cua thang {thang} la {tenThang}");
            }
            else
            {
                Console.WriteLine($"Thang k hop le");
            }
        }
    }
}