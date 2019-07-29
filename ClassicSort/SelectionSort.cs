using System;
using System.Collections.Generic;
using System.Text;

namespace Vector
{

    public class SelectionSort : ISorter
    {
        public int Count { get; private set; } = 0;

        public void Sort<K>(K[] sequence, IComparer<K> comparer) where K : IComparable<K>
        {
            comparer = Comparer<K>.Default;
            int index_of_min = 0;
            for (int i = 0; i < Count - 1; i++)
            {
                index_of_min = i;
                for (int index = i + 1; index < Count; index++)
                {
                    if (comparer.Compare(sequence[index], sequence[index_of_min]) < 0)
                        index_of_min = index;
                }
                Swap(sequence[i], sequence[index_of_min]);
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
