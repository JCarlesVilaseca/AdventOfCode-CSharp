using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public class PaperWrapper
    {
        public class Box
        {
            public int Width { get; set; }
            public int Length { get; set; }
            public int Height { get; set; }
        }

        public int PaperRequired(IEnumerable<Box> boxes)
        {
            return boxes.Select(x => PaperRequired(x)).Sum();
        }

        public int PaperRequired(Box box)
        {
            return new int[] { box.Length * box.Width, box.Width * box.Height, box.Length * box.Height }
                .Sum() * 2
                
                + new int[] { box.Length, box.Width, box.Height}
                .OrderBy(x => x)
                .Take(2)
                .Aggregate((acum, side) => acum * side);
        }

        public int RibbonRequired(IEnumerable<Box> boxes)
        {
            return boxes.Select(x => RibbonRequired(x)).Sum();
        }

        public int RibbonRequired(Box box)
        {
            return new int[] { box.Length, box.Width, box.Height }
                .OrderBy(x => x)
                .Take(2)
                .Sum() * 2
                + box.Length * box.Width * box.Height;
        }
    }
}
