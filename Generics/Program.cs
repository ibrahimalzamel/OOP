using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> citys1 = new List<string>();
            citys1.Add("konya");
            citys1.Add("konya");
            citys1.Add("konya");
            citys1.Add("konya");
            citys1.Add("konya");
            Console.WriteLine(citys1.Count);


            List<string> citys2 = new List<string>();
            citys1.Add("konya");
            citys1.Add("konya");
            citys1.Add("konya");
            citys1.Add("konya");
            citys1.Add("konya");
            Console.WriteLine(citys2.Count);

        }
    }
}
