namespace Yinyang;

/// <summary>
/// Defines methods for objects with yinyang elements.
/// </summary>
public interface IYinyang
{
    /// <summary>
    /// Defines the default yinyang value of taiji polarity, which is "0".
    /// </summary>
    public const int DefaultTaijiYinyangValue = 0;

    /// <summary>
    /// Gets or inits the initial yinyang polarity of the object.
    /// </summary>
    public Polarity InitialPolarity { get; init; }

    /// <summary>
    /// Gets the current yinyang polarity of the object.
    /// </summary>
    public Polarity CurrentPolarity =>
        YinyangValue switch
        {
            < DefaultTaijiYinyangValue => Polarity.Yin,
            DefaultTaijiYinyangValue => Polarity.Taiji,
            > DefaultTaijiYinyangValue => Polarity.Yang,
        };

    /// <summary>
    /// Gets or sets the current yinyang value of the object.
    /// </summary>
    public int YinyangValue { get; set; }

    /// <summary>
    /// Gets or sets the yin threshold value of the object.
    /// </summary>
    public int YinThresholdValue { get; set; }

    /// <summary>
    /// Gets or sets the yang threshold value of the object.
    /// </summary>
    public int YangThresholdValue { get; set; }

    /// <summary>
    /// Gets or sets the yin limit value of the object.
    /// </summary>
    public int YinLimitValue { get; set; }

    /// <summary>
    /// Gets or sets the yang limit value of the object.
    /// </summary>
    public int YangLimitValue { get; set; }
}
