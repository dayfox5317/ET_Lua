using System;

namespace ETCold
{
	public static class RandomHelper
	{
        private static readonly Random random = new Random();

        public static UInt64 RandUInt64()
        {
            var bytes = new byte[8];
            random.NextBytes(bytes);
            return BitConverter.ToUInt64(bytes, 0);
        }

        public static Int64 RandInt64()
        {
            var bytes = new byte[8];
            random.NextBytes(bytes);
            return BitConverter.ToInt64(bytes, 0);
        }

        /// <summary>
        /// 获取lower与Upper之间的随机数
        /// </summary>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static int RandomNumber(int lower, int upper)
        {
            int value = random.Next(lower, upper);
            return value;
        }
        public static float RandomFloat()
        {
            return (float)random.NextDouble();
        }
        public static float RandomFloat(float min, float max)
        {
            return UnityEngine.Random.Range(min, max);
        }
        public static UnityEngine.Color RandColor()
        {
            return new UnityEngine.Color(RandomHelper.RandomFloat(), RandomHelper.RandomFloat(), RandomHelper.RandomFloat());
        }

    }
}
