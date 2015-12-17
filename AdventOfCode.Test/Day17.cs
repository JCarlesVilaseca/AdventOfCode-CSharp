using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode.Test
{
    [TestClass]
    public class Day17
    {
        private List<int> input = new List<int>();
        private ContainerFiller filler;

        [TestInitialize]
        public void Initialize()
        {
            using (var file = new StreamReader("Input17.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                    input.Add(int.Parse(line));
            }

            filler = new ContainerFiller();
        }

        [TestMethod]
        public void Part1()
        {
            Assert.AreEqual(4, filler.TotalCombinationsCount(new List<int> { 20,15,10,5,5}, 25));

            Trace.WriteLine(string.Format("Number of combinations {0}", filler.TotalCombinationsCount(input,150)));
        }

        [TestMethod]
        public void Part2()
        {
            Assert.AreEqual(3, filler.ShortestCombinationsCount(new List<int> { 20, 15, 10, 5, 5 }, 25));

            Trace.WriteLine(string.Format("Number of short combinations {0}", filler.ShortestCombinationsCount(input, 150)));
        }

    }
}
