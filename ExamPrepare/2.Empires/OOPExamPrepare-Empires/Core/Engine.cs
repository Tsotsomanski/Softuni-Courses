using System;
using System.Linq;
using System.Text;
using OOPExamPrepare_Empires.Interfaces;
using OOPExamPrepare_Empires.Models.Buildings;
using OOPExamPrepare_Empires.Models.Resourse;

namespace OOPExamPrepare_Empires.Core
{
    public class Engine : IRunnable
    {
        private IBuildingFactory buildingFactory;
        private IResourceFactory resourceFactory;
        private IUnitFactory unitFactory;
        private IEmpiresData empiresData;
        private IInputReader reader;
        private IOutputWriter writer;

        public Engine(IBuildingFactory buildingFactory, IResourceFactory resourceFactory, IUnitFactory unitFactory, IEmpiresData empiresData, IInputReader reader, IOutputWriter writer)
        {
            this.buildingFactory = buildingFactory;
            this.resourceFactory = resourceFactory;
            this.unitFactory = unitFactory;
            this.empiresData = empiresData;
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            while (true)
            {
                string[] input = this.reader.ReadLine().Split();

                this.ExecuteCommand(input);
                this.UpdateBuildings();
            }
        }

        private void UpdateBuildings()
        {
            foreach (IBuilding building in this.empiresData.Buildings)
            {
                building.Update();
                if (building.CanProduceResource)
                {
                    var resource = building.ProduceResource();
                    this.empiresData.Resources[resource.ResourseType] += resource.Quantity;
                }
                if (building.CanProduceUnit)
                {
                    var unit = building.ProduceUnit();
                    this.empiresData.AddUnit(unit);
                }
            }
        }

        private void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "empire-status":
                    this.ExecuteStatusCommand();
                    break;
                case "armistice":
                    Environment.Exit(0);
                    break;
                case "skip":
                    break;
                case "build":
                    this.ExecuteBuildCommand(inputParams[1]);
                    break;
                default:
                    throw new ArgumentException("Unknown command !");
            }
        }

        private void ExecuteBuildCommand(string buildingType)
        {
            IBuilding building = this.buildingFactory.CreateBuilding(buildingType, this.resourceFactory,
                this.unitFactory);
            this.empiresData.AddBuilding(building);
        }

        private void ExecuteStatusCommand()
        {
            StringBuilder output = new StringBuilder();

            this.AppendTreasuryInfo(output);

            this.AppendBuildingInfo(output);

            this.AppendUnitInfo(output);

            this.writer.Print(output.ToString().Trim());
        }

        private void AppendUnitInfo(StringBuilder output)
        {
            output.AppendLine("Units:");
            if (this.empiresData.Buildings.Any())
            {
                foreach (var unit in this.empiresData.Units)
                {
                    output.Append($"--{unit.Key}: {unit.Value}{Environment.NewLine}");
                }
            }
            else
            {
                output.AppendLine("N/A");
            }
        }

        private void AppendBuildingInfo(StringBuilder output)
        {
            output.AppendLine("Buildings:");
            if (this.empiresData.Buildings.Any())
            {
                foreach (IBuilding building in this.empiresData.Buildings)
                {
                    output.AppendLine(building.ToString());
                }
            }
            else
            {
                output.AppendLine("N/A");
            }
        }

        private void AppendTreasuryInfo(StringBuilder output)
        {
            output.AppendLine("Treasury:");
            foreach (var resource in this.empiresData.Resources)
            {
                output.AppendFormat($"--{resource.Key}: {resource.Value}{Environment.NewLine}");
            }
        }
    }
}
