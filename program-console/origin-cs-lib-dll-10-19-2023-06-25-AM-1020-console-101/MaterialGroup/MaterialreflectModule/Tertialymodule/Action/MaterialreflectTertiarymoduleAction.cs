using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectTertiarymodule
    {
        public static MaterialreflectTertiarymodule MaterialreflectTertiarymoduleAction(Object Object_REFLECT, Boolean answer_RENDER_should)
        {
            MaterialreflectTertiarymodule module;

            module = MaterialreflectTertiarymoduleDefault(Object_REFLECT);

            if (answer_RENDER_should is true)
            {
                try
                {
                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{MaterialPolicy.MaterialActionPolicy}-{nameof(MaterialreflectTertiarymodule)}Action-1-Firstoneten", module.First.Function);
                    
                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{MaterialPolicy.MaterialActionPolicy}-{nameof(MaterialreflectTertiarymodule)}Action-2-Secondtwotwenty", module.Second.Function);

                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{MaterialPolicy.MaterialActionPolicy}-{nameof(MaterialreflectTertiarymodule)}Action-3-Thirdthreethirty", module.Third.Function);
                }
                catch (Exception exception)
                {
                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Fatal}-{MaterialPolicy.MaterialActionPolicy}-{nameof(MaterialreflectTertiarymodule)}", exception);
                }
            }
            else
                "false".ToString();

            return module;
        }
    }
}
