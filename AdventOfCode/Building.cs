using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public class Building
    {
        public int Floor(IEnumerable<char> instructions)
        {
            return instructions.Aggregate(0,(acum, chr) => acum + (chr == '(' ? 1 : -1) );
        }

        public int Basement(IEnumerable<char> instructions)
        {
            return instructions
                .Aggregate(new List<int>(), (acum, chr) =>
                {
                    acum.Add(acum.LastOrDefault() + (chr == '(' ? 1 : -1));
                    return acum;
                })
                .IndexOf(-1);
        }
    }
}
