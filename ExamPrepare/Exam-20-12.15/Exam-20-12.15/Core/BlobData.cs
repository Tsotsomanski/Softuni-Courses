using System.Collections.Generic;
using Exam_20_12._15.Interfaces;

namespace Exam_20_12._15.Core
{
    class BlobData : IBlobData
    {
        private readonly ICollection<IBlob> blobs;

        public BlobData(ICollection<IBlob> blobs)
        {
            this.blobs = blobs;
        }

        public IEnumerable<IBlob> Blobs
        {
            get { return this.blobs; }
        }

        public void AddBlob(IBlob blob)
        {
            this.blobs.Add(blob);
        }
    }
}
