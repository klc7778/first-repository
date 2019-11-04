using System;

namespace SplatWorld
{
    class MyWorld
    {
        static void Main(string[] args)
        {
            /*
             * For loops biotch
             */

            int[] nums = new int[10];

            for(int i=0; i < 10; i++)
            {
                nums[i] = i+8;
            
            }

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element[0] = {1}", j, nums[j]);                
            }

            /* value of K at position in nums
             */
            int counter = 0; 
            foreach (int k in nums)
            {
                Console.WriteLine("Element[0] = {1}", counter, k);
                counter++;
            }
            /* 
             * create array of 5 names,
             * and foreach loop to greet all of them */

            string[] friends = new string[]{ "Tommy", "Ghost", "Tasha", "Ja'Net", "Mi'Kael" };

            foreach(string f in friends)
            {
                Console.WriteLine("Greetings = {1}!", counter, f);
                counter++;
            }

            Console.ReadKey(); 
        }
    }
}
