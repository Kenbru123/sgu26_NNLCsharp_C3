using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiThucHanhLinQ;
class Program
{
    static void Main ()
    {
        Bai21();
    }
    static void Bai21()
    {
        int[] mangso = {50, 42, 16, 3, 9, 8, 12, 7, 24, 0};
        
        ///cau a
        Console.WriteLine("a. cac phan tu chia het cho 4 va 3: ");
        var cauA_Query =
            from x in mangso
            where x % 4 == 0 && x % 3 == 0
            select x;
        Console.WriteLine("Query Syntax: ");
        foreach (var x in cauA_Query)
        {
            Console.WriteLine(x + " ");
        }

        Console.WriteLine();

        // Method syntax
        var cauA_Method = mangso.Where(x => x % 4 == 0 && x % 3 ==0);

        Console.WriteLine("Method Syntax: ");
        foreach (var x in cauA_Method)
        {
            Console.WriteLine(x + " ");
        }
        Console.WriteLine("\n");

        //cau b
        Console.WriteLine("b. cac phan tu nho hon hoac bang 3: ");
        // Query syntax
        var cauB_Query =
            from x in mangso
            where x <= 3
            select x;
        Console.WriteLine("Query syntax: ");
        foreach (var x in cauB_Query)
        {
            Console.WriteLine(x + " ");
        }
        Console.WriteLine();

        // method syntax
        var cauB_Method = mangso.Where( x => x <= 3);

        Console.WriteLine ("Method synlax: ");
        foreach (var x in cauB_Method)
        {
            Console.WriteLine(x + " ");
        }
        Console.WriteLine("\n");

        //cau c
        Console.WriteLine("c. Day moi: ");
        //query syntax
        var cauC_Query =
            from x in mangso
            select x % 2 == 0 ? x / 2 : x;

        Console.WriteLine("Query syntax: ");
        foreach (var x in cauC_Query)
        {
            Console.WriteLine(x + " ");
        }
        Console.WriteLine();

        //method syntax
        var cauC_Method = mangso.Select(x => x % 2 == 0 ? x / 2 :x);
        Console.WriteLine("Method syntax: ");
        foreach (var x in cauC_Method)
        {
            Console.WriteLine(x + " ");
        }
    }
}