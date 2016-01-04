using System;

namespace OOPExamPrepare_Empires.Models.Units
{
    class Swordsman : Unit
    {
        private static int SwordsmanAttackDamage = 13;
        private const int SwordsmanHealth = 40;
        
        public Swordsman() 
            : base(SwordsmanAttackDamage, SwordsmanHealth)
        {
        }
    }
}
