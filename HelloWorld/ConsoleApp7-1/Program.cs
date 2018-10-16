using System;


namespace ConsoleApp7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            // int b = a.Value;
            // int b = (int)a;
            // Console.WriteLine("Value of b is {0}", b);

            int b;
            if (a.HasValue) b = a.Value;
            else b = 0;
            Console.WriteLine("Value of b is {0}", b);

            int c = a ?? 0;
            Console.WriteLine("Value of c is {0}", c);
            Console.ReadLine();
        }
    }
}
