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
    public class Day19
    {
        private ChemistryMachine machine;
        private List<Tuple<string, string>> replacements = new List<Tuple<string, string>>();
        private string molecule;

        [TestInitialize]
        public void Initialize()
        {
            using (var file = new StreamReader("Input19.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Length > 0)
                    {
                        var match = Regex.Match(line, @"(.+) => (.+)");

                        if (match.Success)
                            replacements.Add(Tuple.Create(match.Groups[1].Value, match.Groups[2].Value));
                        else
                            molecule = line;
                    }
                }
            }

            machine = new ChemistryMachine();
        }

        [TestMethod]
        public void Part1()
        {
            var replacementsTest = new List<Tuple<string, string>>();
            replacementsTest.Add(Tuple.Create("H","HO"));
            replacementsTest.Add(Tuple.Create("H","OH"));
            replacementsTest.Add(Tuple.Create("O","HH"));

            Assert.AreEqual(4, machine.Calibrate(replacementsTest, "HOH"));

            Trace.WriteLine(string.Format("Distinct molecules {0}", machine.Calibrate(replacements, molecule)));
        }
    }
}
