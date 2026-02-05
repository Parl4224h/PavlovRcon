namespace PavlovRcon.Commands;

/// <summary>
/// SetBalanceTableUrl command, sets the url of the balance table to use
/// </summary>
/// <remarks>
/// Note that this command requires the map to change to take effect.
/// The url is not the full url, rather a partial component for https://github.com/vankruptgames/BalancingTable/blob/Beta_5.1/BalancingTable.csv the component would be vankruptgames/BalancingTable/blob/Beta_5.1 and that branch must have a top level file with the name BalancingTable.csv
/// </remarks>
public class SetBalanceTableUrl : RconCommand<string>
{
    /// <summary>
    /// Creates a new SetBalanceTableUrl command.
    /// </summary>
    /// <param name="url">The url of the new balance table to use.</param>
    public SetBalanceTableUrl(string url) : base("SetBalanceTableURL") => Add(url);
}