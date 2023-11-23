using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expression
    {
        public void ExpressionInstructionHandlerPartBind(String Filename_VALUE, String[] LocalLine__ARRAY, Stack value_STACK, String ReflectFormat__STRING, String[] Parameter_ARRAY, String Lower_ENTRY, String[] Split_ARRAY, String[] SplitTruncate_ARRAY)
        {
            switch (Lower_ENTRY)
            {
                case ExpressionConstant.InstructionBIND:
                    HBind(Split_ARRAY);
                    break;

                case ExpressionConstant.InstructionBINDINT32:
                    HBindInt32(Split_ARRAY);
                    break;

                default:
                    break;
            }

            return;
        }
    }
}
