using Exam_20_12._15.Enums;
using Exam_20_12._15.Interfaces;

namespace Exam_20_12._15.Models.Attack
{
    class Attack: IAttack
    {


        public Attack(BlobAttackType attackType, int attackPerRound)
        {
            this.attackType = attackType;
            AttackPerRound = attackPerRound;
        }

        public BlobAttackType attackType { get; }
        public int AttackPerRound { get; }
    }
}
