﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumGeneric
{
    public class FindMaximum
    {
        public int FindMaxInt(int firstInt, int secondInt, int thirdInt)
        {
            if (firstInt.CompareTo(secondInt) > 0 && firstInt.CompareTo(thirdInt) > 0)
            {
                return firstInt;
            }
            else if (secondInt.CompareTo(thirdInt) > 0)
            {
                return secondInt;
            }
            else
            {
                return thirdInt;
            }
        }
    }
}
