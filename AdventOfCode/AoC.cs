using System;

namespace AdventOfCode
{
    public interface IAoC
    {
        string Text { get; }
        string[] Array { get; }



        int StarOne();
        int StarTwo();
        void Solutions();
    }
}