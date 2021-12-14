using System;

namespace AdventOfCode
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numOfDays = 4;

            IAoC[] IAdventofCode = new IAoC[numOfDays];

            IAdventofCode[0] = new TwentyOneDayOne();
            IAdventofCode[1] = new TwentyOneDayTwo();
            IAdventofCode[2] = new TwentyOneDayThree();
            IAdventofCode[3] = new TwentyOneDayFour();

            foreach (IAoC Day in IAdventofCode)
            {
                Day.Solutions();
            }
        }
    }
}
