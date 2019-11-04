using System;

namespace SplatWorld
{
    class MyWorld
    {
        static void Main(string[] args)
        {
            /*
             * Initialize an array
             */

            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 100;
            grades[2] = 55;
            grades[3] = 78;
            grades[4] = 98;

            Console.WriteLine("Grades at index 0: {0} ", grades[0]);
            

            string input = Console.ReadLine();
            grades[0] = int.Parse(input);
            Console.WriteLine("Grades at index 0: {0} ", grades[0]);
            Console.ReadKey();


            /*Single line array declaration
             */
            int[] gradesInClassA = { 65, 78, 90, 89, 99 };

            int[] gradesInClassB = new int[] { 56, 33, 100, 54, 88 };

            Console.WriteLine("Length of grades in class A: {0} ", gradesInClassA.Length);
            Console.ReadKey(); 
        }
    }
}
