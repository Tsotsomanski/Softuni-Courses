using WindowsFormsApplication1.Interface.IJedi.IMasters;
using WindowsFormsApplication1.Jedis.AsistentJedi;

namespace WindowsFormsApplication1.Jedis.Masters
{
    public abstract class Masters : Jedi, IMasters
    {
        protected int knowledgeDamage;
        protected int thePower;
        protected int point;

        protected Masters()
        {
        }

        public abstract override void Points();

    }
}