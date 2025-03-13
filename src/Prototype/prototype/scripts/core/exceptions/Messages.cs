namespace Yinyang;

/// <summary>
/// Serves as the resource class for exception error message constants.
/// </summary>
internal static class Messages
{
    #region Argument exceptions
    /// <summary>
    /// Thresholds must satisfy: Yinji <= Yinchi <= Taiji <= Yangchi <= Yangji.
    /// </summary>
    internal const string Argument_InvalidThresholdsOrder =
        @"Thresholds must satisfy: Yinji <= Yinchi <= Taiji <= Yangchi <= Yangji.";
    #endregion
}
