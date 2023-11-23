using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class FunctionTwenty
        {
            public static FunctionTwenty[] FunctionDefaultSetSurface(String InputString__VALUE, Tuple<Char, Char, Boolean>[] Tuple_ARRAY)
            {
                FunctionTwenty[] arrayResult = default;

                var list = FunctionDefaultSet(InputString__VALUE, Tuple_ARRAY);

                var array = new FunctionTwenty[list.Count];

                list.CopyTo(array, MaterialreflectPolicy.MaterialreflectIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
