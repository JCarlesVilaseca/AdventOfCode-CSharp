using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace AdventOfCode
{
    public class CoinMiner
    {
        public string NextHash(string secret, int zeros)
        {
            using (MD5 md5 = MD5.Create())
            {
                return (from num in Enumerable.Range(0, int.MaxValue)
                       let hash = md5.ComputeHash(Encoding.UTF8.GetBytes(secret + num))
                       where hash.Take(zeros/2).All(x => x == 0)
                           && (zeros % 2 == 0 || hash[zeros/2] < 0x10)
                       select num).First().ToString();
            }
        }
    }
}
