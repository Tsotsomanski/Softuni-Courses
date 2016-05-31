using WindowsFormsApplication1.Interface.IJedi.IJediKnight;
using WindowsFormsApplication1.Jedis.AsistentJedi;

namespace WindowsFormsApplication1.Jedis.JediKnight
{
    using Interface;

    public class JediKnight : Jedi, IJediKnight
    {
     
        protected int knowledgeDamage;
        protected int thePower;
        protected int points;

        public JediKnight():base()
        {
        }

        public override int PointsDamage { get; set; }

        public override int KnowledgeDamage { get; set; }

        public override int ThePolerOfDrinks { get; set; }

        public override JediType JediType { get; set; }

        public override Assistant Assistant { get; set; }

        public override string CharacterImage { get; set; }

        public override void Points()
        {
            throw new System.NotImplementedException();
        }
    }
}