using Core;

namespace Core.DimensionTwoSecondSecondaryII.Interop
{
    using System;

    public partial class InteropSpecialize
    {
        public static String GetOutputDirectory()
        {
            String stringResult = default;

            var boolean_safe_RETURN_should = false;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should || InteropArchitecture.HasOutputDirectory is false;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should || InteropArchitecture.HasValidOutputDirectory is false;

            Boolean shouldReturnCheck;

            shouldReturnCheck = boolean_safe_RETURN_should is true;

            if (shouldReturnCheck is true)
            {
                return stringResult;
            }
            else
                "false".ToString();

            var result = InteropArchitecture.OutputDirectory;

            stringResult = result;

            return stringResult;
        }
    }
}
