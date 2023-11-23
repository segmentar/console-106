using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        public static MaterialreflectSecondarymodule FunctionTwo(MaterialreflectSecondarymodule module)
        {
            var array = FunctionTwenty.FunctionDefaultSetSurface(module.Materialreflect.OutputString, module.First.Function.TupleArray);

            FunctionSecond second;

            second = new FunctionSecond(array);

            module.Second = second;
            
            return module;
        }
    }
}
