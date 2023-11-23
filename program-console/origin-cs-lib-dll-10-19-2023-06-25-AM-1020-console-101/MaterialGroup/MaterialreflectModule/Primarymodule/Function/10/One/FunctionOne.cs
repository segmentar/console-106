using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectPrimarymodule
    {
        public static MaterialreflectPrimarymodule FunctionOne(MaterialreflectPrimarymodule module)
        {
            var StringResult__VALUE = module.Primary.Tuple.Item1;

            var Dictionary_ARRAY = module.Primary.Tuple.Item2;

            var StringResultSafe___VALUE = MaterialStringSafe.Simple(StringResult__VALUE);

            var function = new FunctionTen(StringResultSafe___VALUE, Dictionary_ARRAY);

            FunctionFirst first;

            first = new FunctionFirst(function);

            module.First = first;

            return module;
        }
    }
}
