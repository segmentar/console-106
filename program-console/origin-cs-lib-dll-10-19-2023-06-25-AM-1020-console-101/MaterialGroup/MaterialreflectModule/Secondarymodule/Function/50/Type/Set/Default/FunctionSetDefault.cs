using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class FunctionFifty
        {
            public static IList<FunctionFifty> FunctionDefaultSet(String item_STRING, FunctionFourty[] array_FUNCTION)
            {
                ICollection<FunctionFifty> collectionResult = default;

                collectionResult = new Collection<FunctionFifty>();

                var array = FunctionLayerContainerSurface<Tuple<FunctionFourty[], FunctionFourty[]>>(array_FUNCTION);

                foreach (var tuple in array)
                {
                    FunctionFourty[] functionArrayPrevious, functionArrayNext;

                    functionArrayPrevious = tuple.Item1;

                    functionArrayNext = tuple.Item2;

                    foreach (var item_FUNCTION in functionArrayPrevious)
                    {
                        var item_entry__FUNCTION = new FunctionFifty();

                        item_entry__FUNCTION.Function = item_FUNCTION;

                        foreach (var entry_FUNCTION in functionArrayNext)
                        {
                            var boolean_safe_CONTAIN_is = true;

                            boolean_safe_CONTAIN_is = boolean_safe_CONTAIN_is && (entry_FUNCTION.Function.Left.Position > item_FUNCTION.Function.Left.Position) is true;

                            boolean_safe_CONTAIN_is = boolean_safe_CONTAIN_is && (entry_FUNCTION.Function.Right.Position < item_FUNCTION.Function.Right.Position) is true;

                            Boolean isContainCheck, shouldContinueCheck;

                            isContainCheck = boolean_safe_CONTAIN_is is true;

                            shouldContinueCheck = isContainCheck is false;

                            if (shouldContinueCheck is true)
                            {
                                continue;
                            }
                            else
                                "false".ToString();

                            item_entry__FUNCTION.FunctionArray.Add(entry_FUNCTION);

                            continue;
                        }

                        collectionResult.Add(item_entry__FUNCTION);

                        continue;
                    }

                    continue;
                }

                foreach (var item_FUNCTION in collectionResult)
                {
                    foreach (var entry_FUNCTION in collectionResult)
                    {
                        Boolean isReferenceCheck, isNotReferenceCheck;

                        isReferenceCheck = ReferenceEquals(item_FUNCTION, entry_FUNCTION) is true;

                        isNotReferenceCheck = isReferenceCheck is false;

                        if (isNotReferenceCheck is true)
                        {
                            var boolean_safe_CONTAIN_is = true;

                            boolean_safe_CONTAIN_is = boolean_safe_CONTAIN_is && entry_FUNCTION.Function.Layer.Equals(item_FUNCTION.Function.Layer + 1) is true;

                            boolean_safe_CONTAIN_is = boolean_safe_CONTAIN_is && (item_FUNCTION.Function.Function.Left.Position < entry_FUNCTION.Function.Function.Left.Position) is true;

                            boolean_safe_CONTAIN_is = boolean_safe_CONTAIN_is && (item_FUNCTION.Function.Function.Right.Position > entry_FUNCTION.Function.Function.Right.Position) is true;

                            Boolean isContainCheck, shouldContinueCheck;

                            isContainCheck = boolean_safe_CONTAIN_is is true;

                            shouldContinueCheck = isContainCheck is false;

                            if (shouldContinueCheck is true)
                            {
                                continue;
                            }
                            else
                                "false".ToString();

                            entry_FUNCTION.FunctionParent = item_FUNCTION.Function;
                        }
                        else
                            "false".ToString();

                        continue;
                    }

                    continue;
                }

                return new List<FunctionFifty>(collectionResult);
            }
        }
    }
}
