﻿using System;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(+3);
            Console.WriteLine(3 + 3);
            Console.WriteLine(3 + .3);
            Console.WriteLine("3" + "3"); // 문자열
            Console.WriteLine(3.0 + "3"); // 문자열

            //!는 피연산자를 부정하는 연산자. 
            Console.WriteLine(!true);

            //~ : 비트 보수 연산을 수행, 각 비트를 반전 
            byte x = 10;
            Console.WriteLine(~x); // 0000 1010 이 1111 0101로 바뀜

            Console.WriteLine(unchecked((short)50000)); //overflow




        }
    }
}
