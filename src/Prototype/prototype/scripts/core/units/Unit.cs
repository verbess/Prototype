using Godot;

namespace Yinyang;

/// [TODO] May need a container to package this class and initialize the unit node at runtime.
/// [WARN] Not ready for use. Intended as a temporary commit.
/// <summary>
/// Represents the ultimate base class of all interactive units within the game.
/// </summary>
public abstract partial class Unit(string key, int qi) : Node2D, IUnit
{
    /// <inheritdoc />
    public string Key { get; init; } = key;

    /// <inheritdoc />
    public int Qi { get; set; } = qi;

    /// <inheritdoc />>
    public int Yinchi { get; protected set; }

    /// <inheritdoc />
    public int Yangchi { get; protected set; }

    /// <inheritdoc />
    public int Yinji { get; protected set; }

    /// <inheritdoc />
    public int Yangji { get; protected set; }

    /// <inheritdoc />
    public Polarity InitialPolarity { get; init; }

    /// <inheritdoc />
    public bool TrySetThresholds(int yinji, int yinchi, int yangchi, int yangji)
    {
        if (IYinyang.AreThresholdsValid(yinji, yinchi, yangchi, yangji))
        {
            Yinji = yinji;
            Yinchi = yinchi;
            Yangchi = yangchi;
            Yangji = yangji;

            return true;
        }

        return false;
    }
}
