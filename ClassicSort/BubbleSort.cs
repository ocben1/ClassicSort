using System;
using System.Collections.Generic;
using System.Text;

namespace Vector
{
    public class BubbleSort : ISorter
    {

        public void Sort<K>(K[] sequence, IComparer<K> comparer) where K : IComparable<K>
        {
            for (int i = 0; i < sequence.Length; i++)
                for (int j = 0; j < sequence.Length - i -1; j++)
                    if (comparer.Compare(sequence[j], sequence[j + 1]) > 0)
                    {
                        K tmp = sequence[j];
                        sequence[j] = sequence[j+1];
                        sequence[j+1] = tmp;
                    }
        }

    }
}

