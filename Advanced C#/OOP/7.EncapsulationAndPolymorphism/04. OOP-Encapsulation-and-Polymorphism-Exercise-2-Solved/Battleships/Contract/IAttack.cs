using Battleships.Ships;

namespace Battleships.Contract
{
    interface IAttack
    {
        string Attack(Ship targetShip);
    }
}
