using Core;

namespace Core
{
    using System;

    public partial struct ScopeStringSafe
    {
        public String StringValue { get; set; }
        public String StringValueSafe { get; set; }

        public static ScopeStringSafe Simple(String value_STRING)
        {
            ScopeStringSafe safeResult = default;

            var value = value_STRING;

            String stringValue, stringValueSafe;

            stringValue = value;

            stringValueSafe = Scope.SolidString(value);

            ScopeStringSafe safe;

            safe = new ScopeStringSafe();

            safe.StringValue = stringValue;

            safe.StringValueSafe = stringValueSafe;

            safeResult = safe;

            return safeResult;
        }
    }
}
