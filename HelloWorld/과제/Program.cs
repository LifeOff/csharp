using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 과제
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.다음과 같은 결과를 출력하는 C# 프로그램을 작성하세요.
            //     2 4 6 8 10

            /*int num = 10;
            for(int i = 1; i <= num; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine("{0}", i);
                }
                
            }*/
            //2.숫자를 입력하면 다음과 같이 출력하는 C# 프로그램을 작성하세요. 



            //[출력]

            //입력숫자: 10

            //10까지의 숫자 : 1 2 3 4 5 6 7 8 9 10

            //10까지의 숫자합은 : 55

            /*string str = Console.ReadLine();
            int num2 = int.Parse(str);
            int all = 0; int j = 0;

            for (int i = 1; i<=num2; i++)
            {
                j = j + i;

                Console.Write("{0}", j);
                j = 0;
                all += i;
                
            }
            Console.WriteLine();
            Console.WriteLine("{0}까지의 숫자합은 : {1}", num2, all);
            */

            // 3. 10개의 숫자를 입력받아 입력받은 수를 출력하고 합, 평균을 구해 출력하세요.
            /*
            Console.WriteLine("Input the 10 numbers :");
            int all = 0; float avg = 0;

            for(int i = 1; i <= 10; i++)
            {
                string str = Console.ReadLine();
                int num = int.Parse(str);
                Console.WriteLine("숫자-{0} : {1}",i, num);
                all += num;
            }
            avg = (float)(all / 10.0);
            Console.WriteLine("합: {0}", all);
            Console.WriteLine("평균: {0}", avg);
            */

            Console.WriteLine("출력을 원하는 구구단 단수 :");
            string str = Console.ReadLine();
            int num = int.Parse(str);

            for (int i = 2; i <=9; i++)
                {
                 for(int j = 1; j <=num; j++)
                {
                    Console.Write("{0} X {1} = {2}    ", j, i, i * j);
                    
                }
                Console.WriteLine("  ");
            }
           }

        }
    }
