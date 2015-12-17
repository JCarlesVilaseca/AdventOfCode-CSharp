using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public class ContainerFiller
    {
        public int TotalCombinationsCount(IEnumerable<int> containers, int liters)
        {
            return Enumerable
                .Range(1, (1 << containers.Count()) - 1)
                .Select(index => containers.Where((item, idx) => ((1 << idx) & index) != 0))
                .Where(x => x.Sum() == liters)
                .Count();
        }

        public int ShortestCombinationsCount(IEnumerable<int> containers, int liters)
        {
            return Enumerable
                .Range(1, (1 << containers.Count()) - 1)
                .Select(index => containers.Where((item, idx) => ((1 << idx) & index) != 0))
                .Where(x => x.Sum() == liters)
                .GroupBy(x => x.Count())
                .OrderBy(x => x.Key)
                .First()
                .Count();
        }
    }
}
