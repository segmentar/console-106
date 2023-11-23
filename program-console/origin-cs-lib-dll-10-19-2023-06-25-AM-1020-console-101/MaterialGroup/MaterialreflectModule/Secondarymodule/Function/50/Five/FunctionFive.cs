using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        public static MaterialreflectSecondarymodule FunctionFive(MaterialreflectSecondarymodule module)
        {
            FunctionFifth fifth;

            var array = FunctionFifty.FunctionDefaultSetSurface(module.Materialreflect.InputString.StringValue, module.Fourth.FunctionArray);

            fifth = new FunctionFifth(array);

            module.Fifth = fifth;

            return module;
        }
    }
}
