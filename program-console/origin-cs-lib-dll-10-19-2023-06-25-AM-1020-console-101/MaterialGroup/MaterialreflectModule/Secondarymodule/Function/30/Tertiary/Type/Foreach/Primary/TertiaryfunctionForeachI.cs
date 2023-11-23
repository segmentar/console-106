using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class Tertiaryfunction
        {
            public static void TertiaryfunctionForeachI()
            {
                Position = -1;

                foreach (FunctionTwenty value_FUNCTION in new ArrayList(FunctionTwentyArrayList))
                {
                    var boolean_safe_LARGER_is = true;

                    boolean_safe_LARGER_is = boolean_safe_LARGER_is && (value_FUNCTION.Position > Position) is true;

                    boolean_safe_LARGER_is = boolean_safe_LARGER_is && value_FUNCTION.HasSymmetry is false;

                    Boolean isLargerCheck, shouldContinueCheck;

                    isLargerCheck = boolean_safe_LARGER_is is true;

                    shouldContinueCheck = isLargerCheck is false;

                    if (shouldContinueCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    Left = value_FUNCTION;

                    Position = value_FUNCTION.Position;

                    continue;
                }

                return;
            }
        }
    }
}
