namespace Yinyang.Items;

/// <summary>
/// Represents the types of items within the game.
/// </summary>
[Flags]
public enum ItemTypes
{
    #region Basic item types
    /// <summary>
    /// No item type. Value: 0, Binary: 0000.
    /// </summary>
    None = 0,

    /// <summary>
    /// The consumable type. Value: 1, Binary: 0001.
    /// </summary>
    Consumable = 1 << 0,

    /// <summary>
    /// The equipment type. Value: 2, Binary: 0010.
    /// </summary>
    Equipment = 1 << 1,

    /// <summary>
    /// The material type. Value: 4, Binary: 0100.
    /// </summary>
    Material = 1 << 2,

    /// <summary>
    /// The quest type. Value: 8, Binary: 1000.
    /// </summary>
    Quest = 1 << 3,
    #endregion

    #region Advanced item types
    /// <summary>
    /// The dan type. Value: 17, Binary: 0001_0001.
    /// </summary>
    /// <remarks>
    /// 丹，是道教炼丹术的产物，以此追求长生不老，增益灵力，或获取超凡之力。
    /// </remarks>
    Dan = (1 << 4) | Consumable,

    /// <summary>
    /// The fulu type. Value: 33, Binary: 0010_0001.
    /// </summary>
    /// <remarks>
    /// 符箓，是符篆和法箓的合称，道士以符箓召神劾鬼，趋吉避凶，降妖镇魔，治病除灾。
    /// </remarks>
    Fulu = (1 << 5) | Consumable,
    #endregion
}
