using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectTertiarymodule
    {
        public static MaterialreflectTertiarymodule MaterialreflectTertiarymoduleDefault(Object Object_REFLECT)
        {
            var reflect = (Materialreflect)(Object_REFLECT as Object);

            MaterialreflectTertiarymodule module;

            module = new MaterialreflectTertiarymodule();

            try
            {
                module.Materialreflect = reflect;

                module = FunctionOne(module);

                module = FunctionTwo(module);

                module = FunctionThree(module);

                reflect.Materialchain = module.Third.Function.Materialchain;

            } catch (Exception exception)
            {
                Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Fatal}-{nameof(MaterialreflectTertiarymodule)}", exception);
            }

            return module;
        }
    }
}
