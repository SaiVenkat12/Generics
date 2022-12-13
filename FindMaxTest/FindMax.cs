using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxTest
{
    public class FindMax
    {
        public static int num(int First, int SecondNo, int ThirdNo)
        {
            if (First.CompareTo(SecondNo) > 0 && First.CompareTo(ThirdNo) > 0)
            {
                return First;
            }
            if (SecondNo.CompareTo(First) > 0 && SecondNo.CompareTo(ThirdNo) > 0)
            {
                return SecondNo;
            }

            if (ThirdNo.CompareTo(First) > 0 && ThirdNo.CompareTo(SecondNo) > 0)
            {
                return ThirdNo;
            }
            throw new Exception("First, Second and Third Numbers are same");
        }
    }
}