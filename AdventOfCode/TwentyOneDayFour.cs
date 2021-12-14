using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public class TwentyOneDayFour : IAoC
    {
        string text;
        string[] array;

        private string[] clearedArray;
        private string[] numbers;

        //getter/setter

        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        public string[] Array
        {
            get { return array; }
            set { array = value; }
        }






        private string[] ClearUpData()
        {
            List<string> list = new List<string>(Array);

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] == "") list.RemoveAt(i);
            }

            numbers = list[0].Split(',');

            list.RemoveAt(0);

            return list.ToArray();
        }

        public int StarOne()
        {
            int index = -1;
            int winningNumber = 0;
            int ret = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (index != -1)
                {
                    break;
                }

                winningNumber = System.Convert.ToInt32(numbers[i]);

                for (int j = 0; j < clearedArray.Length; j++)
                {
                    if (numbers[i] == clearedArray[j])
                    {
                        clearedArray[j] = "-1";
                    }
                }


                for (int j = 0; j < clearedArray.Length - 5; j += 5)
                {
                    if (clearedArray[j] == "-1" && clearedArray[j + 1] == "-1" && clearedArray[j + 2] == "-1" && clearedArray[j + 3] == "-1" && clearedArray[j + 4] == "-1")
                    {
                        index = j;
                        break;
                    }
                }

                for (int k = 0; k < 5; k++)
                {
                    for (int j = k; j < clearedArray.Length - 20; j += 25)
                    {
                        if (clearedArray[j] == "-1" && clearedArray[j + 5] == "-1" && clearedArray[j + 10] == "-1" && clearedArray[j + 15] == "-1" && clearedArray[j + 20] == "-1")
                        {
                            index = j;
                            k = 5;
                            break;
                        }
                    }
                }
            }


            for (int i = index; i > 0; i--)
            {
                if (i % 25 == 0)
                {
                    index = i;
                    break;
                }
            }


            for (int i = index; i < index + 25; i++)
            {
                if (clearedArray[i] != "-1") ret += System.Convert.ToInt32(clearedArray[i]);
            }


            return ret * winningNumber;
        }


        public int StarTwo()
        {
            return -1;
        }


        public TwentyOneDayFour()
        {
            Text = File.ReadAllText("../../TwentyOneDayFour.txt");
            Text = Text.Replace(" ", "\n");
            Array = Text.Split('\n');
            clearedArray = ClearUpData();
        }

        public void Solutions()
        {
            Console.WriteLine($"Day 4 - Star 1: {StarOne()}");
        }

    }
}
