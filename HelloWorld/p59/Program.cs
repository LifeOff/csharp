using System;

namespace p59
{
    public class Dog
    {
        public string Name { get; set; }
        public void jitda()
        {
            Console.WriteLine(Name + " 가 짖다.");

        }
    }
    public class Pudle : Dog
    { 
        public void work() { Console.WriteLine(Name + " 가 일한다."); }
    }

    public class Jindo : Dog
    {
        public void run() { Console.WriteLine(Name + " 가 달린다."); }
    }

    class DogManager
    {
        static void Main()
        {
            Pudle p = new Pudle(); p.Name = "푸들이"; p.jitda(); p.work();
            Jindo j = new Jindo(); j.Name = "진도이"; j.jitda(); j.run();
        }
    }
}
