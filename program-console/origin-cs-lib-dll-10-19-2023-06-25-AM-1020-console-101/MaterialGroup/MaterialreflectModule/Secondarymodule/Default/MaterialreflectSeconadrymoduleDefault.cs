using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        public static MaterialreflectSecondarymodule MaterialreflectSecondarymoduleDefault(Object Object_REFLECT)
        {
            var reflect = (Materialreflect)(Object_REFLECT as Object);

            MaterialreflectSecondarymodule module;

            module = new MaterialreflectSecondarymodule();

            try
            {
                module.Materialreflect = reflect;

                module = FunctionOne(module);

                module = FunctionTwo(module);

                module.Tertiary = Tertiaryfunction.Reset(module.Materialreflect.InputString.StringValue, module.Second.FunctionArray);

                module = FunctionThree(module);

                module = FunctionFour(module);

                module = FunctionFive(module);

                module = FunctionSix(module);

                module = FunctionSeven(module);

                module = FunctionEight(module);

                module.Materialreflect.SecondarymoduleFunctionSeventyPortArray = module.Seventh.Function.FunctionArray;

                module.Materialreflect.SecondarymoduleFunctionEightyPortArray = module.Eighth.Function.FunctionArray;

            } catch (Exception exception)
            {
                Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Fatal}-{nameof(MaterialreflectSecondarymodule)}", exception);
            }

            return module;
        }
    }
}
