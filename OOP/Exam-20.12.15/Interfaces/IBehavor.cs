using Exam_20_12._15.Enums;

namespace Exam_20_12._15.Interfaces
{
    public interface IBehavior
    {
        BlobsBehaviorType BehaviorType { get; }
        bool IsBehaviorTriggered { get; }
    }
}
