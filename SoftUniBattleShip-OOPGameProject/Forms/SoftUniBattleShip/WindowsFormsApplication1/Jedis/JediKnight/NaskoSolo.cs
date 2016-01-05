using System;
using WindowsFormsApplication1.Interface;
using WindowsFormsApplication1.Interface.IJedi.IJediKnight;
using WindowsFormsApplication1.Jedis.AsistentJedi;

namespace WindowsFormsApplication1.Jedis.JediKnight
{
    public class NaskoSolo : JediKnight, INaskoSolo
    {
        private string characterImage = @"..\..\Resources\Nasko.png";
        
        public NaskoSolo() : base()
        {
            this.JediType = JediType.NaskoSolo;
            this.knowledgeDamage = 15;
            this.thePower = 70;
            this.points = 15;
        }

        public override string CharacterImage
        {
            get { return this.characterImage; }
            set { this.characterImage = value; }
        }

        public override int KnowledgeDamage
        {
            get { return this.knowledgeDamage; }
            set { this.knowledgeDamage = value; }
        }

        public override int ThePolerOfDrinks
        {
            get { return this.thePower; }
            set { this.thePower = value; }
        }

        public override int PointsDamage
        {
            get { return this.points; }
            set { this.points = value; }
        }

        public override void Points()
        {
            if (this.PointsDamage > this.ThePolerOfDrinks)
            {
                Console.WriteLine("NaskoSolo is drunk!!!");
            }
        }
    }
}