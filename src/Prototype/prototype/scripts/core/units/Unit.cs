using Godot;

namespace YinYang;

/// <summary>
///
/// </summary>
/// <param name="id"></param>
/// <param name="qi"></param>
public abstract partial class Unit(int id, int qi) : Node, IUnit
{
    /// <summary>
    ///
    /// </summary>
    /// <param name="id"></param>
    /// <param name="qi"></param>
    /// <param name="yinJi"></param>
    /// <param name="yinChi"></param>
    /// <param name="yangChi"></param>
    /// <param name="yangJi"></param>
    /// <exception cref="ArgumentException"></exception>
    protected Unit(int id, int qi, int yinJi, int yinChi, int yangChi, int yangJi)
        : this(id, qi)
    {
        if (!TrySetThresholds(yinJi, yinChi, yangChi, yangJi))
        {
            throw new ArgumentException(
                string.Format(
                    Messages.Argument_InvalidThresholdsOrder,
                    nameof(yinJi),
                    nameof(yinChi),
                    nameof(IYinYang.DefaultTaiJiQi),
                    nameof(yangChi),
                    nameof(yangJi)
                )
            );
        }
    }

    /// <inheritdoc />
    public int Id { get; init; } = id;

    /// <inheritdoc />
    public int Qi { get; set; } = qi;

    /// <inheritdoc />
    public int YinChi { get; protected set; }

    /// <inheritdoc />
    public int YangChi { get; protected set; }

    /// <inheritdoc />
    public int YinJi { get; protected set; }

    /// <inheritdoc />
    public int YangJi { get; protected set; }

    /// <inheritdoc />
    public Polarity InitialPolarity { get; init; }

    /// <inheritdoc />
    public bool TrySetThresholds(int yinJi, int yinChi, int yangChi, int yangJi)
    {
        if (IYinYang.AreThresholdsValid(yinJi, yinChi, yangChi, yangJi))
        {
            YinJi = yinJi;
            YinChi = yinChi;
            YangChi = yangChi;
            YangJi = yangJi;

            return true;
        }

        return false;
    }
}
