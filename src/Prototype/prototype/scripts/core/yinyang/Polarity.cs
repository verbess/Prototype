namespace Yinyang;

/// <summary>
/// Specifies the polarity of yinyang elements.
/// </summary>
public enum Polarity
{
    /// <summary>
    /// The yin polarity, when the object's yinyang value is negative.
    /// </summary>
    Yin = -1,

    /// <summary>
    /// The taiji polarity, when the object's yinyang value is neutral.
    /// </summary>
    Taiji = 0,

    /// <summary>
    /// The yang polarity, when the object's yinyang value is positive.
    /// </summary>
    Yang = 1,
}
