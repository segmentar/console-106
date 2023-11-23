using Core;

namespace Core
{
    using System;

    public partial struct MaterialStringSafe
    {
        public String StringValue { get; set; }
        public String StringValueSafe { get; set; }

        public static MaterialStringSafe Simple(String String_VALUE)
        {
            MaterialStringSafe safeResult = default;

            String stringElement;

            stringElement = String_VALUE;

            stringElement = Material.SolidString(stringElement);

            String stringValue, stringValueSafe;

            stringValue = String_VALUE;

            stringValueSafe = stringElement;

            MaterialStringSafe safe;

            safe = new MaterialStringSafe();

            safe.StringValue = stringValue;

            safe.StringValueSafe = stringValueSafe;

            safeResult = safe;

            return safeResult;
        }
    }
}
