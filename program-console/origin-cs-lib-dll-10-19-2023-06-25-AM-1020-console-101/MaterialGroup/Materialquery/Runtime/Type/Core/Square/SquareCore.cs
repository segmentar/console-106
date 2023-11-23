using Core;

namespace Core
{
    using System;

    public partial struct MaterialqueryRuntime
    {
        public Boolean SquareRuntimeCore(Char Character_LEFT, Char Character_RIGHT)
        {
            Boolean booleanResult = default;

            var boolean_safe_EQUAL_is = true;

            boolean_safe_EQUAL_is = boolean_safe_EQUAL_is && (Character_LEFT == MaterialSymmetry.EntitySquareBracketLeft) is true;

            boolean_safe_EQUAL_is = boolean_safe_EQUAL_is && (Character_RIGHT == MaterialSymmetry.EntitySquareBracketRight) is true;

            if (boolean_safe_EQUAL_is)
            {
                Boolean boolean;

                boolean = true;

                booleanResult = boolean;
            }
            else
                "false".ToString();

            return booleanResult;
        }
    }
}
