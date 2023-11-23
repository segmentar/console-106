using Core;

namespace Core
{
    using System;

    partial struct MaterialreflectSecondarymodule
    {
        public partial class FunctionEighty
        {
            public static SecondarymoduleFunctionEightyPort[] FunctionDefaultSetSurface(SecondarymoduleFunctionSeventyPort[] Function_ARRAY)
            {
                SecondarymoduleFunctionEightyPort[] arrayResult = default;

                var list = FunctionDefaultSet(Function_ARRAY);

                var array = new SecondarymoduleFunctionEightyPort[list.Count];

                list.CopyTo(array, MaterialreflectPolicy.MaterialreflectIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
