using System;
using OOPExamPrepare_Empires.Interfaces;
using OOPExamPrepare_Empires.Models.Resourse;

namespace OOPExamPrepare_Empires.Models.Buildings
{
    class Barrack : Building
    {

        private const string BarrackUnitType = "Swordsman";
        private const int BarrackUnitCycleLength = 4;

        private const ResourseType BarrackResourseType = ResourseType.Steel;
        private const int BarrackResourceCycleLength = 3;
        private const int BarracksResourceQuantity = 10;

        public Barrack(IUnitFactory unitFactory, IResourceFactory resourseFactory) 
            : base(BarrackUnitType, 
                   BarrackUnitCycleLength, 
                   BarrackResourseType,
                   BarrackResourceCycleLength,
                   unitFactory,
                   BarracksResourceQuantity,
                   resourseFactory)
        {
        }
    }
}
