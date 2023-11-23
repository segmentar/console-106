using Core;

namespace Core
{
    using System;

    public partial struct HostStringSafe
    {
        public String StringValue { get; set; }
        public String StringValueSafe { get; set; }

        public static HostStringSafe Simple(String String_VALUE)
        {
            HostStringSafe safeResult = default;

            var value = String_VALUE;

            String stringValue, stringValueSafe;

            stringValue = value;

            stringValueSafe = Host.SolidString(value);

            HostStringSafe safe;

            safe = new HostStringSafe();

            safe.StringValue = stringValue;

            safe.StringValueSafe = stringValueSafe;

            safeResult = safe;

            return safeResult;
        }
    }
}
