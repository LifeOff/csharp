
namespace p66
{
    class A
    {
        protected A(){}

        ~A() // finalize() 메소드
        {
            System.Console.WriteLine("A 소멸~");
        }
    }

    class B : A
    {
        static void Main()
        {
            B a = new B(); // object -> A -> B
            System.GC.Collect();
        }
    }
}
