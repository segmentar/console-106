using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class FunctionSixty
        {
            public static FunctionSixty[] FunctionDefaultSetSurface(String InputString__VALUE, FunctionFifty[] Functionfifty_ARRAY, Tuple<Char, Char, Boolean>[] Tuple_ARRAY)
            {
                FunctionSixty[] arrayResult = default;

                var list = FunctionDefaultSet(InputString__VALUE, Functionfifty_ARRAY, Tuple_ARRAY);

                var array = new FunctionSixty[list.Count];

                list.CopyTo(array, MaterialreflectPolicy.MaterialreflectIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
