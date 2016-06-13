using System;
using OOPExamPrepare_Empires.Interfaces;

namespace OOPExamPrepare_Empires.Models.Resourse
{
    public class Resourse : IResource
    {
        public Resourse(ResourseType resourseType, int quantity)
        {
            this.ResourseType = resourseType;
            this.Quantity = quantity;
        }

        public ResourseType ResourseType { get; }
        public int Quantity { get; }
    }
}
