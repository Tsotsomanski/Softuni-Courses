using System;
using OOPExamPrepare_Empires.Interfaces;

namespace OOPExamPrepare_Empires.Models.Buildings
{
    public interface IBuildingFactory
    {
        IBuilding CreateBuilding(string buildingType, IResourceFactory resourceFactory, IUnitFactory unitFactory);
    }
}
