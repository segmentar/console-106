using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expression
    {
        public void ExpressionInstructionHandlerPartRelease(String Filename_VALUE, String[] LocalLine__ARRAY, Stack value_STACK, String ReflectFormat__STRING, String[] Parameter_ARRAY, String Lower_ENTRY, String[] Split_ARRAY, String[] SplitTruncate_ARRAY)
        {
            switch (Lower_ENTRY)
            {
                case ExpressionConstant.InstructionRELEASE:
                    HRelease();
                    break;

                case ExpressionConstant.InstructionVRELEASE:
                    HVRelease();
                    break;

                case ExpressionConstant.InstructionBRELEASE:
                    HBRelease();
                    break;

                default:
                    break;
            }

            return;
        }
    }
}
