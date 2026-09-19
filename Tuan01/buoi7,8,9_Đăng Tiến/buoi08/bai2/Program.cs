using System;
namespace buoi08.bai2
{
    class Program
    {
        static bool sohoanhao(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    sum += i;
            }
            return sum == n;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Cac so hoan hao trong doan [1, " + n + "]: ");
            for (int i = 1; i <= n; i++)
            {
                if (sohoanhao(i))
                    Console.WriteLine(i);
            }
        }
    }
}
