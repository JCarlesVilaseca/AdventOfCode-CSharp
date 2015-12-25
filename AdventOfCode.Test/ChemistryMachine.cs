using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode.Test
{
    public class ChemistryMachine
    {
        public int Calibrate(IEnumerable<Tuple<string, string>> replacements, string molecule)
        {
            return replacements
                    .SelectMany(x => Regex
                        .Matches(molecule, x.Item1)
                        .Cast<Match>()
                        .Select(m => molecule.Remove(m.Index, m.Value.Length).Insert(m.Index, x.Item2)))
//                        .Distinct())
                    .Distinct()
                    .Count();
        }
    }
}
