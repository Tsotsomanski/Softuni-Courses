using Exam_20_12._15.Enums;
using Exam_20_12._15.Interfaces;

namespace Exam_20_12._15.Models.Attack
{
    public class Blobplode : Attack
    {
        public override void ExecuteAttack(IBlob target, int damage)
        {
            damage = damage*2;
            target.Respond(damage);
        }

        public override void ExecuteEffectsOnAttacker(IBlob attacker)
        {
            attacker.Health - +attacker.Health/2;
        }
    }
}
