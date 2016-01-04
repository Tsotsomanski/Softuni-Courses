using System;
using OOPExamPrepare_Empires.Models.Resourse;

namespace OOPExamPrepare_Empires.Interfaces
{
    public interface IResource
    {
        ResourseType ResourseType { get; }

        int Quantity { get; }
    }
}
