using System;
using System.Collections;
using System.Collections.Generic;
using OOPExamPrepare_Empires.Models.Resourse;

namespace OOPExamPrepare_Empires.Interfaces
{
    public interface IEmpiresData
    {
        IEnumerable<IBuilding> Buildings { get; }

        void AddBuilding(IBuilding building);

        IDictionary<string, int> Units { get; }

        void AddUnit(IUnit unit);

        IDictionary<ResourseType, int> Resources { get; }
    }
}
