using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaximumLengthDifference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumLengthDifference.Tests
{
    [TestClass()]
    public class MaxDiffLengthTests
    {
        [TestMethod()]
        public void MxdiflgTest()
        {
            string[] s1 = new string[] { "hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz" };
            string[] s2 = new string[] { "cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww" };
            Assert.AreEqual(13, MaxDiffLength.Mxdiflg(s1, s2));
        }
        [TestMethod()]
        public void OppositeMxdiflgTest()
        {
            string[] s2 = new string[] { "hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz" };
            string[] s1 = new string[] { "cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww" };
            Assert.AreEqual(13, MaxDiffLength.Mxdiflg(s1, s2));
        }
        [TestMethod()]
        public void MxdiflgTestOneArrayisNullAndHas5Length()
        {
            string[] s1 = new string[] { "hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz" };
            string[] s2 = new string[5] ;
            Assert.AreEqual(-1, MaxDiffLength.Mxdiflg(s1, s2));
        }
        [TestMethod()]
        public void MxdiflgTestOneArrayisNullAndLengthis0()
        {
            string[] s1 = new string[] { "hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz" };
            string[] s2 = new string[0];
            Assert.AreEqual(-1, MaxDiffLength.Mxdiflg(s1, s2));
        }
    }
}