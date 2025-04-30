namespace Yinyang;

/// <summary>
/// Serves as the resource class for exception error message constants.
/// </summary>
internal static class Messages
{
    #region Argument exceptions
    /// <summary>
    /// Thresholds must be ordered as: Yinji &lt;= Yinchi &lt;= 0 &lt;= Yangchi &lt;= Yangji.
    /// </summary>
    /// <remarks>For details of the yinyang system, read <see cref="IYinyang"/> interface.</remarks>
    internal const string Argument_ThresholdsOutOfOrder =
        "Thresholds must be ordered as: Yinji <= Yinchi <= 0 <= Yangchi <= Yangji.";

    /// <summary>
    /// Qi must be within the range: Yinji &lt;= Qi &lt;= Yangji.
    /// </summary>
    /// <remarks>For details of the yinyang system, read <see cref="IYinyang"/> interface.</remarks>
    internal const string Argument_QiOutOfRange = "Qi must be within the range: Yinji <= Qi <= Yangji.";
    #endregion
}
