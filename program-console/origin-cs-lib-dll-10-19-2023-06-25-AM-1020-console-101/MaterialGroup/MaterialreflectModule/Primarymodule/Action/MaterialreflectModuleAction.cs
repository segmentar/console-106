using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectPrimarymodule
    {
        public static MaterialreflectPrimarymodule MaterialreflectModuleAction(Object Object_REFLECT, Boolean answer_RENDER_should)
        {
            MaterialreflectPrimarymodule module;

            module = MaterialreflectModuleDefault(Object_REFLECT);

            if (answer_RENDER_should is true)
            {
                try
                {
                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{MaterialPolicy.MaterialActionPolicy}-{nameof(MaterialreflectPrimarymodule)}Action-1-Firstoneten", module.First.Function);

                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{MaterialPolicy.MaterialActionPolicy}-{nameof(MaterialreflectPrimarymodule)}Action-2-Secondtwotwenty", module.Second.Function);

                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{MaterialPolicy.MaterialActionPolicy}-{nameof(MaterialreflectPrimarymodule)}Action-3-Thirdthreethirty", module.Third.Function);

                    /*Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{nameof(MaterialreflectPrimarymodule)}Action-4-Fourthfourfourty", module.Fourth.Function);

                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{nameof(MaterialreflectPrimarymodule)}Action-5-Fifthfivefifth", String.Join('\n'.ToString(), (Object[])(module.Fifth.FunctionArray as Array)));

                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{nameof(MaterialreflectPrimarymodule)}Action-6-Sixthsixsixty", String.Join('\n'.ToString(), (Object[])(module.Sixth.FunctionArray as Array)));

                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{nameof(MaterialreflectPrimarymodule)}Action-7-Seventhsevenseventy", String.Join('\n'.ToString(), (Object[])(module.Seventh.FunctionArray as Array)));

                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{nameof(MaterialreflectPrimarymodule)}Action-8-EighthEightEighty", String.Join('\n'.ToString(), (Object[])(module.Eighth.FunctionArray as Array)));

                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{nameof(MaterialreflectPrimarymodule)}Action-9-NinthNineNinety", String.Join('\n'.ToString(), (Object[])(module.Ninth.FunctionArray as Array)));

                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{nameof(MaterialreflectPrimarymodule)}Action-I-Hundredthhundredthousand", String.Join('\n'.ToString(), (Object[])(module.HundredthI.FunctionArray as Array)));

                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{nameof(MaterialreflectPrimarymodule)}Action-II-Hundredthhundredthousand", String.Join('\n'.ToString(), (Object[])(module.HundredthII.FunctionArray as Array)));
                    
                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{nameof(MaterialreflectPrimarymodule)}Action-III-Hundredthhundredthousand", module.HundredthIII.Function);

                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{nameof(MaterialreflectPrimarymodule)}Action-IV-Hundredthhundredthousand", module.HundredthIV.Function);

                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Action}-{nameof(MaterialreflectPrimarymodule)}Action-V-Hundredthhundredthousand", module.HundredthV.Function);*/
                }
                catch (Exception exception)
                {
                    Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Fatal}-{MaterialPolicy.MaterialActionPolicy}-{nameof(MaterialreflectPrimarymodule)}", exception);
                }
            }
            else
                "false".ToString();

            return module;
        }
    }
}
