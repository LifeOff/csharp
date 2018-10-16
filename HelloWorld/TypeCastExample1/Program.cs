using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            short a = 10;
            int b = a;
            int c = 50000; //이진수로 “0000 0000 0000 0000 1100 0011 0101 0000”
                           // 이진수 맨 앞자리는 부호비트
            try
            {
               // short d = (short)c; // 형변환  1100 0011 0101 00050로 바뀜 (부호가 바뀌는걸 overflow)
                short d = checked ((short)c);
                Console.WriteLine("Short : {0}", d);
            }
            catch(Exception e)
            {
                // Console.WriteLine("Short : {0}", d);
                Console.WriteLine("예외 : {0}", e.StackTrace);
                Console.WriteLine("예외 : " + e.StackTrace); // 같은 결과
            }

            
            

        }
    }
}
