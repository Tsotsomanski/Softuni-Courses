using System;
using Exam_20_12._15.Enums;
using Exam_20_12._15.Interfaces;

namespace Exam_20_12._15.Models.Behavior
{
    public abstract class Behavior : IBehavior
    {
        public BlobsBehaviorType BehaviorType { get; }
        public bool IsBehaviorTriggered { get; }
    }
}
