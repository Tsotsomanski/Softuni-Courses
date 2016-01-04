using OOPExamPrepare_Empires.Interfaces;
using OOPExamPrepare_Empires.Models.Resourse;

namespace OOPExamPrepare_Empires.Models.Buildings
{
    public class Archery : Building
    {
        private const string ArcheryUnitType = "Archer";
        private const int ArcheryUnitCycleLength = 3;

        private const ResourseType ArcheryResourseType = ResourseType.Gold;
        private const int ArcheryResourceCycleLength = 2;
        private const int ArcheryResourceQuantity = 5;

        public Archery( IUnitFactory unitFactory, IResourceFactory resourseFactory) 
            : base(ArcheryUnitType,
                   ArcheryUnitCycleLength,
                   ArcheryResourseType,
                   ArcheryResourceCycleLength,
                   unitFactory,
                   ArcheryResourceQuantity,
                   resourseFactory
                   )
        {
        }
    }
}
