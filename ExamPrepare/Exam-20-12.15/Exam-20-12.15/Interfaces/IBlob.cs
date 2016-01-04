using Exam_20_12._15.Enums;

namespace Exam_20_12._15.Interfaces
{
    public interface IBlob : IAttacker, IDestroyable
    {
        string Name { get; }

        int Health { get; set; }

        int AttackDamage { get; set; }

        bool IsAlive { get; }

        IBehavior Behavior { get; }

        IAttack Attack { get; }
    }
}
