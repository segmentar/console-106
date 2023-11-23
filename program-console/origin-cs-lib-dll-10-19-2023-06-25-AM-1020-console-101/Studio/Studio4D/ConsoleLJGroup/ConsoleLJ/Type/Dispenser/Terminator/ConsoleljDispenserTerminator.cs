using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    using System.Collections;
    using System.IO;

    public partial class ConsoleLJ
    {
        public static ICollection ConsoleLJTerminatorDispenser(String[] array_SPLIT)
        {
            IList listResult = default;

            listResult = new ArrayList();

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

                var format = stringItem.TrimStart(ArchitectureConsoleLJOneFirst.TerminatorCharacter);

                var difference = (stringItem.Length - format.Length);

                Boolean isTerminatorContagiousCheck;

                isTerminatorContagiousCheck = difference.Equals(0) is false;

                if (isTerminatorContagiousCheck)
                {
                    String stringEntry;

                    stringEntry = ForgePathNotation(format);

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
            }
            while (true);

            return listResult;
        }
    }
}
