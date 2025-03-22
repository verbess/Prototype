namespace Yinyang;

/// <summary>
/// Defines methods for objects with yinyang elements.
/// </summary>
public interface IYinyang
{
    /// <summary>
    /// Defines the yinyang value of taiji polarity, which is "0".
    /// </summary>
    public const int TaijiQi = 0;

    /// <summary>
    /// Gets or sets the current yinyang value of the object.
    /// </summary>
    /// <remarks>
    /// 炁，是中国古代的哲学概念，指产生和构成天地万物的原始能量，成为天地一切事物组成的基本元素。
    /// </remarks>
    public int Qi { get; set; }

    /// <summary>
    /// Gets the yinyang value of the object's yinchi threshold.
    /// </summary>
    /// <remarks>
    /// 阴持，“持”字源自《黄帝内经》“持满御神”概念，指保持适度状态，对应现代医学的“稳态维持”。
    /// </remarks>
    public int Yinchi { get; }

    /// <summary>
    /// Gets the yinyang value of the object's yangchi threshold.
    /// </summary>
    /// <remarks>
    /// 阳持，“持”字源自《黄帝内经》“持满御神”概念，指保持适度状态，对应现代医学的“稳态维持”。
    /// </remarks>
    public int Yangchi { get; }

    /// <summary>
    /// Gets the yinyang value of the object's yinji threshold.
    /// </summary>
    /// <remarks>
    /// 阴极，“极”字源自《素问》“重阴必阳”概念，指阴气达到物极必反的临界状态。
    /// </remarks>
    public int Yinji { get; }

    /// <summary>
    /// Gets the yinyang value of the object's yangji threshold.
    /// </summary>
    /// <remarks>
    /// 阳极，“极”字源自《素问》“重阳必阴”概念，指阳气达到物极必反的临界状态。
    /// </remarks>
    public int Yangji { get; }

    /// <summary>
    /// Gets the initial polarity of the object.
    /// </summary>
    public Polarity InitialPolarity { get; }

    /// <summary>
    /// Gets the currents polarity of the object.
    /// </summary>
    public Polarity CurrentPolarity =>
        Qi switch
        {
            < TaijiQi => Polarity.Yin,
            > TaijiQi => Polarity.Yang,
            _ => Polarity.Taiji,
        };

    /// <summary>
    /// Indicates whether the object's yinyang threshold values are valid.
    /// </summary>
    /// <param name="yinji">The yinyang value of the object's yinji threshold to test.</param>
    /// <param name="yinchi">The yinyang value of the object's yinchi threshold to test.</param>
    /// <param name="yangchi">The yinyang value of the object's yangchi threshold to test.</param>
    /// <param name="yangji">The yinyang value of the object's yangji threshold to test.</param>
    /// <returns><c>true</c> if the object's yinyang threshold value are valid; otherwise, <c>false</c>.</returns>
    public static bool AreThresholdsValid(int yinji, int yinchi, int yangchi, int yangji) =>
        (yinji <= yinchi) && (yinchi <= TaijiQi) && (TaijiQi <= yangchi) && (yangchi <= yangji);

    /// <summary>
    /// Attempts to set the object's yinyang threshold values.
    /// </summary>
    /// <param name="yinji">The yinyang value of the object's yinji threshold to set.</param>
    /// <param name="yinchi">The yinyang value of the object's yinchi threshold to set.</param>
    /// <param name="yangchi">The yinyang value of the object's yangchi threshold to set.</param>
    /// <param name="yangji">The yinyang value of the object's yangji threshold to set.</param>
    /// <returns>
    /// <c>true</c> if the yinyang threshold values were set successfully; otherwise, <c>false</c>.
    /// </returns>
    public bool TrySetThresholds(int yinji, int yinchi, int yangchi, int yangji);
}
