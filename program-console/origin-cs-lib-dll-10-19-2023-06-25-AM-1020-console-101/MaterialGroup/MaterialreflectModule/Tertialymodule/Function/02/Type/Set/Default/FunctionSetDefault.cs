using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial struct MaterialreflectTertiarymodule
    {
        public partial class FunctionTwenty
        {
            public static IList<Materialquery> FunctionDefaultSet(Tuple<Materialquery, SecondarymoduleFunctionSeventyPort>[] array_TUPLE)
            {
                ICollection<Materialquery> collectionResult = default;

                collectionResult = new Collection<Materialquery>();

                foreach (Tuple<Materialquery, SecondarymoduleFunctionSeventyPort> item_TUPLE in array_TUPLE)
                {
                    var Materialquery_ITEM = item_TUPLE.Item1;

                    var FunctionNinety__ITEM = item_TUPLE.Item2;

                    collectionResult.Add(Materialquery_ITEM);

                    continue;
                }

                foreach (Tuple<Materialquery, SecondarymoduleFunctionSeventyPort> item_TUPLE in array_TUPLE)
                {
                    var Materialquery_ITEM = item_TUPLE.Item1;

                    var FunctionThousandI___ITEM = item_TUPLE.Item2;

                    foreach (Tuple<Materialquery, SecondarymoduleFunctionSeventyPort> entry_TUPLE in array_TUPLE)
                    {
                        var Materialquery_ENTRY = entry_TUPLE.Item1;

                        var FunctionThousandI___ENTRY = entry_TUPLE.Item2;

                        Boolean isReferenceContiniousCheck, shouldContinueContiniousCheck;

                        isReferenceContiniousCheck = Object.ReferenceEquals(item_TUPLE, entry_TUPLE) is true;

                        shouldContinueContiniousCheck = isReferenceContiniousCheck is true;

                        if (shouldContinueContiniousCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        isReferenceContiniousCheck = Object.ReferenceEquals
(
FunctionThousandI___ITEM.Function.Function.Function,
FunctionThousandI___ENTRY.Function.Function.FunctionParent
)
is true;

                        shouldContinueContiniousCheck = isReferenceContiniousCheck is false;

                        if (shouldContinueContiniousCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        Materialquery_ENTRY.Data.Measure.Parent = Materialquery_ITEM;

                        continue;
                    }

                    continue;
                }

                foreach (Tuple<Materialquery, SecondarymoduleFunctionSeventyPort> item_TUPLE in array_TUPLE)
                {
                    var Materialquery_ITEM = item_TUPLE.Item1;

                    var FunctionThousandI___ITEM = item_TUPLE.Item2;

                    foreach (Tuple<Materialquery, SecondarymoduleFunctionSeventyPort> entry_TUPLE in array_TUPLE)
                    {
                        var Materialquery_ENTRY = entry_TUPLE.Item1;

                        var FunctionThousandI___ENTRY = entry_TUPLE.Item2;

                        Boolean isReferenceContiniousCheck, shouldContinueContiniousCheck;

                        isReferenceContiniousCheck = Object.ReferenceEquals(item_TUPLE, entry_TUPLE) is true;

                        shouldContinueContiniousCheck = isReferenceContiniousCheck is true;

                        if (shouldContinueContiniousCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        isReferenceContiniousCheck =
FunctionThousandI___ITEM.Function.Function.FunctionArray.Contains
(
FunctionThousandI___ENTRY.Function.Function.Function
)
is true;

                        shouldContinueContiniousCheck = isReferenceContiniousCheck is false;

                        if (shouldContinueContiniousCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        var aoth = Materialquery_ITEM.Data.Measure.ChildArray.Length;

                        var zee = (aoth + 1);

                        Array.Resize(ref Materialquery_ITEM.Data.Measure.ChildArray, zee);

                        var roth = (zee - 1);

                        Materialquery_ITEM.Data.Measure.ChildArray[roth] = Materialquery_ENTRY;

                        continue;
                    }

                    continue;
                }

                return new List<Materialquery>(collectionResult);
            }
        }
    }
}
