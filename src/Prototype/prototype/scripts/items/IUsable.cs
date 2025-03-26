namespace Yinyang.Items;

/// <summary>
/// Defines methods for an item's usability.
/// </summary>
public interface IUsable
{
    /// <summary>
    /// Gets a value indicating whether this item can be used.
    /// </summary>
    public bool IsUsable { get; }

    /// <summary>
    /// Occurs when the usability of the item changes.
    /// </summary>
    public event EventHandler? UsabilityChanged;

    /// <summary>
    /// Attempts to use the item by the specified user.
    /// </summary>
    /// <param name="user">The unit attempting to use the item.</param>
    /// <returns><c>true</c> if the item was used successfully; otherwise, <c>false</c>.</returns>
    public bool TryUse(IUnit user);
}
