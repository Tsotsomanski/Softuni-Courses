using Exam_20_12._15.Interfaces;

namespace Exam_20_12._15.Models.Behavior
{
    public abstract class Behavior : IBehavior
    {
        protected const string ExceptionMessage = "Behavior can be triggered only once";

        public bool IsTriggered { get; protected set; }

        public bool AlreadyTriggered { get; protected set; }

        public bool ShouldDelayBeforeExecution { get; set; } = true;

        public abstract void Trigger(IBlob blob);

        public abstract void PerformNegativeEffects(IBlob blob);
    }
}
