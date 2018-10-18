using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p64
{
    // 인터페이스를 이용한 다형성 예제 (인터페이스 내에 속성 사용 예제)

    interface Dog // 안에 올수 있는것 : 메소드 , 속성, 이벤트 . 인덱서...... 필드(멤버)X
    {
        string Name { get; set; } // 속성

        void jitda(); // 추상 메소드
    }
    class Pudle : Dog
    {
        public string Name { get; set; }

        
        public void Work() { Console.WriteLine(Name + " 일한다."); }

        public void jitda()
        {
            Console.WriteLine(Name + " 짖다 ~~~~~~~~");
        }

    }

    public class Jindo : Dog
    {
        public string Name { get; set; }

        

        public void Run() { Console.WriteLine(Name + " 달린다."); }

        public void jitda()
        {
            Console.WriteLine(Name + " 짖다 ~~~~~~~~");
        }
    }

    class DogManager
    {
        static void Main()
        {
            Dog p = new Pudle(); p.Name = "푸들이";
            p.jitda(); 
            ((Pudle)p).Work();

            Dog j = new Jindo(); j.Name = "진도이";
            j.jitda(); 
            ((Jindo)j).Run();

        }
    }
}
