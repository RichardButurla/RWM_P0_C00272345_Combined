using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void CombinedFilterSimple()
        {
            int[] input = { 4, 3, 6, 30, 10, 12 };
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 4, 1, 3, 24, 20, 2 };


            CollectionAssert.AreEqual(expected, output);
        }
    }
}

