namespace Yinyang.Items;

/// <summary>
/// Represents the types of items within the game.
/// </summary>
[Flags]
public enum ItemType
{
    /// <summary>
    /// No item type.
    /// </summary>
    None = 0,

    /// <summary>
    /// The consumable type.
    /// </summary>
    Consumable = 1 << 0,

    /// <summary>
    /// The equipment type.
    /// </summary>
    Equipment = 1 << 1,

    /// <summary>
    /// The material type.
    /// </summary>
    Material = 1 << 2,

    /// <summary>
    /// The quest type.
    /// </summary>
    Quest = 1 << 3,

    /// <summary>
    /// The dan type.
    /// </summary>
    /// <remarks>
    /// 丹，是道教炼丹术的产物，以此追求长生不老，增益灵力，或获取超凡之力。
    /// </remarks>
    Dan = 1 << 4 | Consumable,

    /// <summary>
    /// The fulu type.
    /// </summary>
    /// <remarks>
    /// 符箓，是符篆和法箓的合称，道士以符箓召神劾鬼，趋吉避凶，降妖镇魔，治病除灾。
    /// </remarks>
    Fulu = 1 << 5 | Consumable,
}
