namespace PavlovRcon.Commands;

/// <summary>
/// ItemList command lists all items in the game.
/// </summary>
public class ItemList : RconCommand<string>
{
    /// <summary>
    /// Creates a new ItemList command.
    /// </summary>
    public ItemList() : base("ItemList")
    {
    }
}