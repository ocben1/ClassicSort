using System;
using System.Collections.Generic;
using System.Text;

namespace Vector
{
    public class SelectionSort : ISorter
    {
        public void Sort<K>(K[] sequence, IComparer<K> comparer) where K : IComparable<K>
        {
            for (int i = 0; i < sequence.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < sequence.Length; j++)
                {
                    if (comparer.Compare(sequence[j], sequence[min]) < 0)
                        min = j;
                }
                if (min != i)
                {
                    K tmp = sequence[min];
                    sequence[min] = sequence[i];
                    sequence[i] = tmp;
                }
            }
        }


            private void Swap<K>(K k1, K k2) where K : IComparable<K>
            {
                K tmp = k2;
                k2 = k1;
                k1 = tmp;
            }
        
    }
}
