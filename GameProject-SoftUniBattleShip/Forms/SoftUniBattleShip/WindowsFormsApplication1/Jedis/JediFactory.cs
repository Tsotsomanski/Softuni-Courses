using System;
using WindowsFormsApplication1.Interface;
using WindowsFormsApplication1.Interface.IJedi;
using WindowsFormsApplication1.Jedis.JediKnight;
using WindowsFormsApplication1.Jedis.Masters;

namespace WindowsFormsApplication1.Jedis
{
    class JediFactory
    {
        public static IJedi CreatJedi(JediType type)
        {
            switch (type)
            {
                case JediType.JoNakov:
                    return new JoNakov();
                case JediType.AchoUanKenobi:
                    return new AchoUanKenobi();
                case JediType.RoyalSkyWalker:
                    return new RoyalSkyWalker();
                case JediType.NaskoSolo:
                    return new NaskoSolo();
                default:
                    throw new ArgumentException();
            } 
        }
    }
}
