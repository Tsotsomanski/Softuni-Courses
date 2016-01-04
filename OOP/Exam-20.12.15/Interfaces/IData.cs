using System.Collections;
using System.Collections.Generic;

namespace Exam_20_12._15.Interfaces
{
    public interface IData
    {
        ICollection<IBlob> AggresiveBlobs { get; }
        ICollection<IBlob> InflatedBlobs { get; }
    }   
}
