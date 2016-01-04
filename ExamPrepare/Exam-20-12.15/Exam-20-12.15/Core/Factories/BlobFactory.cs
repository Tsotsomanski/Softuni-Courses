using System;
using Exam_20_12._15.Enums;
using Exam_20_12._15.Interfaces;
using Exam_20_12._15.Models;
using Exam_20_12._15.Models.Attack;
using Exam_20_12._15.Models.Behavior;

namespace Exam_20_12._15.Core
{
    class BlobFactory : IBlobFactory
    {
        public IBlob CreateBlob(string name, int blobHealth, int blobAttackDamage, IBehavior behavior, IAttack attack)
        {
            return new Blob; 
        }
    }
}
