using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ETCold
{
    public class StringCompareByInt<T> : IComparer<T>
    {
        public Func<T, string> getString { get; set; }
        public int Compare(T x, T y)
        {
            string a = getString(x).Trim();
            string b = getString(y).Trim();
            string r = @"[0-9]+";
            Regex reg = new Regex(r, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            MatchCollection mcA = reg.Matches(a);//设定要查找的字符串

            int intA = -1;
            foreach (Match m in mcA)
            {
                intA = int.Parse(m.Groups[0].Value);
            }
            MatchCollection mcB = reg.Matches(b);//设定要查找的字符串

            int intB = -1;
            foreach (Match m in mcB)
            {
                intB = int.Parse(m.Groups[0].Value);
            }
            if (intA == -1 || intB == -1)
            {
                return a.CompareTo(b);
            }

            return intA.CompareTo(intB);
        }
    }
    public class StringCompare<T> : IComparer<T>
    {
        public Func<T, string> getString { get; set; }
        public int Compare(T x, T y)
        {
            return getString(x).CompareTo(getString(y));
        }
    }
    public class CompareHelper
    {

    }
}
