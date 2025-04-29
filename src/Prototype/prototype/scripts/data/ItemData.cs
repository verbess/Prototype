using Snake;
using Yinyang.Items;

namespace Yinyang.Data;

/// <summary>
/// Represents immutable static data for an item within the game.
/// </summary>
public record ItemData : IKeyed
{
    /// <summary>
    /// Initializes a new instance of this class with the specified properties.
    /// </summary>
    /// <param name="key">The unique identifier of the item.</param>
    /// <param name="name">The name of the item.</param>
    /// <param name="description">The description of the item.</param>
    /// <param name="types">The item types of the item.</param>
    /// <param name="price">The price of the item.</param>
    /// <param name="qi">The yinyang value of the item.</param>
    /// <param name="yinji">The yinyang value of the item's yinji threshold.</param>
    /// <param name="yinchi">The yinyang value of the item's yinchi threshold.</param>
    /// <param name="yangchi">The yinyang value of the item's yangchi threshold.</param>
    /// <param name="yangji">The yinyang value of the item's yangji threshold.</param>
    /// <param name="originalPolarity">The original polarity of the item.</param>
    public ItemData(
        string key,
        string name,
        string description,
        ItemTypes types,
        int price,
        int qi,
        int yinji,
        int yinchi,
        int yangchi,
        int yangji,
        Polarity originalPolarity
    )
    {
        ArgumentNullException.ThrowIfNull(key);
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(description);
        if (!IYinyang.AreThresholdsValid(yinji, yinchi, yangchi, yangji))
        {
            throw new ArgumentException(Messages.Argument_ThresholdsOutOfOrder);
        }

        if (!IYinyang.IsQiValid(qi, yinji, yangji))
        {
            throw new ArgumentException(Messages.Argument_QiOutOfRange);
        }

        Key = key;
        Name = name;
        Description = description;
        Types = types;
        Price = price;
        Qi = qi;
        Yinchi = yinchi;
        Yangchi = yangchi;
        Yinji = yinji;
        Yangji = yangji;
        OriginalPolarity = originalPolarity;
    }

    /// <summary>
    /// Gets the unique identifier of the item.
    /// </summary>
    public string Key { get; }

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

    /// <summary>
    /// Gets the price of the item.
    /// </summary>
    public int Price { get; }

    /// <summary>
    /// Gets the yinyang value of the item.
    /// </summary>
    public int Qi { get; }

    /// <summary>
    /// Gets the yinyang value of the item's yinchi threshold.
    /// </summary>
    public int Yinchi { get; }

    /// <summary>
    /// Gets the yinyang value of the item's yangchi threshold.
    /// </summary>
    public int Yangchi { get; }

    /// <summary>
    /// Gets the yinyang value of the item's yinji threshold.
    /// </summary>
    public int Yinji { get; }

    /// <summary>
    /// Gets the yinyang value of the item's yangji threshold.
    /// </summary>
    public int Yangji { get; }

    /// <summary>
    /// Gets the original polarity of the item.
    /// </summary>
    public Polarity OriginalPolarity { get; }
}
