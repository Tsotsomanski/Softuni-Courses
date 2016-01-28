using Battleships.Contract;

namespace Battleships.Ships
{
    public abstract class BattleShip : Ship, IAttack
    {
        public BattleShip(string name, double lengthInMeters, double volume) 
            : base(name, lengthInMeters, volume)
        {
        }

        public bool IsBatteleShip { get; set; }

        public string Attack(Ship targetShip)
        {
            this.DestroyShip(targetShip);
            return "Target is destroyed. We bombed them from the sky!";
        }

        private void DestroyShip(Ship targetShip)
        {
            
        }
    }
}
