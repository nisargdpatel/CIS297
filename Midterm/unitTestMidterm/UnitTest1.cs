using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace unitTestMidterm
{
    [TestClass]
    public class unitTestMidterm
    {
        [TestMethod]
        public void TestReverseCharacters()
        {
            

            char[] toReverse = { 'c', 'b', 'a' };
            ReverseCharacters(toReverse);
            for (int i = 0; i <= toReverse.Length - 1; i++)
            {
                Console.WriteLine(toReverse[i].ToString());
            }
        }
    }
}
