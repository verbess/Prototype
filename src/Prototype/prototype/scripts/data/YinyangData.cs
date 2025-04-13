using Snake;

namespace Yinyang.Data;

/// <summary>
/// Represents immutable static data for the yinyang system within the game.
/// </summary>
public sealed record YinyangData : IKeyed
{
    /// <summary>
    /// Initializes a new instance of this class with the specified properties.
    /// </summary>
    /// <param name="key">The unique identifier of the data.</param>
    /// <param name="yinji">The yinyang value of the object's yinji threshold.</param>
    /// <param name="yinchi">The yinyang value of the object's yinchi threshold.</param>
    /// <param name="yangchi">The yinyang value of the object's yangchi threshold.</param>
    /// <param name="yangji">The yinyang value of the object's yangji threshold.</param>
    /// <param name="initialPolarity">The initial polarity of the object.</param>
    public YinyangData(string key, int yinji, int yinchi, int yangchi, int yangji, Polarity initialPolarity)
    {
        ArgumentNullException.ThrowIfNull(key);
        if (!IYinyang.AreThresholdsValid(yinji, yinchi, yangchi, yangji))
        {
            throw new ArgumentException(Messages.Argument_ThresholdsOutOfOrder);
        }

        Key = key;
        Yinji = yinji;
        Yinchi = yinchi;
        Yangchi = yangchi;
        Yangji = yangji;
        InitialPolarity = initialPolarity;
    }

    /// <summary>
    /// Gets the unique identifier of the data.
    /// </summary>
    public string Key { get; }

    /// <summary>
    /// Gets the yinyang value of the object's yinchi threshold.
    /// </summary>
    public int Yinchi { get; }

    /// <summary>
    /// Gets the yinyang value of the object's yangchi threshold.
    /// </summary>
    public int Yangchi { get; }

    /// <summary>
    /// Gets the yinyang value of the object's yinji threshold.
    /// </summary>
    public int Yinji { get; }

    /// <summary>
    /// Gets the yinyang value of the object's yangji threshold.
    /// </summary>
    public int Yangji { get; }

    /// <summary>
    /// Gets the initial polarity of the object.
    /// </summary>
    public Polarity InitialPolarity { get; }
}
