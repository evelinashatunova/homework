using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_5
{
    public class RecordsTask
    {
        public void GetRecordsInfo(List<Record> db)
        {
            var results = db
                .GroupBy(r => new { r.Year, r.Month })
                .Select(g => new
                {
                    g.Key.Year,
                    g.Key.Month,
                    Sum = g.Sum(r => r.Duration)
                })
                .OrderByDescending(r => r.Year)
                .ThenBy(r => r.Month);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.Sum} {result.Month} {result.Year}");
            }
        }
    }
}