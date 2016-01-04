using System;
using System.Collections;
using System.Collections.Generic;
using Exam_20_12._15.Interfaces;

namespace Exam_20_12._15.Core
{
    class Data : IData
    {
        
        private readonly ICollection<IBlob> aggresiveBlobs = new List<IBlob>();
        private readonly ICollection<IBlob> inflatedBlobs = new List<IBlob>();

        public void AddAggresiveBlobs(IBlob aggressiveBlob)
        {
            if (aggressiveBlob == null)
            {
                throw new ArgumentNullException(nameof(aggressiveBlob));
            }
            this.aggresiveBlobs.Add(aggressiveBlob);
        }

        public void AddInflatedBlobs(IBlob inflatedBlob)
        {
            if (inflatedBlob == null)
            {
                throw new ArgumentNullException(nameof(inflatedBlob));
            }
            this.inflatedBlobs.Add(inflatedBlob);
        }


        public ICollection<IBlob> AggresiveBlobs { get; }
        public ICollection<IBlob> InflatedBlobs { get; }
    }
}
