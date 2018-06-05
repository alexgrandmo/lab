using System;
using System.Linq;

namespace lab2
{
    class ReverseString
    {
        public string Reverse(string str)
        {
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            words = words.Reverse().ToArray();
            return string.Join(" ", words);
        }
    }
}
