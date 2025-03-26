namespace Yinyang;

/// <summary>
/// Defines methods for all interactive objects within the game.
/// </summary>
public interface IUnit : IYinyang
{
    /// <summary>
    /// Gets the id of the unit.
    /// </summary>
    public int Id { get; }
}
