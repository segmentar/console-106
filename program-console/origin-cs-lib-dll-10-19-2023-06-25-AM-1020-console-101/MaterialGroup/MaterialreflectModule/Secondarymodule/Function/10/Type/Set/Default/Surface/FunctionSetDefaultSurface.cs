using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class FunctionTen
        {
            public static String[] FunctionDefaultSetSurface(Tuple<Char, Char, Boolean>[] Tuple_ARRAY)
            {
                String[] arrayResult = default;

                var list = FunctionDefaultSet(Tuple_ARRAY);

                var array = new String[list.Count];

                list.CopyTo(array, MaterialPolicy.MaterialIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
