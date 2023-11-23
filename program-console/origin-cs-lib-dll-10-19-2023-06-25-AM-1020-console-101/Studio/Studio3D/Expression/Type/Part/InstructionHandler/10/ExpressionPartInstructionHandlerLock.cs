using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expression
    {
        public void ExpressionInstructionHandlerPartLock(String Filename_VALUE, String[] LocalLine__ARRAY, Stack value_STACK, String ReflectFormat__STRING, String[] Parameter_ARRAY, String Lower_ENTRY, String[] Split_ARRAY, String[] SplitTruncate__ARRAY)
        {
            switch (Lower_ENTRY)
            {
                case ExpressionConstant.InstructionLOCK:
                    HLock(Filename_VALUE, SplitTruncate__ARRAY);
                    break;

                case ExpressionConstant.InstructionVLOCK:
                    HVLock(Filename_VALUE, SplitTruncate__ARRAY);
                    break;

                case ExpressionConstant.InstructionULOCK:
                    HULock(Filename_VALUE, SplitTruncate__ARRAY);
                    break;

                case ExpressionConstant.InstructionVULOCK:
                    HVULock(Filename_VALUE, SplitTruncate__ARRAY);
                    break;

                default:
                    break;
            }

            return;
        }
    }
}
