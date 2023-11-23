using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expression
    {
        public void ExpressionInstructionHandlerPartTwoSecond(String Filename_VALUE, String[] LocalLine__ARRAY, Stack value_STACK, String ReflectFormat__STRING, String[] Parameter_ARRAY)
        {
            var Entity_WHITE_SPACE = Convert.ToChar(32);

            var separator = new String[] { Entity_WHITE_SPACE.ToString() };

            var split = ReflectFormat__STRING.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            var oth = split[0];

            var lower = oth.ToLower();

            var aoth = split.Length;

            var roth = (aoth - 1);

            var array = new String[roth];

            Array.Copy(split, 1, array, 0, roth);

            ExpressionInstructionHandlerPartLock(Filename_VALUE, LocalLine__ARRAY, value_STACK, ReflectFormat__STRING, Parameter_ARRAY, lower, split, array);

            ExpressionInstructionHandlerPartUnlock(Filename_VALUE, LocalLine__ARRAY, value_STACK, ReflectFormat__STRING, Parameter_ARRAY, lower, split, array);

            ExpressionInstructionHandlerPartRelease(Filename_VALUE, LocalLine__ARRAY, value_STACK, ReflectFormat__STRING, Parameter_ARRAY, lower, split, array);

            ExpressionInstructionHandlerPartView(Filename_VALUE, LocalLine__ARRAY, value_STACK, ReflectFormat__STRING, Parameter_ARRAY, lower, split, array);

            ExpressionInstructionHandlerPartBind(Filename_VALUE, LocalLine__ARRAY, value_STACK, ReflectFormat__STRING, Parameter_ARRAY, lower, split, array);

            ExpressionInstructionHandlerPartBrute(Filename_VALUE, LocalLine__ARRAY, value_STACK, ReflectFormat__STRING, Parameter_ARRAY, lower, split, array);

            ExpressionInstructionHandlerPartOperation(Filename_VALUE, LocalLine__ARRAY, value_STACK, ReflectFormat__STRING, Parameter_ARRAY, lower, split, array);

            return;
        }
    }
}
