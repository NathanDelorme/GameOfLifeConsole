using System;

namespace GameOfLifeConsole
{
    public static class Utils
    {

        public static class Random
        {
            public static bool Bool()
            {
                return new System.Random().NextDouble() >= 0.5;
            }
        }
        
        public static class PseudoRandom
        {
            public static bool Bool(double trueProb)
            {
                if (trueProb < 0.0 || trueProb > 1.0)
                    throw new ArgumentException("Utils - pseudoRandomBool : trueProb value not between 0.0 and 1.0.");
                return new System.Random().NextDouble() <= trueProb;
            }
        }
    }
}