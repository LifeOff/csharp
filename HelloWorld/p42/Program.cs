using System;

namespace p42
{
    class Emp

    {   // 멤버변수, 필드변수 
       //string name; // C#은 접근제어자를 안주면 private로 준다
                           // protected 자식만 접근가능하다
                           // internal 같은 어셈블리(.exe 하나의 프로젝트)안에서 접근가능하다

       public string Name // 자동구현 속성
        {
            get; set;
            /*
            get
            {
                return this.name; // this는 앞으로 자기 자신의 name의 객체를 찾는것
            }
            set
            {
                this.name = value;
            }
            */
        }

        /*
       public void SetName(string name)
        {
            this.name = name;
        }
       public string GetName()
        {
            return this.name;
        }
        */
    }
    class EmpTest
    {
        static void Main()
        {
            Emp e = new Emp();
            e.Name = "KIM"; // 속성은 변수로 쓸수 있다
            Console.WriteLine(e.Name);
            /*
            e.SetName("KIM");
            Console.WriteLine(e.GetName());
            */
        }
    }
}
