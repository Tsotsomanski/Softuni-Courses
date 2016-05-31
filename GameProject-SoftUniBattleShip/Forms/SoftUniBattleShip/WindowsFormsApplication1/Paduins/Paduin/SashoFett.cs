using System;
using WindowsFormsApplication1.Interface.IPadaun.IPaduinStudents;

namespace WindowsFormsApplication1.Paduins.Paduin
{
    public class SashoFett : Paduin, ISashoFett
    {
        private string characterImage = @"..\..\Resources\Sasho.png";

        public SashoFett()
        {
            this.PaduinType = PaduinType.SashoFett;
        }

        public override int BeerPerSecond
        {
            get { return this.beerPerSecond; }
            set { this.beerPerSecond = 3; }
        }

        public override PaduinType PaduinType { get; set; }

        public override string CharacterImage
        {
            get { return this.characterImage; }
            set { this.characterImage = value; }
        }

        public override int PointKnowledge
        {
            get { return this.pointKnowledge; }
            set { this.pointKnowledge += value; }
        }

        public override int PaduinPower
        {
            get { return this.paduinPower; }
            set { this.paduinPower = 50; }
        }

        public override void KnowledgeCalculator()
        {
            if (this.PaduinPower < this.PointKnowledge)
            {
                Console.WriteLine("Paduin have knowledge");
            }
        }
    }
}