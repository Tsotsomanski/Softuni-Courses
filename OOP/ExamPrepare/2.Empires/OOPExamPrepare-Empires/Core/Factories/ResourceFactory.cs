using System;
using System.Diagnostics;
using OOPExamPrepare_Empires.Interfaces;
using OOPExamPrepare_Empires.Models.Resourse;

namespace OOPExamPrepare_Empires.Core.Factories
{
    class ResourceFactory : IResourceFactory
    {
        public IResource CreateResource(ResourseType resourceType, int quantity)
        {
            var resource = new Resourse(resourceType, quantity);
            return resource;
        }
    }
}
