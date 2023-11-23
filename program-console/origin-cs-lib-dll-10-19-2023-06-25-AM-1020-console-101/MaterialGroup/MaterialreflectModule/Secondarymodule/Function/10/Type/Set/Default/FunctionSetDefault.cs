using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class FunctionTen
        {
            public static IList<String> FunctionDefaultSet(Tuple<Char, Char, Boolean>[] array_TUPLE)
            {
                ICollection<String> collectionResult = default;

                collectionResult = new Collection<String>();

                foreach (Tuple<Char, Char, Boolean> value_TUPLE in array_TUPLE)
                {
                    var value_ITEM = value_TUPLE.Item2;

                    var value_ENTRY = value_ITEM.ToString();

                    collectionResult.Add(value_ENTRY);

                    continue;
                }

                return new List<String>(collectionResult);
            }
        }
    }
}
