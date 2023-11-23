using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    using System.Collections;

    public partial class ConsoleLJ
    {
        public static ICollection ConsoleLJPortalDispenser(String[] array_SPLIT, Tuple<String, Object>[] array__NAME_VALUE)
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

                var format = stringItem.TrimStart(ArchitectureConsoleLJOneFirst.EscapeCharacter);

                var difference = (stringItem.Length - format.Length);

                Boolean isPortalContagiousCheck;

                isPortalContagiousCheck = difference.Equals(0) is false;
                
                if (isPortalContagiousCheck)
                {
                    String stringEntry;

                    stringEntry = format;

                    foreach (Tuple<String, Object> tuple in array__NAME_VALUE)
                    {
                        String name;

                        Object value;

                        name = tuple.Item1;

                        value = tuple.Item2;

                        Boolean isItCheck;

                        isItCheck = format.Equals(name) is true;

                        if (isItCheck is true)
                        {
                            var concat = String.Concat(ArchitectureConsoleLJOneFirst.TerminatorCharacter, value.ToString());

                            stringEntry = concat;
                        }
                        else
                            "false".ToString();

                        continue;
                    }

                    listResult.Add(stringEntry);

                    goto bypass;
                }
                else
                {
                    listResult.Add(stringItem);

                    goto bypass;
                }

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
