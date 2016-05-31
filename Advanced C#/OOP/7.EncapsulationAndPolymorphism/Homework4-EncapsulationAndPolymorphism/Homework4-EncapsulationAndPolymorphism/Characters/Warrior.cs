using System;

namespace Homework4_EncapsulationAndPolymorphism.Characters
{
    class Warrior : AdvancedCharacter //, IAttack
    {
        private int attackPoints;
        private const int AttackPointsDefaut = 150;
        private const int DeffencePointsDefaut = 100;
        private const int HealtPointsDefaut = 200;
        private const int RangeDefaut = 2;

        public Warrior(int AttackPointsDefaut, int DeffencePointsDefaut, int HealtPointsDefaut, int RangeDefaut)
        {

        }
        public int AttackPoints { get; set; }
    }
}
