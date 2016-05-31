using System.Drawing;
using WindowsFormsApplication1.Interface;
using WindowsFormsApplication1.Interface.IJedi;
using WindowsFormsApplication1.Jedis.AsistentJedi;

namespace WindowsFormsApplication1.Jedis
{
    public abstract class Jedi : IJedi
    {

        protected Jedi()
        {
        }

        public abstract int PointsDamage { get; set; }

        public abstract int KnowledgeDamage { get; set; }

        public abstract int ThePolerOfDrinks { get; set; }

        public abstract JediType JediType { get; set; }

        public abstract Assistant Assistant { get; set; }

        public abstract string CharacterImage { get; set; }

        public abstract void Points();
    }
}