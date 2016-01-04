using System;
using OOPExamPrepare_Empires.Core;
using OOPExamPrepare_Empires.Core.Factories;
using OOPExamPrepare_Empires.IO;

namespace OOPExamPrepare_Empires
{
    class MainProgram
    {
        static void Main()
        {
            var buildingFactory = new BuildingFactory();
            var unitFactory = new UnitFactory();
            var resourceFactory = new ResourceFactory();
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            var data = new EmpiresData();

            var engine = new Engine(buildingFactory, resourceFactory, unitFactory, data, reader, writer);
            engine.Run();
        }
    }
}
