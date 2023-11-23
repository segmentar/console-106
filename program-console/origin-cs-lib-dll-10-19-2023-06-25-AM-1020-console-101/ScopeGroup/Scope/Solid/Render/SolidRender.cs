using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static String Render(String Path_ITEM, params Object[] array_OBJECT)
        {
            String stringResult = default;

            Boolean isDefaultCheck;

            isDefaultCheck = (array_OBJECT == default) is true;

            if (isDefaultCheck is true)
            {
                array_OBJECT = new Object[0];
            }
            else
                "false".ToString();

            var SpecialName__ITEM = RenderSpecialName(Path_ITEM);

            var split = SolidRenderSplit(SpecialName__ITEM);

            var BuildName__ITEM = SolidRenderBuildName(split, true);

            var result = BuildName__ITEM;

            stringResult = result;

            Boolean hasLengthCheck, shouldReturnCheck;

            hasLengthCheck = array_OBJECT.Length.Equals(0) is false;

            shouldReturnCheck = hasLengthCheck is false;

            if (shouldReturnCheck is true)
            {
                return stringResult;
            }
            else
                "false".ToString();

            var ordinal = 1;

            foreach (Object item_OBJECT in array_OBJECT)
            {
                Boolean isDefaultContagentCheck;

                isDefaultContagentCheck = (item_OBJECT == default) is true;

                String stringReflect;

                if (isDefaultContagentCheck)
                {
                    stringReflect = SolidRenderErrorMessage();
                }
                else
                {
                    stringReflect = item_OBJECT.ToString();
                }

                var name = SolidRenderFileName(split, ordinal);

                var path_FILENAME_with_extension = SolidRenderFile(BuildName__ITEM, name, stringReflect, true);

                ordinal = ordinal + 1;

                continue;
            }

            return stringResult;
        }
    }
}
