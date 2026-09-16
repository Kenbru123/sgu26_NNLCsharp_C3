using System;

namespace Tuan01.Buoi3
{
    class bai3
    {
        static void Main (string[] args)
        {
            double a, b, c, delta, x1, x2;
            Console.WriteLine("Moi ban nhap he so a, b, c: ");
            string[] input = Console.ReadLine()!.Split();
            a = double.Parse(input[0]);
            b = double.Parse(input[1]);
            c = double.Parse(input[2]);

            if (a == 0)
            {
                Console.WriteLine("Day k phai ptrinh bac 2");
            }
            else
            {
                delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    Console.WriteLine("Ptrinh vo nghiem");
                }
                else if (delta == 0)
                {
                    x1 = - b / (2 * a);
                    Console.WriteLine($"Ptrinh co nghiem kep x ={x1:F2}");
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Ptrinh co 2 nghiem, x1 = {x1:F2}, x2 = {x2:F1}");
                }
            }
        }
    }
}