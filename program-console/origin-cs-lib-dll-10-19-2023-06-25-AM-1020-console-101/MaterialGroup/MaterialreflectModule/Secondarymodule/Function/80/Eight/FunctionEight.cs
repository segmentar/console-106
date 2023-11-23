using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        public static MaterialreflectSecondarymodule FunctionEight(MaterialreflectSecondarymodule module)
        {
            var array = FunctionEighty.FunctionDefaultSetSurface(module.Seventh.Function.FunctionArray);

            var function = new FunctionEighty(array);

            FunctionEighth eighth;

            eighth = new FunctionEighth(function);

            module.Eighth = eighth;

            return module;
        }
    }
}
