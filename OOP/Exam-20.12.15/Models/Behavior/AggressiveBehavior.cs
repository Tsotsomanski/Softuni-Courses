using Exam_20_12._15.Enums;
using Exam_20_12._15.Interfaces;

namespace Exam_20_12._15.Models.Behavior
{
    class AggressiveBehavior : IAggressiveBehavior
    {
        private BlobsBehaviorType aggresiveBehaviorType = BlobsBehaviorType.Aggressive;

        public AggressiveBehavior(bool isBehaviorTriggered, BlobsBehaviorType aggresiveBehaviorType1)
        {
            this.BehaviorType = aggresiveBehaviorType;
            this.IsBehaviorTriggered = isBehaviorTriggered;
            this.aggresiveBehaviorType = aggresiveBehaviorType1;
        }


        public BlobsBehaviorType BehaviorType { get; }
        public bool IsBehaviorTriggered { get; }

        public int DoublesBlobDamage()
        {
            throw new System.NotImplementedException();
        }

        public int BlobLosesDamage()
        {
            throw new System.NotImplementedException();
        }
    }
}
