using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectPrimarymodule
    {
        public static MaterialreflectPrimarymodule MaterialreflectModuleDefault(Object Object_REFLECT)
        {
            var reflect = (Materialreflect)(Object_REFLECT as Object);

            MaterialreflectPrimarymodule module;

            module = new MaterialreflectPrimarymodule();

            try
            {
                module.Materialreflect = reflect;

                module.Primary = Primaryfunction.Reset(module.Materialreflect.InputString.StringValue, module.Materialreflect.EscapeCharacterArray.CharacterArray);

                module = FunctionOne(module);

                module = FunctionTwo(module);

                module = FunctionThree(module);

                module.Materialreflect.OutputString = module.First.Function.StringResult.StringValue;

                module.Materialreflect.PrimarymoduleFunctionThirtyPort = new PrimarymoduleFunctionThirtyPort(module.Third.Function.TupleArray);

            } catch (Exception exception)
            {
                Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Fatal}-{nameof(MaterialreflectPrimarymodule)}", exception);
            }

            return module;
        }
    }
}
