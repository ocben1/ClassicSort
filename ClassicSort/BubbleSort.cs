using System;
using System.Collections.Generic;
using System.Text;

namespace Vector
{
    public class BubbleSort : ISorter
    {
        public int Count { get; private set; } = 0;

        public void Sort<K>(K[] sequence, IComparer<K> comparer) where K : IComparable<K>
        {
            //comparer = Comparer<K>.Default;

            for (int i = 0; i < sequence.Length; i++)
            for (int j = 0; j < sequence.Length - i; j++)
                if (comparer.Compare(sequence[j], sequence[j + 1]) > 0)
                {
                        K tmp = sequence[j + 1];
                        sequence[j + 1] = sequence[j];
                        sequence[j] = tmp;
                    //Swap(sequence[j], sequence[j + 1]);
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

