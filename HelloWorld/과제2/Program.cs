using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 과제2
{
    /* 2번
    class ForLoop
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i<=2; i++)                
            {
                int j = 0;
                j = i;
                Console.WriteLine("i = {0} and j = {1}", i, j);
            }
        }
    }
    */


    /* 3번
    class ForLoop
    {
        public static void Main(string[] args)
        {
            int i = 1;
            for (i = 1; i<=5;)
            {
                Console.WriteLine("C# For Loop: Iteration {0}", i);
                i++;
            }
        }
    }
    */

    /*
    // - 두 수의 입력은 콤마로 구분해서 Console.ReadLine으로 받으세요. 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("두수를 입력하세요.");
            Console.WriteLine("예 : 3,5");
            string str = Console.ReadLine();
            str.Trim();
            string[] strarr = str.Split(',');

            if (strarr.Length != 2) {
                Console.WriteLine("숫자2개를 콤마로 구분해서 입력하세요~");
                return;
            }

            int first, second;
            try
            {
                first = int.Parse(strarr[0]);//여기 채워주세요 ;   
                second = int.Parse(strarr[1]);//여기 채워주세요 ;
            }
            catch
            {
                Console.WriteLine("입력이 잘못되었습니다.");
                return;
            }
            Console.WriteLine("{0} + {1} = {2}", first, second, Calc(first, second, "+"));
            Console.WriteLine("{0} - {1} = {2}", first, second, Calc(first, second, "-"));
            Console.WriteLine("{0} * {1} = {2}", first, second, Calc(first, second, "*"));
            Console.WriteLine("{0} / {1} = {2}", first, second, Calc(first, second, "/"));
        }

        
        static double Calc(int first, int second, string op)
        {
            double result = 0;
            switch (op)
            {
                case "+":
                    result = first + second;
                    break;
                case "-":
                    result = first - second;
                    break;
                case "*":
                    result = first * second;
                    break;
                case "/":
                    result = first / second;
                    break;

            }
            return result;
        }  
        
    }
    */

    /*
    // 버블정렬 (오름차순)
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 30, 20, 79, 33, 46 };
            int save = 0;

            for(int i = 0; i <= a.Length - 1; i++)
            {
                for (int j = 0; j <= a.Length - 1; j++)
                {
                    if(a[i] < a[j])
                    {
                        save = a[i];
                        a[i] = a[j];
                        a[j] = save;
                        
                    }
                    else
                    {

                    }
                }
            }
            for(int i = 0; i <= a.Length-1; i++)
            {
                Console.Write("{0} ", a[i]);
            }
        }
    }
    */

    // 선택정렬
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {3, 2, 7, 5};

            for(int i = 0; i < a.Length - 1; i++)
            {
                int minindex = i;
                int save;
                for (int j = i+1; j < a.Length; j++)
                {
                    if(a[minindex] > a[j])
                    {
                        minindex = j;
                    }
                    save = a[minindex];
                    a[minindex] = a[i];
                    a[i] = save;
                }
            }
            foreach(int i in a)
            {
                Console.Write("{0}   ", i);
            }
        }
    }
}