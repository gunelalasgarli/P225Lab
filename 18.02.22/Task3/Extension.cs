using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    static class Extension
    {
        #region Task-1
        //Extension method yaziriq, bir string qəbul edir,birde int gelir,
        //verilen eded tekdirse geriye sözü qaytarır, cütdürsə sözə 's əlaye edir qaytarir. 
        public static string AddExt(this string str, int num)
        {
            if (num % 2 == 0)
            {
                str += "s";
            }


            return str;
        }
        #endregion

        #region Task-2
        public static int SumNum(this int a, int b)
        {
            return a + b;
        }


        #endregion



    }
}
