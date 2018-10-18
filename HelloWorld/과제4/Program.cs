using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 과제4
{
    /*
    class Stack1

    {

        int top = 0;

        int[] ar = new int[10];

        public void Push(int obj)
        {

            ar[top] = obj;

            top++;

        }

        public int Pop()

        {

            top--;

            return ar[top];

        }

    }



    class Stack2

    {

        int top = 0;

        string[] ar = new string[10];

        public void Push(string obj)

        {

            ar[top] = obj;

            top++;

        }

        public string Pop()

        {

            top--;

            return ar[top];

        }

    }

    class Stack3<T>
    {
        int top = 0;

        T[] ar = new T[10];

        public void Push(T obj)

        {

            ar[top] = obj;

            top++;

        }

        public T Pop()

        {

            top--;

            return ar[top];

        }
    }



    class StackTest

    {

        static void Main()

        {

            Stack1 s1 = new Stack1();

            s1.Push(1);

            s1.Push(2);

            s1.Push(3);

            Console.WriteLine(s1.Pop());

            Console.WriteLine(s1.Pop());

            Console.WriteLine(s1.Pop());



            Stack2 s2 = new Stack2();

            s2.Push("KOREA");

            s2.Push("대한민국");

            s2.Push("서울");

            Console.WriteLine(s2.Pop());

            Console.WriteLine(s2.Pop());

            Console.WriteLine(s2.Pop());

        }

    }
    */

    interface IEquatable<T>

    {

        bool Equals(T obj);

    }

    public class Emp : IEquatable<Emp>

    {

        public string name { get; set; }

        public int sabun { get; set; }

        // Implementation of IEquatable<T> interface

        //name, sabun이 같을 경우 true 리턴

        public bool Equals(Emp e)
        {
            if(this.name == e.name && this.sabun == e.sabun)
            {
                return true;
            }
            return false;

        }

    }

    public class Car : IEquatable<Car>

    {

        public string Maker { get; set; }

        public string Model { get; set; }

        public string Year { get; set; }

        // Implementation of IEquatable<T> interface

        //Maker, Model, Year가 같을 경우 true 리턴

        public bool Equals(Car car)

        {
            if(this.Maker == car.Maker && this.Model == car.Model && this.Year == car.Year)
            {
                return true;
            }

            return false;
        }

    }

    public class CarTest

    {

        static void Main()

        {

            Car c1 = new Car()

            {

                Maker = "현대",

                Model = "그랜저",

                Year = "2016"

            };

            Car c2 = new Car()

            {

                Maker = "현대",

                Model = "그랜저",

                Year = "2015"

            };

            if (c1.Equals(c2))

            {

                Console.WriteLine("c1와 c2는 같다.");

            }

            else

            {

                Console.WriteLine("c1와 c2는 다르다.");

            }

            Emp e1 = new Emp()

            {

                name = "홍길이",
                sabun = 1004

            };

            Emp e2 = new Emp()

            {

                name = "홍길이",

                sabun = 1004

            };

            if (e1.Equals(e2))

            {

                Console.WriteLine("e1와 e2는 같다.");

            }

            else

            {

                Console.WriteLine("e1와 e2는 다르다.");

            }

        }

    }
}
