using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumLengthDifference
{
    public class MaxDiffLength
    {
        public static int Mxdiflg(string[] a1, string[] a2)
        {
            if (a1.Any(a => a == null)|| a2.Any(a => a == null) ||a1.Length==0 ||a2.Length==0)
            {
                return -1;
            }

            var a1Min = a1.Min(a => a.Length);
            var a2Max = a2.Max(a => a.Length);
            var a2Min = a2.Min(a => a.Length);
            var x = Math.Abs(a1.Max(a=>a.Length) - a2Min);
            var y = Math.Abs(a2Max - a1Min);
            if (x > y) return x;
            return y;
        }
    }
}
