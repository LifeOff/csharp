using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int num = int.Parse(str);
            int all = 0;
            string mak = "";

            for(int i = 0; num != 0;)
            {
                all = 0;
                if (num != 0)
                {
                    all = num % 2;
                    mak = (num % 2) + mak;
                    num = num / 2;
                }
                else
                {
                }
            }
            Console.Write("{0}", mak);

        }
    }
}
