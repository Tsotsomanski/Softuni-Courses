using System;
using OOPExamPrepare_Empires.Interfaces;
using OOPExamPrepare_Empires.Models.Units;

namespace OOPExamPrepare_Empires.Core.Factories
{
    class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            switch (unitType)
            {
                case "Archer":
                    return new Archer();
                case "Swordsman":
                    return new Swordsman();
                default:
                    throw new ArgumentException("Unknown unit type !");
            }
        }
    }
}
