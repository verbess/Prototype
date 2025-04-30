namespace Yinyang;

/// <summary>
/// Represents the polarities of yinyang elements.
/// </summary>
public enum Polarity
{
    /// <summary>
    /// The yin polarity, when the object's <see cref="IYinyang.Qi"/> is negative.
    /// </summary>
    Yin = -1,

    /// <summary>
    /// The taiji polarity, when the object's <see cref="IYinyang.Qi"/> is neutral.
    /// </summary>
    Taiji = 0,

    /// <summary>
    /// The yang polarity, when the object's <see cref="IYinyang.Qi"/> is positive.
    /// </summary>
    Yang = 1,
}
