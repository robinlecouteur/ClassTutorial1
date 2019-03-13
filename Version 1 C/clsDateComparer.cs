using System;
using System.Collections.Generic;

namespace Version_1_C
{
    public sealed class clsDateComparer : IComparer<clsWork>
    {
        private clsDateComparer() { }

        public static readonly clsDateComparer Instance = new clsDateComparer();


        public int Compare(clsWork x, clsWork y)
        {
            DateTime lcDateX = x.Date;
            DateTime lcDateY = y.Date;

            return lcDateX.CompareTo(lcDateY);
        }
    }
}
