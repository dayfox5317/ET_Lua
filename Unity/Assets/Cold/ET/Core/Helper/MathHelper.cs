using System;
using System.Collections.Generic;
using System.Text;

namespace ETCold
{
    public static class MathHelper
    {
        public static bool Get2Flag(int num)
        {
            if (num < 1) return false;
            return (num & num - 1) == 0;
        }

        public static int RoundToInt(float d)
        {
            return (int)Math.Round((double)d, MidpointRounding.AwayFromZero);
        }
        public static int RoundToInt(double d)
        {
            return (int)Math.Round(d, MidpointRounding.AwayFromZero);
        }
        public static long RoundToLong(float d)
        {
            return (long)Math.Round((double)d, MidpointRounding.AwayFromZero);
        }

        public static void Clamp<T>(ref T value, T min, T max) where T : IComparable<T>
        {
            if (min.CompareTo(max) > 0)
                throw new Exception($"min is bigger than max");
            value = value.CompareTo(min) < 0 ? min : value.CompareTo(max) > 0 ? max : value;
        }
        public static void ClampMin<T>(ref T value, T min) where T : IComparable<T>
        {
            value = value.CompareTo(min) < 0 ? min : value;
        }
        public static void ClampMax<T>(ref T value, T max) where T : IComparable<T>
        {
            value = value.CompareTo(max) > 0 ? max : value;
        }
        public static bool IsHit(float p)
        {
            return p > RandomHelper.RandomFloat();
        }

    }
}
