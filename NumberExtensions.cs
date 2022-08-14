namespace TryDecrypt;

/// <summary>
/// https://gist.github.com/davidruhmann/98d51e413d1b6b0b2899
/// </summary>
public static class NumberExtensions
{
    public static string ToBase(this int value, int radix, string digits)
    {
        if (string.IsNullOrEmpty(digits))
        {
            throw new ArgumentNullException(nameof(digits), @"Digits must contain character value representations");
        }

        radix = Math.Abs(radix);
        if (radix > digits.Length || radix < 2)
        {
            throw new ArgumentOutOfRangeException(nameof(radix), radix, $@"Radix has to be > 2 and < {digits.Length}");
        }

        var result = string.Empty;
        var quotient = Math.Abs(value);
        while (0 < quotient)
        {
            var temp = quotient % radix;
            result = digits[temp] + result;
            quotient /= radix;
        }
        return result;
    }

    /// <summary>
    /// https://stackoverflow.com/questions/923771/quickest-way-to-convert-a-base-10-number-to-any-base-in-net
    /// An optimized method using an array as buffer instead of 
    /// string concatenation. This is faster for return values having 
    /// a length > 1.
    /// </summary>
    public static string IntToStringFast(this int value, char[] baseChars)
    {
        // 32 is the worst cast buffer size for base 2 and int.MaxValue
        var i = 32;
        var buffer = new char[i];
        var targetBase = baseChars.Length;

        do
        {
            buffer[--i] = baseChars[value % targetBase];
            value /= targetBase;
        }
        while (value > 0);

        var result = new char[32 - i];
        Array.Copy(buffer, i, result, 0, 32 - i);

        return new string(result);
    }
}