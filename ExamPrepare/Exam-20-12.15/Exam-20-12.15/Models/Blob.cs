using System;
using Exam_20_12._15.Interfaces;

namespace Exam_20_12._15.Models
{
    public abstract class Blob : IBlob
    {
        private readonly int halfHealth;
        private int health;

        public Blob(string name, int health, int attackDamage, IBehavior behavior, IAttack attack)
        {
            this.Name = name;
            this.Health = health;
            this.AttackDamage = attackDamage;
            this.Behavior = behavior;
            this.Attack = attack;
        }


        public string Name { get; }

        public int Health
        {
            get{ return this.health; }
            set
            {
                if (this.Health < 0)
                {
                    this.health = 0;
                    if (this.Behavior.AlreadyTriggered)
                    {
                        string message = $"Blob {this.Name} was killed";
                    }
                }
                if (this.health <= this.halfHealth && !this.Behavior.AlreadyTriggered)
                {
                    this.Behavior.Trigger(this);
                    string message = $"Blob {this.Name} toggled {this.Behavior.GetType().Name}Behavior";
                }
                this.Health = value;
            }
        }

        public int AttackDamage
        {
            get { return this.AttackDamage; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Attack damage cannot be negative number.");
                }
            }
        }

        public bool IsAlive
        {
            get { return this.Health > 0; }
        }

        public IBehavior Behavior { get; }

        public IAttack Attack { get; }

        public void PerformAttack(IBlob target)
        {
            this.Attack.ExecuteEffectsOnAttacker(this);
            this.Attack.ExecuteAttack(target, this.AttackDamage);
        }
        //TODO: Update method !
    }
}
