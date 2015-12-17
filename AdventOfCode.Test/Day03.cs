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
    public class Day03
    {
        private string input;
        private Houses houses;

        [TestInitialize]
        public void Initialize()
        {
            using (var file = new StreamReader("Input03.txt"))
            {
                input = file.ReadToEnd();
            }

            houses = new Houses();
        }

        [TestMethod]
        public void Part1()
        {
            Assert.AreEqual(2, houses.Visited(">"));
            Assert.AreEqual(4, houses.Visited("^>v<"));
            Assert.AreEqual(2, houses.Visited("^v^v^v^v^v"));

            Trace.WriteLine(string.Format("Houses visited by Santa {0}", houses.Visited(input)));
        }

        /*
        [TestMethod]
        public void Part2()
        {
            Assert.AreEqual(houses.Visited("^v"), 3);
            Assert.AreEqual(houses.Visited("^>v<"), 3);
            Assert.AreEqual(houses.Visited("^v^v^v^v^v"), 11);

            
            Trace.WriteLine(string.Format("Houses visited by Santa and Robo-Santa {0}", houses.Visited(input,2)));
        }*/
    }
}
