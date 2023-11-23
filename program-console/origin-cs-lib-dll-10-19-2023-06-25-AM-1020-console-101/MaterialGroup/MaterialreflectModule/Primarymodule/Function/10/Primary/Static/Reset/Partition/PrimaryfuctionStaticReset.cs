using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectPrimarymodule
    {
        public partial class Primaryfunction
        {
            public static FunctionPrimary Reset(String InputString__VALUE, Char[] EscapeCharacter__ARRAY)
            {
                FunctionPrimary functionPrimaryResult = default;

                var tuple = ForgeTupleArray(InputString__VALUE, EscapeCharacter__ARRAY);

                FunctionPrimary functionPrimary;

                functionPrimary = new FunctionPrimary(tuple);

                functionPrimaryResult = functionPrimary;

                return functionPrimaryResult;
            }
        }
    }
}
