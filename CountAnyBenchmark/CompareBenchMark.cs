using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountAnyBenchmark
{
    public class CompareBenchMark
    {
        private static readonly IEnumerable<int> _numbers = Enumerable.Range(1, 100000);
        
        [Benchmark]
        public bool CheckAny()
        {
            return _numbers.Any();
        }

        [Benchmark]
        public bool CheckCount()
        {
            return _numbers.Count()>0;
        }

        [Benchmark]
        public bool CheckAnyWithCondition()
        {
            return _numbers.Any(n=>n%2000>0);
        }

        [Benchmark]
        public bool CheckCountWithCondition()
        {
            return _numbers.Count(n => n % 2000 > 0) > 0;
        }
    }
}
