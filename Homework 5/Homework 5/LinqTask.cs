using System;
using System.Linq;

namespace Homework_5
{
    public class LinqTask
    {
        public string[] GetWordsArray(string[] lines)
        {
            return lines
                .Select(line => line.Split())
                .SelectMany(words => words)
                .Where(word => Char.IsUpper(word[0]))
                .OrderBy(word => word)
                .ToArray();
        }
    }
}
