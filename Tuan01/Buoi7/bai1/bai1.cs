using System;
namespace Tuan1.Buoi7
{
    class bai1
    {
    public static void inhinhtamgiac(int vtx, int vty, int h)
{
    int i, j;
    for (i = 1; i <= h; i++)
    {
        Console.SetCursorPosition(vtx, vty + i - 1);
        for (j = 1; j <= h - i; j++)
        {
            Console.Write("{0, 2}", ' ');
        }
        if (i == 1)
        {
            Console.Write("{0, 2}", '*');
        }
        else if (i == h)
        {
            for (j = 1; j <= 2 * h - 1; j++)
            {
                Console.Write("{0, 2}", '*');
            }
        }
        else
        {
            Console.Write("{0, 2}", '*');
            for (j = 1; j <= 2 * i - 3; j++)
            {
                Console.Write("{0, 2}", ' ');
            }
            Console.Write("{0, 2}", '*');
        }
    }
    Console.SetCursorPosition(0, vty + h);
}        public static void Main(string[] args)
        {
            int h;
            Console.Write("Moi ban nhap chieu cao h: ");
            h = int.Parse(Console.ReadLine()!);
            Console.WriteLine("h = {0}", h);
            inhinhtamgiac(Console.CursorLeft, Console.CursorTop, h);
            Console.WriteLine("h = {0}", h + 2);
            inhinhtamgiac(Console.CursorLeft, Console.CursorTop, h + 2);
            Console.WriteLine("h = {0}", h + 4);
            inhinhtamgiac(Console.CursorLeft, Console.CursorTop, h + 4);
        }
    }
}