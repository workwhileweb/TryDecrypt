namespace TryDecrypt;

/// <summary>
/// https://gist.github.com/davidruhmann/98d51e413d1b6b0b2899
/// </summary>
public static class StringExtensions
{
    public static int FromBase(this string text, int radix, string digits, bool forgive = false)
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

        // Convert to Base 10
        var value = 0;
        if (string.IsNullOrEmpty(text)) return value;
        for (var i = text.Length - 1; i >= 0; --i)
        {
            var temp = digits.IndexOf(text[i]) * (int)Math.Pow(radix, text.Length - (i + 1));
            if (0 > temp && !forgive)
            {
                throw new IndexOutOfRangeException("Text contains characters not found in digits.");
            }
            value += temp;
        }
        return value;
    }

    public static string ToBase(this string text, int fromRadix, string fromDigits, int toRadix, string toDigits)
    {
        return text.FromBase(fromRadix, fromDigits).ToBase(toRadix, toDigits);
    }

    public static string ToBase(this string text, int from, int to, string digits)
    {
        return text.FromBase(from, digits).ToBase(to, digits);
    }
}