using System;
using OOPExamPrepare_Empires.Interfaces;
using OOPExamPrepare_Empires.Models.Buildings;

namespace OOPExamPrepare_Empires.Core.Factories
{
    class BuildingFactory : IBuildingFactory
    {
        public IBuilding CreateBuilding(string buildingType, IResourceFactory resourceFactory, IUnitFactory unitFactory)
        {
            switch (buildingType)
            {
                case "archery":
                    return new Archery(unitFactory, resourceFactory);
                case "barracks":
                    return new Barrack(unitFactory, resourceFactory);
                default:
                    throw new ArgumentException("Unknown building type !");
            }
        }
    }
}
