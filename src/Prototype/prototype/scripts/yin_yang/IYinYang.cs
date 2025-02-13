namespace YinYang;

/// <summary>
/// Defines methods for objects with yin yang elements.
/// </summary>
public interface IYinYang
{
    /// <summary>
    /// Defines the default yin yang value of tai ji polarity, which is "0".
    /// </summary>
    public const int DefaultTaiJiQi = 0;

    /// <summary>
    /// Gets or sets the current yin yang value of the object.
    /// </summary>
    /// <remarks>
    /// 炁，是中国古代的哲学概念，指产生和构成天地万物的原始能量，成为天地一切事物组成的基本元素。
    /// </remarks>
    public int Qi { get; set; }

    /// <summary>
    /// Gets or sets the yin threshold value of the object.
    /// </summary>
    public int YinYu { get; set; }

    /// <summary>
    /// Gets or sets the yang threshold value of the object.
    /// </summary>
    public int YangYu { get; set; }

    /// <summary>
    /// Gets or sets the yin extremum value of the object.
    /// </summary>
    public int YinJi { get; set; }

    /// <summary>
    /// Gets or sets the yang extremum value of the object.
    /// </summary>
    public int YangJi { get; set; }

    /// <summary>
    /// Gets or inits the initial yin yang polarity of the object.
    /// </summary>
    public Polarity InitialPolarity { get; init; }

    /// <summary>
    /// Gets the current yin yang polarity of the object.
    /// </summary>
    public Polarity CurrentPolarity =>
        Qi switch
        {
            < DefaultTaiJiQi => Polarity.Yin,
            > DefaultTaiJiQi => Polarity.Yang,
            _ => Polarity.TaiJi,
        };
}
