using System;
using OOPExamPrepare_Empires.Interfaces;
using OOPExamPrepare_Empires.Models.Resourse;

namespace OOPExamPrepare_Empires.Models.Buildings
{
    public abstract class Building : IBuilding
    {
        private const int ProductionDelay = 1;
        private int cyclesCount = 0;

        private string unitType;
        private int unitCycleLength;
        private ResourseType resourseType ;
        private int resourceCycleLength;
        private int resourceQuantity;
        private IUnitFactory unitFactory;
        private IResourceFactory resourseFactory;

        protected Building(
            string unitType, 
            int unitCycleLength, 
            ResourseType resourseType, 
            int resourceCycleLength,
            IUnitFactory unitFactory,
            int resourceQuantity,
            IResourceFactory resourseFactory)
        {
            this.unitType = unitType;
            this.unitCycleLength = unitCycleLength;
            this.resourseType = resourseType;
            this.resourceCycleLength = resourceCycleLength;
            this.resourceQuantity = resourceQuantity;
            this.unitFactory = unitFactory;
            this.resourseFactory = resourseFactory;
        }

        public bool CanProduceResource
        {
            get
            {

                bool canProduceResource = this.cyclesCount > ProductionDelay 
                    && (this.cyclesCount - ProductionDelay)%this.resourceCycleLength == 0;
                return canProduceResource; 
            }
        }

        public bool CanProduceUnit
        {
            get
            {

                bool canProduceUnit = this.cyclesCount > ProductionDelay
                    && (this.cyclesCount - ProductionDelay) % this.unitCycleLength == 0;
                return canProduceUnit;
            }
        }

        public IResource ProduceResource()
        {
            var resource = this.resourseFactory.CreateResource(this.resourseType, this.resourceQuantity);
            return resource;
        }
        public IUnit ProduceUnit()
        {
            var unit = this.unitFactory.CreateUnit(this.unitType);
            return unit;
        }

        
        public void Update()
        {
            this.cyclesCount++;
        }

        public override string ToString()
        {
            int turnsUntilUnit = this.unitCycleLength - (this.cyclesCount -  ProductionDelay) % this.unitCycleLength;
            int turnsUntilResource = this.resourceCycleLength - (this.cyclesCount - ProductionDelay) % this.resourceCycleLength; ;

            var result = string.Format(
                "--{0}: {1} turns ({2} turns until {3}, {4} turns until {5})",
                this.GetType().Name,
                this.cyclesCount - ProductionDelay,
                turnsUntilUnit,
                this.unitType,
                turnsUntilResource,
                this.resourseType);

            return result;
        }
    }
}
