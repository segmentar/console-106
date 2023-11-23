using Core;

namespace Core
{
    using System;

    public partial struct ScopeStringArraySafe
    {
        public String[] StringArrayValue;

        public String[] StringArrayValueSafe;

        public static ScopeStringArraySafe Simple(String[] array_STRING)
        {
            ScopeStringArraySafe safeResult = default;

            var array = array_STRING;

            String[] stringArrayValue, stringArrayValueSafe;

            stringArrayValue = array;

            stringArrayValueSafe = Scope.SolidStringArray(array);

            ScopeStringArraySafe safe;

            safe = new ScopeStringArraySafe();

            safe.StringArrayValue = stringArrayValue;

            safe.StringArrayValueSafe = stringArrayValueSafe;

            safeResult = safe;

            return safeResult;
        }
    }
}
