namespace Yinyang;

/// <summary>
/// Defines methods for all interactive units within the game.
/// </summary>
public interface IUnit : IYinyang
{
    /// <summary>
    /// Gets or initializes the id of the unit.
    /// </summary>
    public int Id { get; init; }
}
