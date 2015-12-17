using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace AdventOfCode.Test
{
    [TestClass]
    public class Day01
    {
        private IEnumerable<char> input;
        private Building building;

        [TestInitialize]
        public void Initialize()
        {
            using (var file = new StreamReader("Input01.txt"))
                input = file.ReadToEnd().ToCharArray();

            building = new Building();
        }

        [TestMethod]
        public void Part1()
        {
            Assert.AreEqual(building.Floor("((".ToCharArray()), 2);
            Assert.AreEqual(building.Floor("(())".ToCharArray()), 0);
            Assert.AreEqual(building.Floor(")(())".ToCharArray()), -1);

            Trace.WriteLine(string.Format("Floor {0}", building.Floor(input)));
        }

        [TestMethod]
        public void Part2()
        {
            Assert.AreEqual(building.Basement("(()))((".ToCharArray()), 4);

            Trace.WriteLine(string.Format("Basement {0}", building.Basement(input)));
        }
    }
}
