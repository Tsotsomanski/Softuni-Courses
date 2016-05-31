using Exam_20_12._15.Enums;

namespace Exam_20_12._15.Models
{
    class AggressiveBlob: Blob
    {
        public static BlobsBehaviorType AggresiveBehaviorType = BlobsBehaviorType.Aggressive;

        public AggressiveBlob(string name, int blobHealth, int blobAttackDamage) 
            : base(name, blobHealth, blobAttackDamage)
        {
        }
    }
}
