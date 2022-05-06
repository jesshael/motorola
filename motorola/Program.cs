using System;

namespace Solution
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            //declaration of variables
            string numbers;
            int result = 0;
            // you can write to stdout for debugging purposes, e.g.
            Console.WriteLine("Add the numbers separate for comma");
            numbers = Console.ReadLine(); // 9            
            result = Add(numbers);
            Console.WriteLine("The sumarize of numbers is:" + result); // 0
        }


        public static int Add(string numbers)
        {
            string[] subs = numbers.Split(' ', ',');

            int size = subs.Length;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                
                sum += Convert.ToInt32( subs[i]);
            }
            return sum;
        }
    }
}