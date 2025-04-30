namespace Yinyang;

/// <summary>
/// Defines methods for all objects with yinyang elements.
/// </summary>
public interface IYinyang
{
    /// <summary>
    /// Defines the <see cref="Qi"/> of taiji polarity, which is "0".
    /// </summary>
    public const int TaijiQi = 0;

    /// <summary>
    /// Gets or sets the current yinyang value of the object.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Qi, the quintessence of the Dao, is the primal breath of the cosmos. Pervading yin and yang, it engenders all
    /// things, the root of being and the fount of transformation.
    /// </para>
    /// <para>炁，道之精髓，宇宙之元气也。流贯阴阳，化育万物，乃存在之本，变易之源。</para>
    /// </remarks>
    public int Qi { get; set; }

    /// <summary>
    /// Gets the <see cref="Qi"/> of the object's yinchi threshold.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Yinchi defines the boundary of yin’s equilibrium. It tempers its flux, sustaining harmony, averting excess and
    /// collapse.
    /// </para>
    /// <para>阴持，阴气均衡之界。调其盛衰，守中和之态，防极而倾。</para>
    /// </remarks>
    public int Yinchi { get; }

    /// <summary>
    /// Gets the <see cref="Qi"/> of the object's yangchi threshold.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Yangchi marks the limit of yang’s equilibrium. It harmonizes its surge, sustaining harmony, curbing excess for
    /// stability.
    /// </para>
    /// <para>阳持，阳气均衡之限。调其起伏，护中和之道，抑盛而安。</para>
    /// </remarks>
    public int Yangchi { get; }

    /// <summary>
    /// Gets the <see cref="Qi"/> of the object's yinji threshold.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Yinji is the pivot of yin’s utmost intensity. At its extreme, it reverses, sparking yang’s emergence, pivotal
    /// to the cycle.
    /// </para>
    /// <para>阴极，阴气极盛之枢。物极必反，启阳化之机，循环之要。</para>
    /// </remarks>
    public int Yinji { get; }

    /// <summary>
    /// Gets the <see cref="Qi"/> of the object's yangji threshold.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Yangji marks the crux of yang’s peak. At its zenith, it reverses, ushering yin’s rise, pivotal to the cycle.
    /// </para>
    /// <para>阳极，阳气极盛之要。物极则反，导阴生之变，循环之基。</para>
    /// </remarks>
    public int Yangji { get; }

    /// <summary>
    /// Gets the original polarity of the object.
    /// </summary>
    public Polarity OriginalPolarity { get; }

    /// <summary>
    /// Gets the current polarity of the object.
    /// </summary>
    public Polarity CurrentPolarity =>
        Qi switch
        {
            < TaijiQi => Polarity.Yin,
            > TaijiQi => Polarity.Yang,
            _ => Polarity.Taiji,
        };

    /// <summary>
    /// Indicates whether the object's threshold values are valid.
    /// </summary>
    /// <param name="yinji">The <see cref="Qi"/> of the object's yinji threshold to test.</param>
    /// <param name="yinchi">The <see cref="Qi"/> of the object's yinchi threshold to test.</param>
    /// <param name="yangchi">The <see cref="Qi"/> of the object's yangchi threshold to test.</param>
    /// <param name="yangji">The <see cref="Qi"/> of the object's yangji threshold to test.</param>
    /// <returns><c>true</c> if the object's threshold values are valid; otherwise, <c>false</c>.</returns>
    public static bool AreThresholdsValid(int yinji, int yinchi, int yangchi, int yangji) =>
        (yinji <= yinchi) && (yinchi <= TaijiQi) && (TaijiQi <= yangchi) && (yangchi <= yangji);

    /// <summary>
    /// Indicates whether the object's <see cref="Qi"/> is valid.
    /// </summary>
    /// <param name="qi">The <see cref="Qi"/> of the object to test.</param>
    /// <param name="yinji">The <see cref="Qi"/> of the object's yinji threshold to test.</param>
    /// <param name="yangji">The <see cref="Qi"/> of the object's yangji threshold to test.</param>
    /// <returns><c>true</c> if the object's <see cref="Qi"/> is valid; otherwise, <c>false</c>.</returns>
    public static bool IsQiValid(int qi, int yinji, int yangji) => (yinji <= qi) && (qi <= yangji);

    /// <summary>
    /// Attempts to set the object's threshold values.
    /// </summary>
    /// <param name="yinji">The <see cref="Qi"/> of the object's yinji threshold to set.</param>
    /// <param name="yinchi">The <see cref="Qi"/> of the object's yinchi threshold to set.</param>
    /// <param name="yangchi">The <see cref="Qi"/> of the object's yangchi threshold to set.</param>
    /// <param name="yangji">The <see cref="Qi"/> of the object's yangji threshold to set.</param>
    /// <returns><c>true</c> if the threshold values were set successfully; otherwise, <c>false</c>.</returns>
    public bool TrySetThresholds(int yinji, int yinchi, int yangchi, int yangji);
}
