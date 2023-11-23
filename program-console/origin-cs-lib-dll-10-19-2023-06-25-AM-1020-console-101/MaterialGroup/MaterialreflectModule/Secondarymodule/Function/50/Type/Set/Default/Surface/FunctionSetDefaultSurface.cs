using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class FunctionFifty
        {
            public static FunctionFifty[] FunctionDefaultSetSurface(String InputString__VALUE, FunctionFourty[] FunctionSeventy_ARRAY)
            {
                FunctionFifty[] arrayResult = default;

                var list = FunctionDefaultSet(InputString__VALUE, FunctionSeventy_ARRAY);

                var array = new FunctionFifty[list.Count];

                list.CopyTo(array, MaterialreflectPolicy.MaterialreflectIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
    