using Exam_20_12._15.Enums;
using Exam_20_12._15.Interfaces;

namespace Exam_20_12._15.Models.Attack
{
    class PutridFart : IPutridFartAttack
    {
        public BlobAttackType attackType { get; }
        public int AttackPerRound { get; }

        public int ProduceAttack()
        {
            throw new System.NotImplementedException();
        }
    }
}
