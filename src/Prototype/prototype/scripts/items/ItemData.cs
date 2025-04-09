using Godot;
using Snake;

namespace Yinyang.Items;

/// <summary>
/// Represents immutable static data for an item within the game.
/// </summary>
[GlobalClass]
public sealed partial class ItemData : Resource, IKeyed
{
    /// <summary>
    /// Initializes a new instance of this class with the specified properties.
    /// </summary>
    /// <param name="key">The unique identifier of the item.</param>
    /// <param name="name">The display name of the item.</param>
    /// <param name="description">The brief description of the item.</param>
    /// <param name="types">The type(s) of the item.</param>
    /// <param name="price">The price of the item within the game's currency.</param>
    public ItemData(string key, string name, string description, ItemTypes types, int price)
    {
        ArgumentNullException.ThrowIfNull(key);
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(description);

        Key = key;
        Name = name;
        Description = description;
        Types = types;
        Price = price;
    }

    /// <inheritdoc />
    public string Key { get; }

    /// <summary>
    /// Gets the display name of the item.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets the brief description of the item.
    /// </summary>
    public string Description { get; }

    /// <summary>
    /// Gets the type(s) of the item.
    /// </summary>
    public ItemTypes Types { get; }

    /// <summary>
    /// Gets the price of the item within the game's currency.
    /// </summary>
    public int Price { get; }
}
