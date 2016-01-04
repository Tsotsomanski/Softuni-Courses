using Exam_20_12._15.Interfaces;

namespace Exam_20_12._15.Models.Attack
{
    public abstract class Attack : IAttack
    {
        public abstract void ExecuteAttack(IBlob target, int damage);

        public abstract void ExecuteEffectsOnAttacker(IBlob attacker);
    }
}
