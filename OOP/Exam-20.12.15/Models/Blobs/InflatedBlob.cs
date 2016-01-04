using Exam_20_12._15.Enums;

namespace Exam_20_12._15.Models.Blobs
{
    class InflatedBlob : Blob
    {
        public const BlobsBehaviorType InflatedBehaviorType = BlobsBehaviorType.Aggressive;

        public InflatedBlob(string name, int blobHealth, int blobAttackDamage) 
            : base(name, blobHealth, blobAttackDamage)
        {
        }
    }
}
