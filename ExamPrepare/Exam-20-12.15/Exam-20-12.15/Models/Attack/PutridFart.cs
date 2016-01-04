using Exam_20_12._15.Enums;
using Exam_20_12._15.Interfaces;

namespace Exam_20_12._15.Models.Attack
{
    class PutridFart : IPutridFartAttack
    {
        public void ExecuteAttack(IBlob target, int damage)
        {
            target.Respond(damage);
        }

        public void ExecuteEffectsOnAttacker(IBlob attacker)
        {
        }
    }
}
