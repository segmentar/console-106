using Core;

namespace Core
{
    using System;

    internal partial class Material
    {
        internal static void Render(String Path_VALUE, params Object[] array_OBJECT)
        {
            Boolean hasLengthCheck, shouldReturnCheck;

            hasLengthCheck = array_OBJECT.Length.Equals(0) is false;

            shouldReturnCheck = hasLengthCheck is false;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            var SpecialName__VALUE = RenderSpecialName(Path_VALUE);

            var split = SolidRenderSplit(SpecialName__VALUE);

            var BuildName__VALUE = SolidRenderBuildName(split, true);

            var ordinal = 1;

            foreach (Object value_OBJECT in array_OBJECT)
            {
                Boolean isDefaultContagentCheck;

                isDefaultContagentCheck = (value_OBJECT == default) is true;

                String stringReflect;

                if (isDefaultContagentCheck)
                {
                    stringReflect = SolidRenderErrorMessage();
                }
                else
                {
                    stringReflect = value_OBJECT.ToString();
                }

                var FileName__VALUE = SolidRenderFileName(split, ordinal);

                var path_FILENAME_with_extension = SolidRenderFile(BuildName__VALUE, FileName__VALUE, stringReflect, true);

                ordinal = ordinal + 1;

                continue;
            }

            return;
        }
    }
}
