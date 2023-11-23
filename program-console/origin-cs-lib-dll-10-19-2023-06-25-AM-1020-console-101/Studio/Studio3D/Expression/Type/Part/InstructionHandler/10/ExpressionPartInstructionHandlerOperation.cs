using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expression
    {
        public void ExpressionInstructionHandlerPartOperation(String Filename_VALUE, String[] LocalLine__ARRAY, Stack value_STACK, String ReflectFormat__STRING, String[] Parameter_ARRAY, String Lower_ENTRY, String[] Split_ARRAY, String[] SplitTruncate_ARRAY)
        {
            switch (Lower_ENTRY)
            {
                case ExpressionConstant.InstructionOPERATION:
                    HOperation(Filename_VALUE, value_STACK, Parameter_ARRAY, Split_ARRAY, SplitTruncate_ARRAY);
                    break;

                case ExpressionConstant.InstructionVOPERATION:
                    HVOperation(Filename_VALUE, value_STACK, Parameter_ARRAY, Split_ARRAY, SplitTruncate_ARRAY);
                    break;

                case ExpressionConstant.InstructionSOPERATION:
                    HSOperation(Filename_VALUE, value_STACK, Parameter_ARRAY, Split_ARRAY, SplitTruncate_ARRAY);
                    break;

                case ExpressionConstant.InstructionVSOPERATION:
                    HVSOperation(Filename_VALUE, value_STACK, Parameter_ARRAY, Split_ARRAY, SplitTruncate_ARRAY);
                    break;

                default:
                    break;
            }

            return;
        }
    }
}
