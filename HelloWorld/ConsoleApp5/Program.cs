using System;


namespace ConsoleApp5
{
    class AsTest
    {
        class Emp
        {
            public override string ToString()
            {
                return "Emp";
            }
        }
    class Programmer : Emp { }
    class Program
    {
        static void Main()
        {
            Programmer p = new Programmer();
            Emp e = p as Emp; // 캐스팅이 안되면 null을 출력한다
                if (e != null) 
                    Console.WriteLine(e.ToString());
        }
    }
    }
}
