using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("nermin");
            isimler.Add("ibrahim");
            isimler.Add("abdullah");
            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
