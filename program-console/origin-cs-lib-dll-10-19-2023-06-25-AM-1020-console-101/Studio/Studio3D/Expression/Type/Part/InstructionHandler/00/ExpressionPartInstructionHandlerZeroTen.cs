using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expression
    {
        public void ExpressionInstructionHandlerPartZeroTen(String Filename_VALUE, String[] LocalLine__ARRAY)
        {
            var stack = new Stack(LocalLine__ARRAY);

            stack = new Stack(stack);

            do
            {
                Boolean shouldBreakCheck;

                shouldBreakCheck = stack.Count.Equals(0) is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                var reflect = (String)(stack.Pop() as Object);

                var Entity_WHITE_SPACE = Convert.ToChar(32);

                var separator = new Char[] { Entity_WHITE_SPACE };

                var split = reflect.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                var aoth = split.Length;

                var roth = (aoth - 1);

                var array = new String[roth];

                Array.Copy(split, 0, array, 0, roth);

                var join = String.Join(Entity_WHITE_SPACE.ToString(), array);

                ExpressionInstructionHandlerPartOneFirst(Filename_VALUE, LocalLine__ARRAY, stack, join);

                continue;

            } while (true);

            return;
        }
    }
}
