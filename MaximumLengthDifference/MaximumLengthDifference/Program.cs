using System;

namespace MaximumLengthDifference
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] s1 =
            {
                "hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii",
                "dvvvwz"
            };
            //var s2 = new String[] { "cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww" };
            string[] s2 =new string[0];
            MaxDiffLength.Mxdiflg(s1, s2);
        }
    }
}