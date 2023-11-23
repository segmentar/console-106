using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        public static MaterialreflectSecondarymodule MaterialreflectSecondarymoduleAction(Object Object_REFLECT, Boolean answer_RENDER_should)
        {
            MaterialreflectSecondarymodule module;

            module = MaterialreflectSecondarymoduleDefault(Object_REFLECT);

            if (answer_RENDER_should is true)
            {
                try
                {
                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{MaterialPolicy.MaterialActionPolicy}-{nameof(MaterialreflectSecondarymodule)}Action-1-Firstoneten", module.First.Function);

                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{MaterialPolicy.MaterialActionPolicy}-{nameof(MaterialreflectSecondarymodule)}Action-2-Secondtwotwenty", String.Join('\n'.ToString(), (Object[])(module.Second.FunctionArray as Array)));

                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{MaterialPolicy.MaterialActionPolicy}-{nameof(MaterialreflectSecondarymodule)}Action-3-Sixthsixsixty", String.Join('\n'.ToString(), (Object[])(module.Third.FunctionArray as Array)));
                    
                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{MaterialPolicy.MaterialActionPolicy}-{nameof(MaterialreflectSecondarymodule)}Action-4-Fourthfourfourty", String.Join('\n'.ToString(), (Object[])(module.Fourth.FunctionArray as Array)));
                    
                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{MaterialPolicy.MaterialActionPolicy}-{nameof(MaterialreflectSecondarymodule)}Action-5-Fifthfivefifty", String.Join('\n'.ToString(), (Object[])(module.Fifth.FunctionArray as Array)));
                    
                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{MaterialPolicy.MaterialActionPolicy}-{nameof(MaterialreflectSecondarymodule)}Action-6-Sixthsixsixty", String.Join('\n'.ToString(), (Object[])(module.Sixth.FunctionArray as Array)));

                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{MaterialPolicy.MaterialActionPolicy}-{nameof(MaterialreflectSecondarymodule)}Action-7-Seventhsevenseventy", module.Seventh.Function);

                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{MaterialPolicy.MaterialActionPolicy}-{nameof(MaterialreflectSecondarymodule)}Action-8-Eightheighteighty", module.Eighth.Function);
                    /*
                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{nameof(MaterialreflectModule)}Action-III-Hundredthhundredthousand", module.HundredthIII.Function);

                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{nameof(MaterialreflectModule)}Action-IV-Hundredthhundredthousand", module.HundredthIV.Function);

                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{nameof(MaterialreflectModule)}Action-V-Hundredthhundredthousand", module.HundredthV.Function);*/
                }
                catch (Exception exception)
                {
                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Fatal}-{MaterialPolicy.MaterialActionPolicy}-{nameof(MaterialreflectSecondarymodule)}", exception);
                }
            }
            else
                "false".ToString();

            return module;
        }
    }
}
