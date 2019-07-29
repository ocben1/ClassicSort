using System;
using System.Collections.Generic;
using System.Text;

namespace Vector
{
    public class InsertionSort : ISorter
    {
        public void Sort<K>(K[] sequence, IComparer<K> comparer) where K : IComparable<K>
        {
            for (int i = 0; i < sequence.Length; i++)
            {
                int j = i;
                while ((j > 0) && comparer.Compare(sequence[j - 1], sequence[j]) > 0)
                {
                    K tmp = sequence[j];
                    sequence[j] = sequence[j - 1];
                    sequence[j - 1] = tmp;
                    sequence[j] = sequence[j - 1];
                    j = j - 1;
                }
            }
        }
    }
}
