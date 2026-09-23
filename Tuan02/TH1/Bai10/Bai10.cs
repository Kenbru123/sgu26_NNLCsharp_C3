using System;

namespace Tuan02.TH1
{
    class Bai10
    {
        static bool KTDoiXung(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                    return false;

                left++;
                right--;
            }
            return true;
        }
        public static void Main (string[] args)
        {
            Console.WriteLine("Nhap chuoi:");
            string s = Console.ReadLine()!;

            if(KTDoiXung(s))
                Console.WriteLine("Chuoi doi xung");
            else
                Console.WriteLine("Chuoi khong doi xung");
        }
    }
}