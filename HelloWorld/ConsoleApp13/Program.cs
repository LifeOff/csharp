using System;


namespace ConsoleApp13
{
    class ParamsTest
    {
        static void Main(string[] args)
        {
            ParamsTest p = new ParamsTest();
            // 명명된 인수
            Console.WriteLine( p.Sum(j : 1, i:2) ); // 파라미터 넣는 곳을 변경할 수있음
            Console.WriteLine(p.Sum(j: 2));
            Console.WriteLine(p.Sum());
            //Console.WriteLine(p.Sum(1, 2, 9));
        }
        int Sum(int i  = 0, int j = 0) // 선택적 인수 (값을 안주면 값을 정해서 준다)
        {
            Console.WriteLine("i={0}, j={1}", i, j);
            return i + j;
        }
        /*
        int Sum(params int [] iArray)
        {
            int sum = 0;
            foreach (int i in iArray) sum += i;
            return sum;
        }
        */
    }
}
