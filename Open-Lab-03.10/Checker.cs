using System;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {
            int count = str.Split(letter).Length - 1;
            return count;
        }
    }
}
