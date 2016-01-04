using System;
using System.Runtime.CompilerServices;
using Exam_20_12._15.Enums;
using Exam_20_12._15.Interfaces;

namespace Exam_20_12._15.Models.Behavior
{
    public class InflatedBehavior : Behavior
    {
        int healthBonus = 50;
        int healthLostValue = 10;

        public override void Trigger(IBlob blob)
        {
            if (this.AlreadyTriggered)
            {
                throw new InvalidOperationException(ExceptionMessage);
            }
            this.IsTriggered = true;
            this.AlreadyTriggered = true;
            blob.Health += healthBonus;
        }

        

        public override void PerformNegativeEffects(IBlob blob)
        {
            if (ShouldDelayBeforeExecution)
            {
                this.ShouldDelayBeforeExecution = false;
            }
            else
            {
                blob.Health -= healthLostValue;
            }
        }
    }
}
