using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task7.cs;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int N = 4;
            int M = 3;
            int[] array = new int[N];
            int[] secondary = { 1, 1, 1};
            Program.NextSet(secondary, N, M);
            int[] expected = { 1, 1, 2 };
            for(int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], secondary[i]);
            }
        }
        [TestMethod]
        public void TestMethod2()
        {
            int N = 4;
            int M = 3;
            int[] array = new int[N];
            int[] secondary = { 1, 1, 1 };
            Program.NextSet(secondary, N, M);
            Program.NextSet(secondary, N, M);

            int[] expected = { 1, 1, 3 };
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], secondary[i]);
            }
        }
        [TestMethod]
        public void TestMethod3()
        {
            int N = 4;
            int M = 3;
            int[] array = new int[N];
            int[] secondary = { 1, 1, 1 };
            Program.NextSet(secondary, N, M);
            Program.NextSet(secondary, N, M);
            Program.NextSet(secondary, N, M);
            Program.NextSet(secondary, N, M);

            int[] expected = { 1, 2, 2 };
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], secondary[i]);
            }
        }
        [TestMethod]
        public void TestMethod4()
        {
            int N = 6;
            int M = 1;
            int[] array = new int[N];
            int[] secondary = { 1, 1, 1, 1, 1, 1 };
            Program.NextSet(secondary, N, M);
            Program.NextSet(secondary, N, M);
            Program.NextSet(secondary, N, M);
            Program.NextSet(secondary, N, M);

            Assert.AreEqual(5, secondary[0]);

        }
        [TestMethod]
        public void TestMethod5()
        {
            int N = 1;
            int M = 1;
            int[] array = new int[N];
            int[] secondary = { 1, 1, 1, 1, 1, 1 };
            Program.NextSet(secondary, N, M);


            Assert.AreEqual(1, secondary[0]);

        }
        [TestMethod]
        public void TestMethod6()
        {
            int N = 4;
            int M = 3;
            int[] array = new int[N];
            int[] secondary = { 1, 1, 1 };
            Program.NextSet(secondary, N, M);
            Program.NextSet(secondary, N, M);
            Program.NextSet(secondary, N, M);
            Program.NextSet(secondary, N, M);
            Program.NextSet(secondary, N, M);

            int[] expected = { 1, 2, 3 };
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], secondary[i]);
            }
        }
    }
}
