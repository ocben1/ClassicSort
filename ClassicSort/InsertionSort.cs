using System;
using System.Collections.Generic;
using System.Text;

namespace Vector
{

    public class InsertionSort : ISorter
    {
        public int Count { get; private set; } = 0;

        public void Sort<K>(K[] sequence, IComparer<K> comparer) where K : IComparable<K>
        {
            for (var r = 1; r < sequence.Length; r++)
            {
                var current = sequence[r];

                for (var l = r - 1; l >= 0 && sequence[l].CompareTo(current) > 0; l--)
                {
                    sequence[l + 1] = sequence[l];
                    sequence[l] = current;
                }
            }
        }
    }
}
