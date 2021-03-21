using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public sealed class RandomGenerator
    {
        private static volatile RandomGenerator instance=null;
        private static object lockthis= new object();

        private Random rnd;

        public RandomGenerator()
        {
            rnd = new Random();
        }

        public static RandomGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockthis)
                    {
                        if (instance == null)
                        {
                            instance = new RandomGenerator();
                        }
                    }
                }
                return instance;
            }
        }

        public int GetRandom(int a,int b)
        {
            return rnd.Next(a, b);
        }
    }
}
