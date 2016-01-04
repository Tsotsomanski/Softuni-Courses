using OOPExamPrepare_Empires.Models.Resourse;

namespace OOPExamPrepare_Empires.Interfaces
{
    public interface IResourceFactory
    {
        IResource CreateResource(ResourseType resourceType, int quantity);
    }
}
