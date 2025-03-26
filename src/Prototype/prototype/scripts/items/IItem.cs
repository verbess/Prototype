namespace Yinyang.Items;

/// <summary>
/// Defines methods for an item.
/// </summary>
public interface IItem : IUnit
{
    /// <summary>
    /// Gets the name of the item.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets the description of the item.
    /// </summary>
    public string Description { get; }

    /// <summary>
    /// Gets the item types of the item.
    /// </summary>
    public ItemTypes Types { get; }
}
