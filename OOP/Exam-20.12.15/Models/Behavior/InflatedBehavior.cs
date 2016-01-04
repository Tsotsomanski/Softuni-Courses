using Exam_20_12._15.Enums;
using Exam_20_12._15.Interfaces;

namespace Exam_20_12._15.Models.Behavior
{
    public class InflatedBehavior : IInflatedBehavior
    {
        private BlobsBehaviorType inflateretBehavior = BlobsBehaviorType.Inflated;


        public InflatedBehavior(BlobsBehaviorType inflateretBehavior, bool isBehaviorTriggered)
        {
            BehaviorType = inflateretBehavior;
            IsBehaviorTriggered = isBehaviorTriggered;
        }


        public BlobsBehaviorType BehaviorType { get; }

        public bool IsBehaviorTriggered { get; }


        public int BlobGainsHealth()
        {
            throw new System.NotImplementedException();
        }

        public int BlobLosesHealth()
        {
            throw new System.NotImplementedException();
        }
    }
}
