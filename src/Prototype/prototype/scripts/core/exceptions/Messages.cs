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
    internal const string Argument_ThresholdsOutOfOrder =
        @"Thresholds must be ordered as: Yinji <= Yinchi <= 0 <= Yangchi <= Yangji.";
    #endregion
}
