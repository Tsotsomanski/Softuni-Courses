using Exam_20_12._15.Enums;

namespace Exam_20_12._15.Interfaces
{
    public interface IBehavior
    {
        void Trigger(IBlob blob);

        void PerformNegativeEffects(IBlob blob);

        bool IsTriggered { get; }

        bool AlreadyTriggered { get; }
    }
}
