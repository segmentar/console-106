using Core;

namespace Core
{
    using System;

    internal partial class Material
    {
        static Material()
        {
            return;
        }

        public static void Procedure()
        {
            MaterialPolicy.MaterialDebugPolicy = true;

            MaterialPolicy.MaterialInfoPolicy = true;

            return;
        }

        public static void Manual(MaterialStringSplitcharacter HeaderSplitcharacter__VALUE, String BodySubstring__VALUE, out MaterialModule MaterialModule__VALUE)
        {
            MaterialPolicy.MaterialActionPolicy = MaterialPolicy.MaterialActionPolicy + 1;

            var material = MakeMaterialDefaultSurface(HeaderSplitcharacter__VALUE, BodySubstring__VALUE);

            MaterialModule materialModule = MaterialModule.MaterialModuleAction(material, true);

            Array.Resize(ref material.EscapeCharacterArray, materialModule.Third.Function.CharacterArray.Length);

            materialModule.Third.Function.CharacterArray.CopyTo(material.EscapeCharacterArray, MaterialPolicy.MaterialIndexPolicy);

            var FooterSubstringFormat___VALUE = MaterialStringFormat.Simple(material.FooterSubstring.StringValue);

            Materialreflect materialreflect;

            Materialreflect.Manual(material, FooterSubstringFormat___VALUE, material.EscapeCharacterArray, out materialreflect);

            Scope.AddMaterial(materialreflect.Materialchain);

            MaterialModule__VALUE = materialModule;

            return;
        }

        public static void Raise()
        {
            if (MaterialPolicy.MaterialInfoPolicy is true)
            {
                Render($"{MaterialCode.RenderPath.Core_Material_Info}-{nameof(Material)}Info", MaterialPolicy.MaterialArrayList.ToArray());
            }
            else
                "false".ToString();

            return;
        }

        public static void Bundle(MaterialStringSplitcharacter HeaderSplitcharacter__VALUE, String BodySubstring__VALUE, out MaterialModule MaterialModule__VALUE)
        {
            Procedure();

            Manual(HeaderSplitcharacter__VALUE, BodySubstring__VALUE, out MaterialModule__VALUE);

            Raise();

            return;
        }
    }
}
