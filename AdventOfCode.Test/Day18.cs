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
        private string input;
        private GameOfLife game;

        [TestInitialize]
        public void Initialize()
        {
            using (var file = new StreamReader("Input18.txt"))
            {
                this.input = file.ReadToEnd();
            }

            game = new GameOfLife();
        }

        [TestMethod]
        public void Part1()
        {
            var world = GameOfLife.World.Parse(input);

            var lightsOn = Enumerable.Range(0, 3)
                            .Aggregate(world, (acum, index) => game.Next(acum))
                            .Data.Count( x => x);

            Trace.WriteLine(string.Format("Lights on: {0}", lightsOn));
        }

    }
}
