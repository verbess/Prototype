namespace Yinyang;

/// <summary>
/// Defines methods for units.
/// </summary>
public interface IUnit : IYinyang
{
    /// <summary>
    /// Gets or inits the id of the unit.
    /// </summary>
    public int Id { get; init; }
}
