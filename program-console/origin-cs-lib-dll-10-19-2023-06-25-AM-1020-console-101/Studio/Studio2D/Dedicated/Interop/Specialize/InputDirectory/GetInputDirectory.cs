using Core;

namespace Core.DimensionTwoSecondSecondaryII.Interop
{
    using System;

    public partial class InteropSpecialize
    {
        public static String GetInputDirectory()
        {
            String stringResult = default;

            var boolean_safe_RETURN_should = false;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should || InteropArchitecture.HasInputDirectory is false;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should || InteropArchitecture.HasValidInputDirectory is false;

            Boolean shouldReturnCheck;

            shouldReturnCheck = boolean_safe_RETURN_should is true;

            if (shouldReturnCheck is true)
            {
                return stringResult;
            }
            else
                "false".ToString();

            var result = InteropArchitecture.InputDirectory;

            stringResult = result;

            return stringResult;
        }
    }
}
