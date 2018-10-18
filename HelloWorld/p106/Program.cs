using System;


namespace p106
{
    class Test<T> // 일반화 클래스
    {

        public T Sum(T i, T j) // 메소드 일반화
        {
            return (dynamic)i + (dynamic)j; //(dynamic) 컴파일 시점에 형식 검사를 무시하며 런타임시 확인한다
        }

        /*
        static float Sum(float i = 0, float j = 0)
        {
            return i + j;
        }
        */
    }
    class TestMain
    {
        static void Main(string[] args)
        {
            Test<int> t = new Test<int>();
            int i = 1; int j = 2;
            Console.WriteLine("{0} + {1} = {2}", i, j, t.Sum(i, j));

            Test<float> t2 = new Test<float>();
            float f1 = 1.0f; float f2 = 2.0f;
            Console.WriteLine("{0:f} + {1:f} = {2:f}", f1, f2, t2.Sum(f1, f2));
        }

    }
}
