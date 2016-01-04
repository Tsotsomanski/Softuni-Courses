using Exam_20_12._15.Enums;

namespace Exam_20_12._15.Interfaces
{
    public interface IAttack
    {
        void ExecuteAttack(IBlob target, int damage);

        void ExecuteEffectsOnAttacker(IBlob attacker);
    }
}
