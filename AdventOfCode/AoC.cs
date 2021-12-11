using System;

namespace AdventOfCode
{
    public class AoC
    {
        private string text;
        private string[] array;

        public string Text
        {
            get { return text;}
            set
            {
                text = value;
            }
        }
        public string[] Array
        {
            get { return array; }
            set
            {
                array = value;
            }
        }
    }
}