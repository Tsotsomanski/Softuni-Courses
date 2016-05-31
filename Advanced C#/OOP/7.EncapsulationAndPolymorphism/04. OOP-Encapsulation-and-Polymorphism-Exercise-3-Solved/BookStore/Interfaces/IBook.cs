namespace BookStore.Interfaces
{
    interface IBook
    {
        string Title { get; }

        string Author { get; }

        decimal Price { get; }
    }
}
