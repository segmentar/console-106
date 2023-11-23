using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class Tertiaryfunction
        {
            public static void TertiaryForeachIII()
            {
                Layer = 1;

                foreach (FunctionTwenty FunctionFifty__VALUE in FunctionTwentyArrayList)
                {
                    var boolean_safe_EQUAL_is = true;

                    boolean_safe_EQUAL_is = boolean_safe_EQUAL_is && ReferenceEquals(FunctionFifty__VALUE, Right) is false;

                    boolean_safe_EQUAL_is = boolean_safe_EQUAL_is && (FunctionFifty__VALUE.Position > Right.Position) is true;

                    boolean_safe_EQUAL_is = boolean_safe_EQUAL_is && FunctionFifty__VALUE.Character.Equals(Right.Character) is true;

                    Boolean shouldContinueCheck;

                    shouldContinueCheck = boolean_safe_EQUAL_is is false;

                    if (shouldContinueCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    Layer = Layer + 1;

                    continue;
                }

                return;
            }
        }
    }
}