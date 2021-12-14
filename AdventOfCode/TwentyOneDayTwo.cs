using System;
using System.IO;
using System.Collections.Generic;


namespace AdventOfCode
{
    public class TwentyOneDayTwo : IAoC
    {
        string text;
        string[] array;

        private string[] arraySplitted;


        //getter/setter

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

        /*  SplitSpacesInArray Method
         *
         *  Takes the raw data where the "\n"'s are splitted already and
         *  returns a list with the instructions and values splitted 
         * 
         */

        private string[] SplitSpacesInArray()
        {

            List<string> newArray = new List<string>();

            for (int i = 0; i < Array.Length; i++)
            {
                string[] valueCut = Array[i].Split(null);

                for (int j = 0; j < valueCut.Length; j++)
                {
                    newArray.Add(valueCut[j]);
                }
            }
            return newArray.ToArray();
        }



        /*  StarOne Method
         *
         *  calculates the result of the first star, takes a string array
         *  the SplitSpacesInArray Method needs to be called first to seperate
         *  the values and instructions and the List needs to be converted into an array.
         * 
         */

        public int StarOne()
        {
            int posX = 0;
            int posY = 0;

            for (int i = 0; i < arraySplitted.Length; i += 2)
            {
                if (arraySplitted[i] == "forward") posX += System.Convert.ToInt32(arraySplitted[i + 1]);
                else if (arraySplitted[i] == "down") posY += System.Convert.ToInt32(arraySplitted[i + 1]);
                else if (arraySplitted[i] == "up") posY -= System.Convert.ToInt32(arraySplitted[i + 1]);
            }

            return posX * posY;
        }



        /*  StarTwo Method
         *
         *  same as with the StarOne Method
         * 
         */

        public int StarTwo()
        {
            int posX = 0;
            int posY = 0;
            int aim = 0;

            for (int i = 0; i < arraySplitted.Length; i++)
            {
                if (arraySplitted[i] == "forward")
                {
                    posX += System.Convert.ToInt32(arraySplitted[i + 1]);

                    if (aim != 0) posY += aim * System.Convert.ToInt32(arraySplitted[i + 1]);
                }
                else if (arraySplitted[i] == "down") aim += System.Convert.ToInt32(arraySplitted[i + 1]);
                else if (arraySplitted[i] == "up") aim -= System.Convert.ToInt32(arraySplitted[i + 1]);

            }

            return posX * posY;
        }



        //public Methods

        public TwentyOneDayTwo()
        {
            Text = File.ReadAllText("../../TwentyOneDayTwo.txt");
            Array = Text.Split('\n');
            arraySplitted = SplitSpacesInArray();
        }

        public void Solutions()
        {
            Console.WriteLine($"Day 2 - Star 1: {StarOne()}");
            Console.WriteLine($"Day 2 - Star 2: {StarTwo()}");
        }

    }
}
