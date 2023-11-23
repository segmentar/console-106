using Core;

namespace Core
{
    using System;

    public partial struct MaterialStringArraySafe
    {
        public String[] StringArray { get; set; }
        public String[] StringArraySafe { get; set; }

        public static MaterialStringArraySafe Simple(String[] String_ARRAY)
        {
            MaterialStringArraySafe safeResult = default;

            String[] stringArray, stringArraySafe;

            stringArray = String_ARRAY;

            stringArraySafe = Material.SolidStringArray(String_ARRAY);

            MaterialStringArraySafe safe;

            safe = new MaterialStringArraySafe();

            safe.StringArray = stringArray;

            safe.StringArraySafe = stringArraySafe;

            safeResult = safe;

            return safeResult;
        }
    }
}
