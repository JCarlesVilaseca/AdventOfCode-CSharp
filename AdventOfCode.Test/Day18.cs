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
    public class Day18
    {
        private List<int> input = new List<int>();
        private GameOfLife game;

        [TestInitialize]
        public void Initialize()
        {
            /*
            using (var file = new StreamReader("Input17.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                    input.Add(int.Parse(line));
            }
            */

            game = new GameOfLife();
        }

        [TestMethod]
        public void Part1()
        {
            var world = GameOfLife.World.Parse( 
              @".#.#.#
                ...##.
                #....#
                ..#...
                #.#..#
                ####..");

            var next = game.Next(world);
            Trace.WriteLine(next.ToString());
            Assert.AreEqual("", next);
        }

    }
}
