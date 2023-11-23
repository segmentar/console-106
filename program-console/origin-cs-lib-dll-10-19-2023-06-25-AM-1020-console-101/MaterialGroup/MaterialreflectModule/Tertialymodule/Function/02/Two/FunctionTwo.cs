using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectTertiarymodule
    {
        public static MaterialreflectTertiarymodule FunctionTwo(MaterialreflectTertiarymodule module)
        {
            var array = FunctionTwenty.FunctionDefaultSetSurface(module.First.Function.TupleArray);

            var function = new FunctionTwenty(array);

            FunctionSecond second;

            second = new FunctionSecond(function);

            module.Second = second;

            return module;
        }
    }
}
