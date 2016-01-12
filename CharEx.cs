using System.Globalization;

static partial class CharEx
{
#pragma warning disable 1591

    #region IS

    public static bool IsControl(this char c)
        => char.IsControl(c);
    public static bool IsDigit(this char c)
        => char.IsDigit(c);
    public static bool IsLetter(this char c)
        => char.IsLetter(c);

    public static bool IsUpper(this char c)
        => char.IsUpper(c);
    public static bool IsLower(this char c)
        => char.IsLower(c);
    public static bool IsLetterOrDigit(this char c)
        => char.IsLetterOrDigit(c);
    public static bool IsNumber(this char c)
        => char.IsNumber(c);

    public static bool IsPunctuation(this char c)
        => char.IsPunctuation(c);
    public static bool IsSeparator(this char c)
        => char.IsSeparator(c);

    public static bool IsSurrogate(this char c)
        => char.IsSurrogate(c);
    public static bool IsHighSurrogate(this char c)
#if PCL
        => ((c >= '\uD800') && (c < '\uDC00'));
#else
        => char.IsHighSurrogate(c);
#endif
    public static bool IsLowSurrogate(this char c)
#if PCL
        => ((c >= '\uDC00') && (c < '\uDE00'));
#else
        => char.IsLowSurrogate(c);
#endif

    public static bool IsSymbol(this char c)
        => char.IsSymbol(c);
    public static bool IsWhiteSpace(this char c)
        => char.IsWhiteSpace(c);

    #endregion

    #region ToLower

    public static char ToLower(this char c)
        => char.ToLower(c);
    public static char ToLower(this char c, CultureInfo culture)
        => char.ToLower(c, culture);
    public static char ToLowerInvariant(this char c)
        => char.ToLowerInvariant(c);

    #endregion

    #region ToUpper

    public static char ToUpper(this char c)
        => char.ToUpper(c);
    public static char ToUpper(this char c, CultureInfo culture)
        => char.ToUpper(c, culture);
    public static char ToUpperInvariant(this char c)
        => char.ToUpperInvariant(c);

    #endregion
}
