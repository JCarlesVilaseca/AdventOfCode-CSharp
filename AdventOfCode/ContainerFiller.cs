using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class ContainerFiller
    {
        public int TotalCombinations(IEnumerable<int> containers, int liters)
        {
            return Combinations(containers, -1, liters);
        }


        private int Combinations(IEnumerable<int> allContainers, int lastIndex, int rest)
        {
            var newSelection = from pair in allContainers.Select((container, index) => new { container = container, index = index })
                               where pair.index > lastIndex
                                    && pair.container <= rest
                               select pair;

            int match = 0;

            if (newSelection.Count() > 0)
            {
                foreach(var container in newSelection)
                {
                    var newRest = rest - container.container;

                    if (newRest == 0)
                    {
                        match++;
                    }
                    else
                        match += Combinations(allContainers, container.index, newRest);
                }
            }
            
            return match;
        }
    }
}
