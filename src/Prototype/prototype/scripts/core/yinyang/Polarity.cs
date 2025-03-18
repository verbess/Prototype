namespace Yinyang;

/// <summary>
/// Specifies the polarity of yinyang elements.
/// </summary>
public enum Polarity
{
    /// <summary>
    /// The yin polarity, when <see cref="IYinyang.Qi" /> is negative.
    /// </summary>
    Yin = -1,

    /// <summary>
    /// The taiji polarity, when <see cref="IYinyang.Qi" /> is in the neutral balance.
    /// </summary>
    Taiji = 0,

    /// <summary>
    /// The yang polarity, when <see cref="IYinyang.Qi" /> is positive.
    /// </summary>
    Yang = 1,
}
