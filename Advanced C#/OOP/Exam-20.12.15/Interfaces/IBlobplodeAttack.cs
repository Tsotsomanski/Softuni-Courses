using Exam_20_12._15.Models.Attack;

namespace Exam_20_12._15.Interfaces
{
    public interface IBlobplodeAttack : IAttack, IProduceAttack
    {
        int LoseHealth();
    }
}
