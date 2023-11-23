using Core;

namespace Core
{
    using System;

    public partial struct MaterialModule
    {
        public static MaterialModule MaterialModuleAction(Object Object_REFLECT, Boolean answer_RENDER_should)
        {
            MaterialModule module;

            module = MaterialModuleDefault(Object_REFLECT);

            if (answer_RENDER_should is true)
            {
                try
                {
                    Material.Render($"{MaterialCode.RenderPath.Core_Material_Action}-{MaterialPolicy.MaterialActionPolicy}-{nameof(MaterialModule)}Action-OnefirsttenprimaryI", module.First.Function);

                    Material.Render($"{MaterialCode.RenderPath.Core_Material_Action}-{MaterialPolicy.MaterialActionPolicy}-{nameof(MaterialModule)}Action-TwosecondtwentysecondaryII", module.Second.Function);

                    Material.Render($"{MaterialCode.RenderPath.Core_Material_Action}-{MaterialPolicy.MaterialActionPolicy}-{nameof(MaterialModule)}Action-ThreethirdthirtytertiaryIII", module.Third.Function);

                } catch (Exception exception)
                {
                    Material.Render($"{MaterialCode.RenderPath.Core_Material_Fatal}-{MaterialPolicy.MaterialActionPolicy}-{nameof(MaterialModule)}Fatal", exception);
                }
            }
            else
                "false".ToString();

            return module;
        }
    }
}
