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
            public IEnumerable<bool> Data { get; set; }
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

        private int Neighbours(World world, int cellIndex)
        {
            var x = cellIndex % world.Width;
            var y = cellIndex / world.Width;

            int rows = world.Data.Count() / world.Width;

            return (from xx in Enumerable.Range(x - 1, 3)
                    from yy in Enumerable.Range(y - 1, 3)
                    where xx >= 0
                         && yy >= 0
                         && xx < world.Width
                         && yy < rows
                         && (xx != x || yy != y)
                    select world.Data.Skip(yy * world.Width + xx).Take(1).First() ? 1 : 0
                    ).Sum();
        }

        public World Next(World world)
        {
            return new World
            {
                Width = world.Width,
                Data = world.Data.Select( (cell,index) =>
                {
                    var neighbours = Neighbours(world, index);

                    if (cell)
                        return neighbours == 2 || neighbours == 3;
                    else
                        return neighbours == 3;
                })
            };
        }
    }
}
