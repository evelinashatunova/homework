using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var brackets = "()[]{}<>";
            var dict = new Dictionary<char, char>();
            for (var i = 1; i < brackets.Length; i += 2)
                dict[brackets[i]] = brackets[i - 1];

        }
    }
}
