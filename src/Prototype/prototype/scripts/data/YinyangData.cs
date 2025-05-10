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
    /// <param name="yinji">The <see cref="Qi"/> of the object's yinji threshold.</param>
    /// <param name="yinchi">The <see cref="Qi"/> of the object's yinchi threshold.</param>
    /// <param name="yangchi">The <see cref="Qi"/> of the object's yangchi threshold.</param>
    /// <param name="yangji">The <see cref="Qi"/> of the object's yangji threshold.</param>
    /// <param name="qi">The yinyang value of the object.</param>
    /// <param name="originalPolarity">The original polarity of the object.</param>

    public YinyangData(string key, int yinji, int yinchi, int yangchi, int yangji, int qi, Polarity originalPolarity)
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
        Yinji = yinji;
        Yinchi = yinchi;
        Yangchi = yangchi;
        Yangji = yangji;
        Qi = qi;
        OriginalPolarity = originalPolarity;
    }

    /// <inheritdoc cref="IKeyed.Key"/>
    public string Key { get; }

    /// <inheritdoc cref="IYinyang.Qi"/>
    public int Qi { get; }

    /// <inheritdoc cref="IYinyang.Yinchi"/>
    public int Yinchi { get; }

    /// <inheritdoc cref="IYinyang.Yangchi"/>
    public int Yangchi { get; }

    /// <inheritdoc cref="IYinyang.Yinji"/>
    public int Yinji { get; }

    /// <inheritdoc cref="IYinyang.Yangji"/>
    public int Yangji { get; }

    /// <inheritdoc cref="IYinyang.OriginalPolarity"/>
    public Polarity OriginalPolarity { get; }
}
