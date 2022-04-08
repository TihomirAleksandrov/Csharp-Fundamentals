using System;
using System.Numerics;

namespace Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger biggestSnowballValue = new BigInteger (0);
            int biggestSnowballSnow = 0;
            int biggestSnowballTime = 0;
            int biggestSnowballQuality = 0;
            int snowballsNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < snowballsNum; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (snowballValue > biggestSnowballValue)
                {
                    biggestSnowballValue = snowballValue;
                    biggestSnowballQuality = snowballQuality;
                    biggestSnowballSnow = snowballSnow;
                    biggestSnowballTime = snowballTime;
                }
            }

            if (snowballsNum != 0)
            {
                Console.WriteLine($"{biggestSnowballSnow} : {biggestSnowballTime} = {biggestSnowballValue} ({biggestSnowballQuality})");
            }
        }
    }
}
