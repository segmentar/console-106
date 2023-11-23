using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        public static MaterialreflectSecondarymodule FunctionFour(MaterialreflectSecondarymodule module)
        {
            var array = FunctionFourty.FunctionDefaultSetSurface(module.Third.FunctionArray);
           
            FunctionFourth fourth;

            fourth = new FunctionFourth(array);

            module.Fourth = fourth;

            return module;
        }
    }
}
