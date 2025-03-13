namespace Yinyang;

/// <summary>
/// Defines methods for objects with yinyang elements.
/// </summary>
public interface IYinyang
{
    /// <summary>
    /// Defines the default yinyang value of taiji polarity, which is "0".
    /// </summary>
    public const int DefaultTaijiQi = 0;

    /// <summary>
    /// Gets or sets the current yinyang value of the object.
    /// </summary>
    /// <remarks>
    /// 炁，是中国古代的哲学概念，指产生和构成天地万物的原始能量，成为天地一切事物组成的基本元素。
    /// </remarks>
    public int Qi { get; set; }

    /// <summary>
    /// Gets the yin threshold value of the object.
    /// </summary>
    /// <remarks>
    /// 阴持，“持”字源自《黄帝内经》“持满御神”概念，指保持适度状态，对应现代医学的“稳态维持”。
    /// </remarks>
    public int Yinchi { get; }

    /// <summary>
    /// Gets the yang threshold value of the object.
    /// </summary>
    /// <remarks>
    /// 阳持，“持”字源自《黄帝内经》“持满御神”概念，指保持适度状态，对应现代医学的“稳态维持”。
    /// </remarks>
    public int Yangchi { get; }

    /// <summary>
    /// Gets the taiji value of the object.
    /// </summary>
    /// <remarks>
    /// 太极，一般是指宇宙最原始的秩序状态，出现于阴阳未分的混沌时期（无极）之后，而后形成万物（宇宙）的本源——混天太极。
    /// </remarks>
    public int Taiji { get; }

    /// <summary>
    /// Gets the yin extremum value of the object.
    /// </summary>
    /// <remarks>
    /// 阴极，“极”字源自《素问》“重阴必阳”概念，指阴气达到物极必反的临界状态。
    /// </remarks>
    public int Yinji { get; }

    /// <summary>
    /// Gets the yang extremum value of the object.
    /// </summary>
    /// <remarks>
    /// 阳极，“极”字源自《素问》“重阳必阴”概念，指阳气达到物极必反的临界状态。
    /// </remarks>
    public int Yangji { get; }

    /// <summary>
    /// Gets or initializes the initial polarity of the object.
    /// </summary>
    public Polarity InitialPolarity { get; init; }

    /// <summary>
    /// Gets the current polarity of the object.
    /// </summary>
    public Polarity CurrentPolarity =>
        Qi switch
        {
            < DefaultTaijiQi => Polarity.Yin,
            > DefaultTaijiQi => Polarity.Yang,
            _ => Polarity.Taiji,
        };

    /// <summary>
    /// Indicates whether the yinyang threshold values of the object are valid.
    /// </summary>
    /// <param name="yinji">The yin extremum value of the object to test.</param>
    /// <param name="yinchi">The yin threshold value of the object to test.</param>
    /// <param name="taiji">The taiji value of the object to test.</param>
    /// <param name="yangchi">The yang threshold value of the object to test.</param>
    /// <param name="yangji">The yang extremum value of the object to test.</param>
    /// <returns><c>true</c> if the thresholds are valid; otherwise, <c>false</c>.</returns>
    public static bool AreThresholdsValid(int yinji, int yinchi, int taiji, int yangchi, int yangji) =>
        (yinji <= yinchi) && (yinchi <= taiji) && (taiji <= yangchi) && (yangchi <= yangji);

    /// <summary>
    /// Attempts to set the yinyang threshold values of the object.
    /// </summary>
    /// <param name="yinji">The yin extremum value of the object to set.</param>
    /// <param name="yinchi">The yin threshold value of the object to set.</param>
    /// <param name="taiji">The taiji value of the object to set.</param>
    /// <param name="yangchi">The yang threshold value of the object to set.</param>
    /// <param name="yangji">The yang extremum value of the object to set.</param>
    /// <returns><c>true</c> if the yinyang threshold values were set successfully; otherwise, <c>false</c>.</returns>
    public bool TrySetThresholds(int yinji, int yinchi, int taiji, int yangchi, int yangji);
}
