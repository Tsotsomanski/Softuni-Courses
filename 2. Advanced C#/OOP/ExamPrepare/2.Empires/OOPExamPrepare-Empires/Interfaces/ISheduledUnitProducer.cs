using System;

namespace OOPExamPrepare_Empires.Interfaces
{
    public interface ISheduledUnitProducer : IUnitProducer
    {
        bool CanProduceUnit { get; }
    }
}
