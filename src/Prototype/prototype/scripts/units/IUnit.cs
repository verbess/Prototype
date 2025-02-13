namespace YinYang;

/// <summary>
/// Defines methods for units.
/// </summary>
public interface IUnit : IYinYang
{
    /// <summary>
    /// Gets or inits the id of the unit.
    /// </summary>
    public int Id { get; init; }
}
