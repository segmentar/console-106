namespace Core
{
    using System;

    public partial class Virtualsolid
    {
        public static void Render(String Path_VALUE, params Object[] array_OBJECT)
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

                var path_FILENAME_with_extension = SolidRenderFile(BuildName__VALUE, name, stringReflect, true);

                ordinal = ordinal + 1;

                continue;
            }

            return;
        }
    }
}
