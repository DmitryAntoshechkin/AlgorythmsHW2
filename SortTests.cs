using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name11
{

    [MemoryDiagnoser]
    public class SortTests
    {
        static int[] array = ArrayUtils.prepareArray(50000);


        [Benchmark]
        public void DirectSortTest()
        {
            SortUtils.directSort((int[])array.Clone());
        }

        [Benchmark]
        public void QuickSortTest()
        {
            SortUtils.quickSort((int[])array.Clone());
        }

        [Benchmark]
        public void PyramSortTest()
        {
            SortUtils.pyramSort((int[])array.Clone());
        }

    }
}
