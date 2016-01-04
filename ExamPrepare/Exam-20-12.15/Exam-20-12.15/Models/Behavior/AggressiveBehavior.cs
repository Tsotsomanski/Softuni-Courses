using System;
using Exam_20_12._15.Interfaces;

namespace Exam_20_12._15.Models.Behavior
{
    class AggressiveBehavior : Behavior
    {
        private const int DamageReductionValue = 5;
        private int initialBlobDamage;

        public override void Trigger(IBlob blob)
        {
            if (this.AlreadyTriggered)
            {
                throw new InvalidOperationException(ExceptionMessage);
            }

            this.IsTriggered = true;
            this.AlreadyTriggered = true;
            this.initialBlobDamage = blob.AttackDamage;
            blob.AttackDamage = blob.AttackDamage*2;
        }

        public override void PerformNegativeEffects(IBlob blob)
        {
            if (ShouldDelayBeforeExecution)
            {
                this.ShouldDelayBeforeExecution = false;
            }
            else
            {
                if (blob.AttackDamage - DamageReductionValue < initialBlobDamage)
                {
                    this.IsTriggered = false;
                }
                else
                {
                    blob.AttackDamage -= DamageReductionValue;
                }
            }
        }
    }
}
