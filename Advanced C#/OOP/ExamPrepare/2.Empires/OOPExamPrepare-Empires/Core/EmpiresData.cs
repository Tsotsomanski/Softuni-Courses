using System;
using System.Collections.Generic;
using OOPExamPrepare_Empires.Interfaces;
using OOPExamPrepare_Empires.Models.Resourse;

namespace OOPExamPrepare_Empires.Core
{
    class EmpiresData : IEmpiresData
    {
        private readonly ICollection<IBuilding> buildings 
            = new List<IBuilding>();

        public EmpiresData()
        {
            this.Resources = new Dictionary<ResourseType, int>();
            this.Units = new Dictionary<string, int>();
            this.InitResources();
        }

        private void InitResources()
        {
            var resourceTypes = Enum.GetValues(typeof (ResourseType));
            foreach (ResourseType resourceType in resourceTypes)
            {
                this.Resources.Add(resourceType, 0);
            }
        }


        public IEnumerable<IBuilding> Buildings => this.buildings;

        public void AddBuilding(IBuilding building)
        {
            if (building == null)
            {
                throw new ArgumentNullException(nameof(building));
            }
            this.buildings.Add(building);
        }

        public void AddUnit(IUnit unit)
        {
            if (unit == null)
            {
                throw new ArgumentNullException(nameof(unit));
            }
            var unitType = unit.GetType().Name;

            if (!this.Units.ContainsKey(unitType))
            {
                this.Units.Add(unitType, 0);
            }

            this.Units[unitType]++;
        }

        public IDictionary<string, int> Units { get; } 

        public IDictionary<ResourseType, int> Resources { get; }
    }
}
