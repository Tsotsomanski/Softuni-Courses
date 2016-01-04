using System;
using System.Linq;
using System.Reflection;
using Exam_20_12._15.Interfaces;

namespace Exam_20_12._15.Core.Factories
{
    class AttackFactory : IAttackFactory
    {
        public IAttack CreateAttack(string attackName)
        {
            var type = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == attackName);

            if (type == null)
            {
                throw new ArgumentException("Unknown type");
            }
            var attack = Activator.CreateInstance(type);

            return attack as IAttack;
        }
    }
}
