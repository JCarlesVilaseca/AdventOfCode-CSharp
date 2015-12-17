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
    public class Day02
    {
        private List<PaperWrapper.Box> input = new List<PaperWrapper.Box>();
        private PaperWrapper wrapper;

        [TestInitialize]
        public void Initialize()
        {
            using (var file = new StreamReader("Input02.txt"))
            {
                string line;
                while((line = file.ReadLine()) != null) 
                {
                    var match = Regex.Match(line, @"(\d+)x(\d+)x(\d+)");

                    input.Add( new PaperWrapper.Box { Length = int.Parse(match.Groups[1].Value), Width = int.Parse(match.Groups[2].Value), Height = int.Parse(match.Groups[3].Value) });
                }
            }

            wrapper = new PaperWrapper();
        }

        [TestMethod]
        public void Part1()
        {
            Assert.AreEqual(wrapper.PaperRequired(new PaperWrapper.Box { Length = 2, Width = 3, Height = 4 }), 58);

           Trace.WriteLine(string.Format("Paper required {0}", wrapper.PaperRequired(input)));
        }

        [TestMethod]
        public void Part2()
        {
            Assert.AreEqual(wrapper.RibbonRequired(new PaperWrapper.Box { Length = 2, Width = 3, Height = 4 }), 34);

            Trace.WriteLine(string.Format("Ribbon required {0}",wrapper.RibbonRequired(input)));
        }
    }
}
