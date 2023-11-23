using Core;

namespace Core
{
    using System;

    public partial struct HostStringArraySafe
    {
        public String[] StringArrayValue;

        public String[] StringArrayValueSafe;

        public static HostStringArraySafe Simple(String[] array_STRING)
        {
            HostStringArraySafe safeResult = default;

            var array = array_STRING;

            String[] stringArrayValue, stringArrayValueSafe;

            stringArrayValue = array;

            stringArrayValueSafe = Host.SolidStringArray(array);

            HostStringArraySafe safe;

            safe = new HostStringArraySafe();

            safe.StringArrayValue = stringArrayValue;

            safe.StringArrayValueSafe = stringArrayValueSafe;

            safeResult = safe;

            return safeResult;
        }
    }
}
