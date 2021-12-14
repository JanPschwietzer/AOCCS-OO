using System;
using System.IO;

namespace AdventOfCode
{
    public class TwentyOneDayOne : IAoC
    {

        string text;
        string[] array;


        //Getter/Setter

        public string Text
        {
            get { return text; }
            set
            {
                this.text = value;
            }
        }
        public string[] Array
        {
            get { return array; }
            set
            {
                this.array = value;
            }
        }



        //private Methods

        public int StarOne()
        {
            int counter = 0;
            int comp = 0;

            foreach (string value in Array)
            {
                if (comp != 0 && comp < System.Convert.ToInt32(value))
                {
                    counter++;
                }
                comp = System.Convert.ToInt32(value);
            }

            return counter;
        }


        public int StarTwo()
        {
            int counter = 0;

            for (int i = 0; i < Array.Length - 3; i++)
            {
                if (System.Convert.ToInt32(Array[i]) + System.Convert.ToInt32(Array[i + 1]) + System.Convert.ToInt32(Array[i + 2]) < System.Convert.ToInt32(Array[i + 1]) + System.Convert.ToInt32(Array[i + 2]) + System.Convert.ToInt32(Array[i + 3]))
                {
                    counter++;
                }
            }

            return counter;
        }


        //public Methods

        public TwentyOneDayOne()
        {
            Text = File.ReadAllText("../../TwentyOneDayOne.txt");
            Array = Text.Split('\n');
        }

        public void Solutions()
        {
            Console.WriteLine($"Day 1 - Star 1: {StarOne()}");
            Console.WriteLine($"Day 1 - Star 2: {StarTwo()}");
        }
    }
}
