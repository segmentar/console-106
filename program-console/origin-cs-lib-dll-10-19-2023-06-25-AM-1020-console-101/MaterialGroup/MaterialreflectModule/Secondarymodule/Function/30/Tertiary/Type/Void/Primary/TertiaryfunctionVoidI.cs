using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class Tertiaryfunction
        {
            public static void TertiaryfunctionVoidI(String value_STRING, FunctionTwenty[] array_FUNCTION)
            {
                InputString = value_STRING;

                FunctionTwentyArray = array_FUNCTION;

                FunctionTwentyArrayList = new ArrayList(array_FUNCTION);

                FunctionThirtyArrayList = new ArrayList();

                TertiaryfunctionDefaultDo();

                var array = FunctionThirtyArrayList.ToArray(typeof(FunctionThirty));

                var reflect = (FunctionThirty[])(array as Array);

                FunctionThirtyArray = reflect;

                return;
            }
        }
    }
}
