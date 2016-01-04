using System;

namespace OOPExamPrepare_Empires.Models.Units
{
    class Archer : Unit
    {
        private static int ArcherAttackDamage = 7;
        private static int ArcherHealth = 25;

        public Archer() 
            : base(ArcherAttackDamage, ArcherHealth)
        {
        }
    }
}
