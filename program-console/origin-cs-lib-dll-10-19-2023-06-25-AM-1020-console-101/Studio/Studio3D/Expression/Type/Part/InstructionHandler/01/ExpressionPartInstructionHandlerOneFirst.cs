using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expression
    {
        public void ExpressionInstructionHandlerPartOneFirst(String Filename_VALUE, String[] LocalLine__ARRAY, Stack value_STACK, String ReflectFormat__STRING)
        {
            var array = new String[0];

            Boolean canPeekCheck;

            canPeekCheck = value_STACK.Count.Equals(0) is false;

            if (canPeekCheck is true)
            {
                var reflect = (String)(value_STACK.Peek() as Object);

                var Entity_WHITE_SPACE = Convert.ToChar(32);

                var separator = new Char[] { Entity_WHITE_SPACE };

                var split = reflect.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                var aoth = split.Length;

                var roth = (aoth - 1);

                Array.Resize(ref array, roth);

                var indexer = 0;

                do
                {
                    Boolean shouldBreakCheck;

                    shouldBreakCheck = indexer.Equals(roth) is true;

                    if (shouldBreakCheck is true)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    var Value_VALUE = split[indexer];

                    var ValueFormat__VALUE = ForgeDashlessFormat(Value_VALUE);

                    array[indexer] = ValueFormat__VALUE;

                    indexer = indexer + 1;

                    continue;

                } while (true);
            }
            else
                "false".ToString();

            ExpressionInstructionHandlerPartTwoSecond(Filename_VALUE, LocalLine__ARRAY, value_STACK, ReflectFormat__STRING, array);

            return;
        }
    }
}
