using Core;

namespace Core
{
    using System;

    public partial struct Materialinflect
    {
        public static Char[] MaterialinflectPeriodDictionaryFilterCompoundSurface(String HeaderString__VALUE, Int32 Filter_INTEGER)
        {
            Char[] arrayResult = default;

            var array = MaterialinflectPeriodDictionaryFilterCompound(HeaderString__VALUE, Filter_INTEGER);

            var join = String.Join(String.Empty, array);

            var result = join.ToCharArray();

            arrayResult = result;

            return arrayResult;
        }
    }
}
