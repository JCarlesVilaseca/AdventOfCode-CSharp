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
            Assert.AreEqual(4,filler.TotalCombinations(new List<int> { 20,15,10,5,5},25));

            var comb = GetPermutations(new List<int> { 20, 15, 10, 5 });

            foreach(var c in comb)
            {
                Trace.WriteLine(string.Join(",",c.Select((x) => x.ToString()).ToArray()));
            }

            //Trace.WriteLine(string.Format("Number of combinations {0}", filler.TotalCombinations(input,150)));
        }

        public static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> items)
        {
            if (items.Count() > 1)
            {
                return items.SelectMany(item => GetPermutations(items.Where(i => !i.Equals(item))),
                                       (item, permutation) => new[] { item }.Concat(permutation));
            }
            else
            {
                return new[] { items };
            }
        }

    }
}
