using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Houses
    {
        private int DeltaX(char chr) => chr == '<' ? -1 : (chr == '>' ? 1 : 0);
        private int DeltaY(char chr) => chr == 'v' ? -1 : (chr == '^' ? 1 : 0);

        public int Visited(IEnumerable<char> instructions)
        {
            return instructions.Aggregate(new List<Tuple<int, int>> { Tuple.Create<int, int>(0, 0) }, (acum, inst) => {
                acum.Add(Tuple.Create<int, int>(acum.LastOrDefault().Item1 + DeltaX(inst), acum.LastOrDefault().Item2 + DeltaY(inst)));
                return acum;
                })
                .Distinct()
                .Count();
        }

        /* Unfinished
        public int Visited(IEnumerable<char> instructions, int workers)
        {
            return instructions.Aggregate(new List<Tuple<int, int>> { Tuple.Create<int, int>(0, 0) }, (acum, inst) => {
                int worker = acum.Count();
                acum.Add(Tuple.Create<int, int>(acum.LastOrDefault().Item1 + DeltaX(inst), acum.LastOrDefault().Item2 + DeltaY(inst)));
                return acum;
            })
                .Distinct()
                .Count();
        }*/
    }
}
