using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace AdventOfCode.Test
{
    [TestClass]
    public class Day04
    {
        private CoinMiner miner;

        [TestInitialize]
        public void Initialize()
        {
            miner = new CoinMiner();
        }

        [TestMethod]
        public void Part1()
        {
            Assert.AreEqual("609043", miner.NextHash("abcdef",5));
            Assert.AreEqual("1048970", miner.NextHash("pqrstuv", 5));

            Trace.WriteLine(string.Format("Next hash starting with 5 0's {0}", miner.NextHash("ckczppom", 5)));
        }

        [TestMethod]
        public void Part2()
        {
            Trace.WriteLine(string.Format("Next hash starting with 6 0's {0}", miner.NextHash("ckczppom", 6)));
        }
    }
}
