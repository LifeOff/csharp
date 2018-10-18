using System;
using System.Windows.Forms;


namespace 과제3
{
    /*
    class Program

    {

        static void Main(string[] args)

        {

            //가변배열, 처음방에는 1,2 두번째방에는 1,2,3 세번째방에는 1,2,3,4

            int[][] a = {
                new int[] { 1,2 },
                new int[] { 1,2,3 },
                new int[] { 1,2,3,4 }
            };

            //3행 2열, 이차원배열 1행은 (1,2), 2행은 (3,4), 3행은 (5,6)

            int[,] b = { {1,2},{3,4}, {5,6} };

            //가변배열 출력

            foreach (int[] i in a)

            {

                foreach (int j in i)

                {

                Console.Write(j + " "); 

                }

            }

            Console.WriteLine("\n---------------\n");

            //이차원 배열 출력

            foreach(int i in b)

            {

            Console.Write(i + " ");

            }

        }

    }
    */

    /*
    //2. 아래와 같은 결과를 만들기 위해 괄호를 채우세요.

    //[결과]
    //12345678
    //12345678

        class Program
        {

            static void Main(string[] args)
            {

            

                //----4행2열
                int[,] twoDim = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
                for (int i=0; i< 4; i++ )
                {
                    for (int j=0; j<2; j++)
                    {
                        Console.Write(twoDim[i, j]);
                    }
                }

                Console.WriteLine();

                foreach (int i in twoDim)
                {
                    Console.Write(i);
                }
            }
        }

    */

    /*
    // 3 : 다음 코드의 실행 결과는
    // 0
    // 0

    class Program

    {
        static void Main()

        {

            // This is a zero-element int array.

            var values1 = new int[] { };

            Console.WriteLine(values1.Length);



            // This is a zero-element int array also.

            var values2 = new int[0];

            Console.WriteLine(values2.Length);

        }
    }
    */

    /*
    //4. 실행 결과를 만들어 내기 위해 코드를 완성 하세요.
    // 1
    // 2
    // 3
    // 5
    // 7
    // 8
    // 1
    // 3
    // 5
    // 7
    // 8
    

    class Program

    {

        static void Main()

        {

            // Loop over array of integers.

            foreach (int id in GetEmployeeIds())

            {

                Console.WriteLine("{0}", id);

            }

            // Loop over array of integers.

            int[] employees = GetEmployeeIds();

            for (int i = 0; i < employees.Length; i++)

            {

                Console.WriteLine("{0}", employees[i]);

            }

        }

        /// <summary>

        /// Returns an array of integers.

        /// </summary>

        static int[] GetEmployeeIds()

        {

            int[] employees = new int[5];

            employees[0] = 1;

            employees[1] = 3;

            employees[2] = 5;

            employees[3] = 7;

            employees[4] = 8;

            return employees;

        }

    }
    */

    /*
    // 5. 실행 결과를 만들어 내기 위해 코드를 완성 하세요. 
    // 1
    // 2
    // 3

    class Program

    {

        static void Main()

        {

            // Declare new int array.

            int[] teams = new int[3];

            teams[0] = 1;

            teams[1] = 2;

            teams[2] = 3;



            // New employee that stores int array reference.

            Employee employee = new Employee(teams);



            // Loop through each int in employee's class.

            foreach (int team in employee.Teams)

            {

                Console.WriteLine(team);

            }

        }

    }



    /// <summary>

    /// Stores an employee and his teams.

    /// </summary>

    class Employee

    {

        /// <summary>

        /// Int array reference at class level.

        /// </summary>

        int[] _teams;



        /// <summary>

        /// Create new employee.

        /// </summary>

        /// <param name="teams">Teams for the employee.</param>

        public Employee(int[] teams)

        {

            _teams = teams;

        }



        /// <summary>

        /// Get array of teams.

        /// </summary>

        public int[] Teams
        {

            get
            {
                return _teams;
            }

        }

    }
    */

    /*
    // 6. 실행 결과는?
    // 10
    class Program

    {

        static void Main()

        {

            int[] array = new int[2]; // Create an array.

            array[0] = 10;

            array[1] = 3021;



            Test(array);

            Test(null); // No output.

            Test(new int[0]); // No output.

        }



        static void Test(int[] array)

        {

            if (array != null && array.Length > 0)

            {

                int first = array[0];

                Console.WriteLine(first);

            }

        }

    }
    */


    // 7. 배열 리사이징 하기(괄호를 채우세요).
    class Program

    {

        static void Main()

        {

            char[] array = new char[5];

            array[0] = 'A';

            array[1] = 'B';

            array[2] = 'C';

            array[3] = 'D';

            array[4] = 'E';
            
            for (int i = 0; i < array.Length; i++)

            {

                MessageBox.Show(array[i].ToString());

            }
            
            // A,B,C 만 출력되도록 괄호를 채워 주세요.

            Array.Resize(ref array, 3);

            for (int i = 0; i < array.Length; i++)
            {

                MessageBox.Show(array[i].ToString());

            }

        }


    }




}





