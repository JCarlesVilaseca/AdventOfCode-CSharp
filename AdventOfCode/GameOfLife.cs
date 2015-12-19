using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class GameOfLife
    {
        public class World
        {
            public bool[] Data { get; set; }
            public int Width { get; set; }

            public override string ToString()
            {
                return string.Join(Environment.NewLine,
                    Data.Select((x, index) => new { x = x, index = index })
                    .GroupBy(grp => grp.index / Width)
                    .Select(x => string.Join("", x.Select(g => g.x ? "#" : "."))));
            }

            public static World Parse(string str)
            {
                return new World {
                    Width = str.IndexOf(Environment.NewLine),
                    Data = str.Where(x => x=='#' || x=='.').Select(x => x == '#' ? true : false).ToArray()
                };
            }
        }

        public World Next(World world)
        {
            return world;
        }
    }
}
