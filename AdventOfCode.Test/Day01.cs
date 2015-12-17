using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace AdventOfCode.Test
{
    [TestClass]
    public class Day01
    {
        private string input;
        private Building building;

        [TestInitialize]
        public void Initialize()
        {
            using (var file = new StreamReader("Input01.txt"))
                input = file.ReadToEnd();

            building = new Building();
        }

        [TestMethod]
        public void Part1()
        {
            Assert.AreEqual(2,building.Floor("(("));
            Assert.AreEqual(0,building.Floor("(())"));
            Assert.AreEqual(-1,building.Floor(")(())"));

            Trace.WriteLine(string.Format("Floor {0}", building.Floor(input)));
        }

        [TestMethod]
        public void Part2()
        {
            Assert.AreEqual(4,building.Basement("(()))(("));

            Trace.WriteLine(string.Format("Basement {0}", building.Basement(input)));
        }
    }
}
