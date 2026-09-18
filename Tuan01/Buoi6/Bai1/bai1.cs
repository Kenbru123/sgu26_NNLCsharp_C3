using System;

namespace Tuan1.Buoi6
{
    class bai1
    {
        static void Main(string[] args)
        {
            int h;
            Console.Write("Moi ban nhap chieu cao h: ");
            h = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Chu I va U ung voi h = {h} la:");
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= h; j++)
                {
                    if (i == 1 || i == h || j == (h + 1) / 2)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }

                Console.Write("  ");

                for (int j = 1; j <= h; j++)
                {
                    if (j == 1 || j == h || i == h)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }

                Console.WriteLine();
            }
        }
    }
}