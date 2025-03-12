namespace YinYang;

/// <summary>
/// Serves as the resource class for exception error message constants.
/// </summary>
internal static class Messages
{
    #region Argument exceptions
    /// <summary>
    /// Invalid thresholds order. Required order: YinJi <= YinChi <= TaiJi <= YangChi <= YangJi.
    /// </summary>
    internal const string Argument_InvalidThresholdsOrder =
        @"Invalid thresholds order. Required order: YinJi <= YinChi <= TaiJi <= YangChi <= YangJi.";
    #endregion
}
