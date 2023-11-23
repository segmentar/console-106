using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectTertiarymodule
    {
        public partial class FunctionTwenty
        {
            public static Materialquery[] FunctionDefaultSetSurface(Tuple<Materialquery, SecondarymoduleFunctionSeventyPort>[] Tuple_ARRAY)
            {
                Materialquery[] arrayResult = default;

                var list = FunctionDefaultSet(Tuple_ARRAY);

                var array = new Materialquery[list.Count];

                list.CopyTo(array, MaterialPolicy.MaterialIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
