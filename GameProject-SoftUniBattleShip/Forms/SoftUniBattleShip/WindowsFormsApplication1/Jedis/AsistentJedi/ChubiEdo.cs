using System;
using WindowsFormsApplication1.Interface;
using WindowsFormsApplication1.Interface.IJedi.IAssistants;

namespace WindowsFormsApplication1.Jedis.AsistentJedi
{
    public class ChubiEdo : Assistant, IChubiEdo
    {
        private string characterImage = @"..\..\Resources\Edo.png";
        
        public ChubiEdo() : base()
        {
            this.AssistantJediType = AssistantJediType.ChubiEdo;
            this.assistantLives = 40;
            this.assistantAttack = 12;
        }

        public override AssistantJediType AssistantJediType { get; set; }

        public override string CharacterImage
        {
            get { return this.characterImage; }
            set { this.characterImage = value; }
        }

        public override int AssistantLive
        {
            get { return this.assistantLives; }
            set { this.assistantLives = value; }
        }

        public override int AssistantAttack
        {
            get { return this.assistantAttack; }
            set { this.assistantAttack = value; }
        }
        
        public override int AssistantPoint
        {
            get { return this.assistantPoints; }
            set
            { this.assistantPoints += value; }
        }

        public override void Point()
        {
            if (this.AssistantPoint > this.AssistantLive)
            {
                Console.WriteLine("ChubiEdo is drunk!!!");
            }
        }
    }
}