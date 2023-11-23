using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        public static MaterialreflectSecondarymodule FunctionThree(MaterialreflectSecondarymodule module)
        {
            FunctionThird third;

            third = new FunctionThird(module.Tertiary.FunctionArray);

            module.Third = third;

            return module;
        }
    }
}
