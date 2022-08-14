namespace TryDecrypt
{
    /// <summary>
    /// https://stackoverflow.com/questions/923771/quickest-way-to-convert-a-base-10-number-to-any-base-in-net
    /// </summary>
    internal class BaseN
    {
        private readonly char[] _charsArr;
        private readonly Dictionary<char, byte> _charValues;

        public BaseN(string chars)
        {
            if (chars.Length >= byte.MaxValue) throw new Exception("chỉ hỗ trợ base < 256");
            _charsArr = chars.ToCharArray();
            _charValues = _charsArr
                .Select((c, i) => new { Char = c, Index = (byte)i })
                .ToDictionary(c => c.Char, c => c.Index);
        }

        public byte[] ToByteArray(string number, int length)
        {
            var bytes = new byte[length];
            var value = number.Select(c => _charValues[c]).ToArray();
            for (var i = 0; i < length - value.Length; i++) bytes[i] = byte.MaxValue;
            for (var i = length - value.Length; i < length; i++) bytes[i] = value[i - length + value.Length];
            return bytes;
        }

        public string FromByteArray(byte[] bytes)
        {
            return new string(bytes.Select(b => b >= byte.MaxValue ? ' ' : _charsArr[b]).ToArray()).Trim();
        }

        public void ByteArrayAdd1(ref byte[] bytes)
        {
            for (var i = bytes.Length-1; i >=0; i--)
            {
                if (bytes[i]>=byte.MaxValue) bytes[i] = 0;
                else
                {
                    bytes[i] = (byte) (bytes[i] + 1);
                    break;
                }
            }
        }

        public string From10(long value)
        {
            long targetBase = _charsArr.Length;
            var buffer = new char[Math.Max((int)Math.Ceiling(Math.Log(value + 1, targetBase)), 1)];

            var i = buffer.Length;
            do
            {
                buffer[--i] = _charsArr[value % targetBase];
                value /= targetBase;
            }
            while (value > 0);

            return new string(buffer, i, buffer.Length - i);
        }

        public long To10(string number)
        {
            var chrs = number.ToCharArray();
            var m = chrs.Length - 1;
            var n = _charsArr.Length;
            return chrs.Select(c => _charValues[c]).Select(x => x * (long) Math.Pow(n, m--)).Sum();
        }
    }
}