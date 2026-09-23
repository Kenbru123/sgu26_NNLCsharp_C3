using System;
using System.Collections.Generic;

namespace Tuan02.TH1
{
    class Bai17
    {
        static int[,] TaoMang(int n, int m)
        {
            int[,] a = new int[n, m];
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i,j] = rd.Next(10,101);
                }
            }
            return a;
        }
        static void InMang(int[,] a)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void TachChanLe(
            int[,] a,
            out List<int> mangChan,
            out List<int> mangLe)
        {
            mangChan = new List<int>();
            mangLe = new List<int>();
            int n = a.GetLength(0);
            int m = a.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(a[i, j] % 2 == 0)
                        mangChan.Add(a[i, j]);
                    else
                        mangLe.Add(a[i, j]);
                }
            }
        }
        public static void Main (string[] args)
        {
            Console.WriteLine("nhap n: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.WriteLine("nhap m: ");
            int m = int.Parse(Console.ReadLine()!);
            int[,] a = TaoMang(n, m);
            Console.WriteLine("\nMang A: ");
            InMang(a);
            TachChanLe(a, out List<int> mangChan, out List<int> mangLe);
            Console.WriteLine("\nMang so chan: ");
            foreach (int x in mangChan)
            {
                Console.WriteLine(x +" ");
            }
            Console.WriteLine("\nMang so le: ");
            foreach (int x in mangLe)
            {
                Console.WriteLine(x + " ");
            }
        }
    }
}