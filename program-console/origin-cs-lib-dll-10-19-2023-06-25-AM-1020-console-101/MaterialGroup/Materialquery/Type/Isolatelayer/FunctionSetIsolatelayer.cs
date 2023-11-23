using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Materialquery
    {
        public static IList<Materialquery> FunctionIsolatelayerSet(Materialquery[] Materialquery_ARRAY, Int32 Isolate_INTEGER)
        {
            ICollection<Materialquery> collectionResult = default;

            collectionResult = new Collection<Materialquery>();

            foreach (Materialquery Materialquery_VALUE in Materialquery_ARRAY)
            {
                Boolean isMatchCheck, shouldContinueCheck;

                isMatchCheck = Materialquery_VALUE.Data.Layer.Equals(Isolate_INTEGER) is true;

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

            return new List<Materialquery>(collectionResult);
        }
    }
}

