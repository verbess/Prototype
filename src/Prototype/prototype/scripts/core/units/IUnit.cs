namespace Yinyang;

/// <summary>
/// Defines methods for all interactive objects within the game.
/// </summary>
public interface IUnit : IYinyang
{
    /// <summary>
    /// Gets the unique identifier of the unit.
    /// </summary>
    public string Key { get; }
}
