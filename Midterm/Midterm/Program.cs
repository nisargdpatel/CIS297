using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] toReverse = { 'c', 'b', 'a' };
            ReverseCharacters(toReverse);
            for (int i = 0; i <= toReverse.Length - 1; i++)
            {
                Console.WriteLine(toReverse[i].ToString());
            }
        }

        static public void ReverseCharacters(char[] toReverse)
        {
            int right = toReverse.Length - 1;

            for (int left = 0; left <= right; left++, right--)
            {
                char temp = toReverse[left];
                toReverse[left] = toReverse[right];
                toReverse[right] = temp;
            }
        }
    }
}
