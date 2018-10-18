using System;

namespace p68
{
    class MyBaseClass
    {
        public MyBaseClass()
        {
            Console.WriteLine(">>> MyBaseClass()");
        }

        public MyBaseClass(int i)
        {
            Console.WriteLine(">>> MyBaseClass(int i)");
        }
    }
    class MyClass : MyBaseClass
    {
        public MyClass()
        {
            Console.WriteLine(">>> MyClass()");
        }

        public MyClass(int i) : base(i) // super() 와 같다
        {
            Console.WriteLine(">>> MyClass(int i)");
        }

        public MyClass(int i, int j)
        {
            Console.WriteLine(">>> MyClass(int i, int j)");
        }

        public MyClass(int i, int j, int k) : base(i)
        {
            Console.WriteLine(">>> MyClass(int i, int j, int k)");
        }

        public MyClass(int i, int j, int k, int l) : this(i, j) // 자기자신의 또다른 생성자를 말한다
        {
            Console.WriteLine(">>> MyClass(int i, int j, int k, int l)");
        }
    }

    class Test
    {
        static void Main()
        {
            MyClass m1 = new MyClass(); // MyBaseClass(), MyClass()
            Console.WriteLine("--------------------------");

            MyClass m2 = new MyClass(1); // MyBaseClass(int i), MyClass(int i)
            Console.WriteLine("--------------------------");

            MyClass m3 = new MyClass(1, 2); // MyBaseClass(), MyClass(int i, int j)
            Console.WriteLine("--------------------------");

            MyClass m4 = new MyClass(1, 2, 3); // MyBaseClass(int i), MyClass(int i, int j, int k)
            Console.WriteLine("--------------------------");

            MyClass m5 = new MyClass(1, 2, 3, 4);
            // MyBaseClass(), MyClass(int i, int j), MyClass(int i, int j, int k, int l)

        }
    }
}
