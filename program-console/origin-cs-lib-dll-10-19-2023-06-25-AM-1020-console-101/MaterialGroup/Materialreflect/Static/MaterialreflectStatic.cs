using Core;

namespace Core
{
    using System;

    internal partial class Materialreflect
    {
        static Materialreflect()
        {
            return;
        }

        public static void Procedure()
        {
            MaterialreflectPolicy.MaterialreflectDebugPolicy = true;

            MaterialreflectPolicy.MaterialreflectInfoPolicy = true;
            
            return;
        }

        public static void Manual(Material Material_VALUE, MaterialStringFormat StringFormat__VALUE, Char[] EscapeCharacter__ARRAY, out Materialreflect Materialreflect_VALUE)
        {
            var materialreflect = MakeMaterialreflectDefaultSurface(Material_VALUE, StringFormat__VALUE, EscapeCharacter__ARRAY);

            MaterialreflectPrimarymodule materialreflectModule = MaterialreflectPrimarymodule.MaterialreflectModuleAction(materialreflect, true);

            MaterialreflectSecondarymodule materialreflectSecondarymodule = MaterialreflectSecondarymodule.MaterialreflectSecondarymoduleAction(materialreflect, true);

            MaterialreflectTertiarymodule materialreflectTertiarymodule = MaterialreflectTertiarymodule.MaterialreflectTertiarymoduleAction(materialreflect, true);

            Materialreflect_VALUE = materialreflect;

            return;
        }

        public static void Raise()
        {
            if (MaterialreflectPolicy.MaterialreflectInfoPolicy is true)
            {
                Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Info}-{nameof(Materialreflect)}Info", MaterialreflectPolicy.MaterialreflectArrayList.ToArray());
            }
            else
                "false".ToString();

            return;
        }

        public static void Bundle(Material Material_VALUE, MaterialStringFormat StringFormat__VALUE, Char[] EscapeCharacter__ARRAY, out Materialreflect Materialreflect_VALUE)
        {
            Procedure();

            Manual(Material_VALUE, StringFormat__VALUE, EscapeCharacter__ARRAY, out Materialreflect_VALUE);

            Raise();

            return;
        }
    }
}
