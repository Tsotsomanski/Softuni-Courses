namespace Battleships.Contract
{
    public interface IShip
    {
        string Name { get; set; }

        double LengthInMeters { get; set; }

        double Volume { get; set; }

        bool IsBattleship { get; set; }

        bool IsDestroyed { get; set; }
    }
}
