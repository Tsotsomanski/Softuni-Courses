using System;
using System.Linq;
using System.Reflection;
using Exam_20_12._15.Interfaces;

namespace Exam_20_12._15.Core.Factories
{
    class BehaviorFactory : IBehaviorFactory
    {
        private const string ExceptionMessage = "Unknown behaviors type";

        public IBehavior CreateBehavior(string behaviorName)
        {
            var type = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == behaviorName);
            if (type == null)
            {
                throw new ArgumentException(ExceptionMessage);
            }

            var behavior = Activator.CreateInstance(type);

            return behavior as IBehavior;
        }
    }
}