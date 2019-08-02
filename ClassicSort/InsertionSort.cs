﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vector
{
    //to do REFACTOR.
    //code adapted from https://www.codesdope.com/blog/article/sorting-an-array-using-insertion-sort-in-c/
    public class InsertionSort : ISorter
    {
        public void Sort<K>(K[] sequence, IComparer<K> comparer) where K : IComparable<K>
        {
            for (int i = 1; i < sequence.Length; i++)
            {
                int j = i; //selects the first unsorted element
                //this while loop shifts all the elements to the right to create the position for the
                //unsorted element
                while ((j > 0) && comparer.Compare(sequence[j - 1], sequence[j]) > 0) //while the elements arent sorted..
                {
                    //perform the insertion as a variable swap
                    K tmp = sequence[j];
                    sequence[j] = sequence[j - 1];
                    sequence[j - 1] = tmp;
                    sequence[j] = sequence[j - 1];
                    //then consider previous element for comparison
                    j = j - 1;
                }
                
            }
        }
    }
}
