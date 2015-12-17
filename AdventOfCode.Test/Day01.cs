using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode.Test
{
    [TestClass]
    public class Day01
    {
        private IEnumerable<char> input;

        [TestInitialize]
        public void Initialize()
        {
            using (var file = new StreamReader("Input01.txt"))
                input = file.ReadToEnd().ToCharArray();
        }

        [TestMethod]
        public void Part1()
        {
            var building = new Building();

            Assert.AreEqual(building.Floor("((".ToCharArray()), 2);
            Assert.AreEqual(building.Floor("(())".ToCharArray()), 0);
            Assert.AreEqual(building.Floor(")(())".ToCharArray()), -1);

            System.Diagnostics.Debug.WriteLine("Floor {0}", building.Floor(input));
        }

        [TestMethod]
        public void Part2()
        {
            var building = new Building();

            Assert.AreEqual(building.Basement("(()))((".ToCharArray()), 4);

            System.Diagnostics.Debug.WriteLine("Basement {0}", building.Basement(input));
        }
    }
}
