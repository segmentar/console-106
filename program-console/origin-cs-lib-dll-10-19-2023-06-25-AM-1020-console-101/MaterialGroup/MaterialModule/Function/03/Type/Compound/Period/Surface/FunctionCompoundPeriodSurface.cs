using Core;

namespace Core
{
    using System;

    public partial struct MaterialModule
    {
        public static Char[] FunctionPeriodCompoundSurface(Tuple<Int32, String>[] array_TUPLE)
        {
            Char[] arrayResult = default;

            var array = FunctionPeriodCompound(array_TUPLE);

            var join = String.Join(String.Empty, array);

            var result = join.ToCharArray();

            arrayResult = result;

            return arrayResult;
        }
    }
}
