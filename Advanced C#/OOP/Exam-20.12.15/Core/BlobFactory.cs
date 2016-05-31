using System;
using System.Collections;
using Exam_20_12._15.Enums;
using Exam_20_12._15.Interfaces;
using Exam_20_12._15.Models;
using Exam_20_12._15.Models.Blobs;

namespace Exam_20_12._15.Core
{
    class BlobFactory : IBlobFactory
    {
        public IBlob CreateBlob(string name, int blobHealth, int blobAttackDamage, BlobsBehaviorType behaviorType,
            BlobAttackType attackType)
        {
            switch (behaviorType)
            {
                case BlobsBehaviorType.Aggressive:
                    return new AggressiveBlob(name, blobHealth, blobAttackDamage);
                case BlobsBehaviorType.Inflated:
                    return new InflatedBlob(name, blobHealth,blobAttackDamage);
                default:
                    throw new ArgumentException("Unknown behavior type.");
            }
        }
    }
}
