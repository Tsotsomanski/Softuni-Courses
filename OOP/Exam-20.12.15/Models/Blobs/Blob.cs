using System;
using Exam_20_12._15.Enums;
using Exam_20_12._15.Interfaces;

namespace Exam_20_12._15.Models
{
    public abstract class Blob : IBlob
    {
        private string name;
        private int blobHealth;
        private int blobAttackDamage;
        private BlobType blobType;

        public Blob(string name, int blobHealth, int blobAttackDamage)
        {
            this.name = name;
            this.blobHealth = blobHealth;
            this.blobAttackDamage = blobAttackDamage;
        }


        public string Name
        {
            get { return this.name; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "Name cannot be empry.");
                }
                this.name = value;
            }
        }

        public int BlobHealth
        {
            get{ return this.blobHealth; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Blobs health cannot be negative.");
                }
                this.blobHealth = value;
            }
        }

        public int BlobAttackDamage
        {
            get { return this.blobAttackDamage; }
            set {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Attack damage cannot be negative number.");
                }
            }
        }

        private void InitHealth(int initialHealth)
        {
            if (initialHealth <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(initialHealth), "A bloob's initial health should be positive.");
            }

            this.blobHealth = initialHealth;
        }
    }
}
