using Exam_20_12._15.Enums;

namespace Exam_20_12._15.Interfaces
{
    interface IBlobFactory
    {
        IBlob CreateBlob(string name, int blobHealth, int blobAttackDamage, BlobsBehaviorType behaviorType,
            BlobAttackType attackType);
    }
}
