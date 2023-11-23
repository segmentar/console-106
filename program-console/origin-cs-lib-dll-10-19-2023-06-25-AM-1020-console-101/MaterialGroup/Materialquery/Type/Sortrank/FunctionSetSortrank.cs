using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Materialquery
    {
        public static IList<Materialquery> FunctionSortrankSet(Materialquery[] Materialquery_ARRAY)
        {
            ICollection<Materialquery> collectionResult = default;

            collectionResult = new Collection<Materialquery>();

            var LargestRank = -1;

            foreach (Materialquery Materialquery_VALUE in Materialquery_ARRAY)
            {
                Boolean isLargerCheck, shouldContinueCheck;

                isLargerCheck = (Materialquery_VALUE.Data.Rank > LargestRank) is true;

                shouldContinueCheck = isLargerCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                LargestRank = Materialquery_VALUE.Data.Rank;

                continue;
            }

            do
            {
                Boolean shouldBreakCheck;

                shouldBreakCheck = LargestRank.Equals(-1) is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                foreach (Materialquery Materialquery_VALUE in Materialquery_ARRAY)
                {
                    Boolean isMatchCheck, shouldContinueCheck;

                    isMatchCheck = Materialquery_VALUE.Data.Rank.Equals(LargestRank) is true;

                    shouldContinueCheck = isMatchCheck is false;

                    if (shouldContinueCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    collectionResult.Add(Materialquery_VALUE);

                    continue;
                }

                LargestRank = LargestRank - 1;

                continue;

            } while (true);

            return new List<Materialquery>(collectionResult);
        }
    }
}

