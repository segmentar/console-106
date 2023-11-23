using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class FunctionSeventy
        {
            public static SecondarymoduleFunctionSeventyPort[] FunctionDefaultSetSurface(FunctionSixty[] array__FUNCTION, Tuple<Char, String[], String[]>[] array_TUPLE)
            {
                SecondarymoduleFunctionSeventyPort[] arrayResult = default;

                var list = FunctionDefaultSet(array__FUNCTION, array_TUPLE);

                var array = new SecondarymoduleFunctionSeventyPort[list.Count];

                list.CopyTo(array, MaterialreflectPolicy.MaterialreflectIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
