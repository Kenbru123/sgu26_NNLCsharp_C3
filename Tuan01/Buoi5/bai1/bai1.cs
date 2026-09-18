using System;
namespace Tuan01.Buoi5
{
    class bai1
    {
        static void Main(String[] args)
        {
            int n;
            Console.WriteLine("Moi ban nhap so n: ");
            n = int.Parse(Console.ReadLine()!);
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            String nhan = "1";
            for (int i = 2; i <= n; i++)
            {
                nhan = nhan + "." + i;
            }
            Console.WriteLine($"{n}! = {nhan} = {result}");
        }
    }
}