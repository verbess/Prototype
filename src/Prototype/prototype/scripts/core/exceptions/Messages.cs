namespace YinYang;

/// <summary>
/// Serves as the resource class for exception error message constants.
/// </summary>
internal static class Messages
{
    #region Argument exceptions
    /// <summary>
    /// Invalid thresholds order. Required order: YinJi ({0}) <= YinChi ({1}) <= DefaultTaiJiQi ({2}) <= YangChi ({3})
    /// <= YangJi ({4}).
    /// </summary>
    internal const string Argument_InvalidThresholdsOrder =
        @"Invalid thresholds order. Required order: YinJi ({0}) <= YinChi ({1}) <= DefaultTaiJiQi ({2}) <= YangChi ({3}) <= YangJi ({4}).";
    #endregion
}
