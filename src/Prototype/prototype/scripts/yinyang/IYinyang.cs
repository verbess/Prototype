namespace Yinyang;

/// <summary>
/// Defines methods for objects with yinyang elements.
/// </summary>
public interface IYinyang
{
    /// <summary>
    /// Defines the default yinyang value of taiji polarity, which is "0".
    /// </summary>
    public const int DefaultTaijiCharge = 0;

    /// <summary>
    /// Gets or sets the current yinyang value of the object.
    /// </summary>
    public int Charge { get; set; }

    /// <summary>
    /// Gets or sets the yin threshold value of the object.
    /// </summary>
    public int YinThreshold { get; set; }

    /// <summary>
    /// Gets or sets the yang threshold value of the object.
    /// </summary>
    public int YangThreshold { get; set; }

    /// <summary>
    /// Gets or sets the yin extremum value of the object.
    /// </summary>
    public int YinJi { get; set; }

    /// <summary>
    /// Gets or sets the yang extremum value of the object.
    /// </summary>
    public int YangJi { get; set; }

    /// <summary>
    /// Gets or inits the initial yinyang polarity of the object.
    /// </summary>
    public Polarity InitialPolarity { get; init; }

    /// <summary>
    /// Gets the current yinyang polarity of the object.
    /// </summary>
    public Polarity CurrentPolarity =>
        Charge switch
        {
            < DefaultTaijiCharge => Polarity.Yin,
            > DefaultTaijiCharge => Polarity.Yang,
            _ => Polarity.Taiji,
        };
}
