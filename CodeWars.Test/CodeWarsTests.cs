﻿using System;
using NUnit.Framework;
using System.Linq;
using CodeWars.Test.Tasks;

namespace CodeWars.Test
{
    [TestFixture]
    public class CodeWarsTests
    {
        [Test]
        public void Task_1_Test()
        {
            Assert.AreEqual(3, Persist.Persistence(39));
            Assert.AreEqual(0, Persist.Persistence(4));
            Assert.AreEqual(2, Persist.Persistence(25));
            Assert.AreEqual(4, Persist.Persistence(999));
        }

        [Test]
        public void Task_2_Test()
        {
            Assert.AreEqual(true, CheckXo.Xo("xxOo"));
            Assert.AreEqual(true, CheckXo.Xo("xo"));
            Assert.AreEqual(false, CheckXo.Xo("xxxm"));
            Assert.AreEqual(false, CheckXo.Xo("Oo"));
            Assert.AreEqual(false, CheckXo.Xo("ooom"));
        }

        [Test]
        public void Task_3_Test()
        {
            try
            {
                string input = ".... . -.--   .--- ..- -.. .";
                string expected = "HEY JUDE";

                string actual = MorseCodeDecoder.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }

        [Test]
        public void Task_4_Test()
        {
            Assert.AreEqual("aehrsty", TwoToOne.Longest("aretheyhere", "yestheyarehere"));
            Assert.AreEqual("abcdefghilnoprstu", TwoToOne.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
            Assert.AreEqual("acefghilmnoprstuy", TwoToOne.Longest("inmanylanguages", "theresapairoffunctions"));
        }

        [Test]
        public void Task_5_Test()
        {
            Console.WriteLine("Basic Tests");
            Testing(LongestConsecutives.LongestConsec(new String[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" }, 2), "abigailtheta");
            Testing(LongestConsecutives.LongestConsec(new String[] { "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh" }, 1), "oocccffuucccjjjkkkjyyyeehh");
            Testing(LongestConsecutives.LongestConsec(new String[] { }, 3), "");
            Testing(LongestConsecutives.LongestConsec(new String[] { "itvayloxrp", "wkppqsztdkmvcuwvereiupccauycnjutlv", "vweqilsfytihvrzlaodfixoyxvyuyvgpck" }, 2), "wkppqsztdkmvcuwvereiupccauycnjutlvvweqilsfytihvrzlaodfixoyxvyuyvgpck");
            Testing(LongestConsecutives.LongestConsec(new String[] { "wlwsasphmxx", "owiaxujylentrklctozmymu", "wpgozvxxiu" }, 2), "wlwsasphmxxowiaxujylentrklctozmymu");
            Testing(LongestConsecutives.LongestConsec(new String[] { "zone", "abigail", "theta", "form", "libe", "zas" }, -2), "");
            Testing(LongestConsecutives.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 3), "ixoyx3452zzzzzzzzzzzz");
            Testing(LongestConsecutives.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 15), "");
            Testing(LongestConsecutives.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 0), "");

            void Testing(string actual, string expected) => Assert.AreEqual(expected, actual);
        }
    }
}