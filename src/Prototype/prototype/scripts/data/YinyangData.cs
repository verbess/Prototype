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
    /// <param name="qi">The yinyang value of the object.</param>
    /// <param name="yinji">The yinyang value of the object's yinji threshold.</param>
    /// <param name="yinchi">The yinyang value of the object's yinchi threshold.</param>
    /// <param name="yangchi">The yinyang value of the object's yangchi threshold.</param>
    /// <param name="yangji">The yinyang value of the object's yangji threshold.</param>
    /// <param name="originalPolarity">The original polarity of the object.</param>
    public YinyangData(string key, int qi, int yinji, int yinchi, int yangchi, int yangji, Polarity originalPolarity)
    {
        ArgumentNullException.ThrowIfNull(key);
        if (!IYinyang.AreThresholdsValid(yinji, yinchi, yangchi, yangji))
        {
            throw new ArgumentException(Messages.Argument_ThresholdsOutOfOrder);
        }

        if (!IYinyang.IsQiValid(qi, yinji, yangji))
        {
            throw new ArgumentException(Messages.Argument_QiOutOfRange);
        }

        Key = key;
        Qi = qi;
        Yinji = yinji;
        Yinchi = yinchi;
        Yangchi = yangchi;
        Yangji = yangji;
        OriginalPolarity = originalPolarity;
    }

    /// <summary>
    /// Gets the unique identifier of the data.
    /// </summary>
    public string Key { get; }

    /// <summary>
    /// Gets the yinyang value of the object.
    /// </summary>
    public int Qi { get; }

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
    /// Gets the original polarity of the object.
    /// </summary>
    public Polarity OriginalPolarity { get; }
}
