using Godot;
using Snake;

namespace Yinyang.Items;

/// <summary>
///
/// </summary>
/// <remarks>
///
/// </remarks>
[GlobalClass]
public sealed partial class ItemData : Resource, IKeyed
{
    /// <summary>
    ///
    /// </summary>
    /// <param name="key"></param>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <param name="types"></param>
    /// <param name="price"></param>
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

    /// <summary>
    ///
    /// </summary>
    public string Key { get; }

    /// <summary>
    ///
    /// </summary>
    public string Name { get; }

    /// <summary>
    ///
    /// </summary>
    public string Description { get; }

    /// <summary>
    ///
    /// </summary>
    public ItemTypes Types { get; }

    /// <summary>
    ///
    /// </summary>
    public int Price { get; }
}
