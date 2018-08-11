using System;
using System.Linq;

namespace MaximumLengthDifference
{
    public class MaxDiffLength
    {
        public static int Mxdiflg(string[] a1, string[] a2)
        {
            if (a1.Any(a => a == null) || a2.Any(a => a == null) || a1.Length == 0 || a2.Length == 0) return -1;
            var x = Math.Abs(a1.Max(a => a.Length) - a2.Min(a => a.Length));
            var y = Math.Abs(a2.Max(a => a.Length) - a1.Min(a => a.Length));
            return x > y ? x : y;
        }
    }
}