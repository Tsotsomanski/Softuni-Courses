using System;
using WindowsFormsApplication1.Interface;
using WindowsFormsApplication1.Interface.IJedi.IMasters;
using WindowsFormsApplication1.Jedis.AsistentJedi;

namespace WindowsFormsApplication1.Jedis.Masters
{
    public class JoNakov : Masters, IJoNakov
    {
        private string characterImage = @"..\..\Resources\Nakov.png";

        public JoNakov() : base()
        {
            this.JediType = JediType.JoNakov;
            this.knowledgeDamage = 30;
            this.thePower = 100;
            this.point = 25;
        }

        public override JediType JediType { get; set; }

        public override Assistant Assistant { get; set; }

        public override string CharacterImage
        {
            get { return this.characterImage; }
            set { this.characterImage = value; }
        }

        public override int KnowledgeDamage
        {
            get { return this.knowledgeDamage; }
            set { this.knowledgeDamage = 30; }
        }

        public override int ThePolerOfDrinks
        {
            get { return this.thePower; }
            set { this.thePower = 100; }
        }

        public override int PointsDamage
        {
            get { return this.point; }
            set { this.point = 5; }
        }

        public override void Points()
        {
            if (this.PointsDamage > this.ThePolerOfDrinks)
            {
                Console.WriteLine("JoNakov is drunk!!!");
            }
        }
    }
}