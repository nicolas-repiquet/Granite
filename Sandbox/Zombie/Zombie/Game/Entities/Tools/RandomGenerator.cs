using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.Game.Entities.Tools
{
    public class RandomGenerator
    {
        private static RandomGenerator s_instance;
        public static RandomGenerator Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new RandomGenerator();
                }
                return s_instance;
            }
        }

        private Random m_random;

        public Random Random { get { return m_random; } }

        public RandomGenerator()
        {
            m_random = new Random();
        }
    }
}
