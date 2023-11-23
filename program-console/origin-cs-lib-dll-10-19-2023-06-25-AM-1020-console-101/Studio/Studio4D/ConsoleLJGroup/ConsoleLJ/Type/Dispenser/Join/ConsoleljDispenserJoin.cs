using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    using System.Collections;

    public partial class ConsoleLJ
    {
        public static ICollection ConsoleLJJoinDispenser(String[] array_SPLIT)
        {
            IList listResult = default;

            listResult = new ArrayList();

            Boolean shouldReturnCheck;

            shouldReturnCheck = ArchitectureConsoleLJOneFirst.HasEscapeCharacter is false;

            if (shouldReturnCheck is true)
            {
                goto skip;
            }
            else
                "false".ToString();

            var stack = new Stack(array_SPLIT);

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

                String stringItem;

                stringItem = reflect;

                Boolean hasLengthCheck;

                hasLengthCheck = stringItem.Equals(String.Empty) is false;

                if (hasLengthCheck is true)
                {
                    var format = stringItem.TrimEnd(ArchitectureConsoleLJOneFirst.EscapeCharacter);

                    var difference = (stringItem.Length - format.Length);

                    Boolean hasEscapeContagiousCheck;

                    hasEscapeContagiousCheck = difference.Equals(0) is false;

                    if (hasEscapeContagiousCheck)
                    {
                        Boolean hasNextContagiousCheck;

                        hasNextContagiousCheck = (stack.Count).Equals(0) is false;

                        if (hasNextContagiousCheck)
                        {
                            var whitespace = Convert.ToChar(32);

                            var concat = String.Concat(format, whitespace, stack.Pop());

                            stack.Push(concat);

                            goto bypass;
                        }
                        else
                        {
                            listResult.Add(format);

                            goto bypass;
                        }
                    }
                    else
                    {
                        listResult.Add(stringItem);

                        goto bypass;
                    }
                }
                else
                    "false".ToString();

            bypass:
                {
                    continue;
                }

            } while (true);

        skip:
            {
                return listResult;
            }
        }
    }
}
