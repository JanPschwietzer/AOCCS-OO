using System;
using System.IO;

namespace AdventOfCode
{
    public class Day1
    {

        private string text;
        private string[] numbers;


        //private Methods

        private int StarOne()
        {
            int counter = 0;
            int comp = 0;

            foreach (string value in numbers)
            {
                if (comp != 0 && comp < System.Convert.ToInt32(value))
                {
                    counter++;
                }
                comp = System.Convert.ToInt32(value);
            }

            return counter;
        }


        private int StarTwo()
        {
            int counter = 0;

            for (int i = 0; i < numbers.Length - 3; i++)
            {
                if (System.Convert.ToInt32(numbers[i]) + System.Convert.ToInt32(numbers[i + 1]) + System.Convert.ToInt32(numbers[i + 2]) < System.Convert.ToInt32(numbers[i + 1]) + System.Convert.ToInt32(numbers[i + 2]) + System.Convert.ToInt32(numbers[i + 3]))
                {
                    counter++;
                }
            }

            return counter;
        }


        //public Methods

        public Day1()
        {
            text = File.ReadAllText("../../Day1.txt");
            numbers = text.Split('\n');
        }

        public void Solutions()
        {
            Console.WriteLine($"Day 1 - Star 1: {StarOne()}");
            Console.WriteLine($"Day 1 - Star 2: {StarTwo()}");
        }
    }
}
