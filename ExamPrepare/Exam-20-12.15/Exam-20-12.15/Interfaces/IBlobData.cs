using System.Collections.Generic;

namespace Exam_20_12._15.Interfaces
{
    interface IBlobData
    {
        IEnumerable<IBlob> Blobs { get; }

        void AddBlob(IBlob blob);
    }
}
