using Snake;

namespace Yinyang.Data;

/// <summary>
/// Represents immutable static data for the yinyang system within the game.
/// </summary>
public sealed record YinyangData : IKeyed
{
    /// <summary>
    ///
    /// </summary>
    /// <param name="key"></param>
    /// <param name="qi"></param>
    /// <param name="yinchi"></param>
    /// <param name="yangchi"></param>
    /// <param name="yinji"></param>
    /// <param name="yangji"></param>
    /// <param name="originalPolarity"></param>
    public YinyangData(string key, int qi, int yinchi, int yangchi, int yinji, int yangji, Polarity originalPolarity)
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
        Yinchi = yinchi;
        Yangchi = yangchi;
        Yinji = yinji;
        Yangji = yangji;
        OriginalPolarity = originalPolarity;
    }

    /// <summary>
    ///
    /// </summary>
    public string Key { get; }

    /// <summary>
    ///
    /// </summary>
    public int Qi { get; }

    /// <summary>
    ///
    /// </summary>
    public int Yinchi { get; }

    /// <summary>
    ///
    /// </summary>
    public int Yangchi { get; }

    /// <summary>
    ///
    /// </summary>
    public int Yinji { get; }

    /// <summary>
    ///
    /// </summary>
    public int Yangji { get; }

    /// <summary>
    ///
    /// </summary>
    public Polarity OriginalPolarity { get; }
}
