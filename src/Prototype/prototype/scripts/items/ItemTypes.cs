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
    /// <para>
    /// Dan, forged from the primal essence of heaven and earth, embodies the mysteries of Daoist alchemy. Consumed, it
    /// augments spiritual force, prolongs life, and may lead to transcendence.
    /// </para>
    /// <para>丹，炼自天地灵气，凝道教玄妙，服之可增益灵力，延寿续命，乃至超凡入圣。</para>
    /// </remarks>
    Dan = (1 << 4) | Consumable,

    /// <summary>
    /// The fulu type. Value: 33, Binary: 0010_0001.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Fulu, the vessel of Daoist magic, inscribed with charms to summon spirits, banish demons, attract fortune, and
    /// avert calamity, safeguarding practitioners in peril.
    /// </para>
    /// <para>符箓，道法之载体，书符召神，驱鬼镇魔，趋吉避凶，护修行者于危难。</para>
    /// </remarks>
    Fulu = (1 << 5) | Consumable,
    #endregion
}
