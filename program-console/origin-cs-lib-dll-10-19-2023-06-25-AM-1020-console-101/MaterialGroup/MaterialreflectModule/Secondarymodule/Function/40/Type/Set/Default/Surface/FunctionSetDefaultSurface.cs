using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class FunctionFourty
        {
            public static FunctionFourty[] FunctionDefaultSetSurface(FunctionThirty[] Function__ARRAY)
            {
                FunctionFourty[] arrayResult = default;

                var list = FunctionDefaultSet(Function__ARRAY);

                var array = new FunctionFourty[list.Count];

                list.CopyTo(array, MaterialPolicy.MaterialIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
