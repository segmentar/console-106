using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class FunctionFifty
        {
            public static ICollection FunctionLayerContainer(FunctionFourty[] FunctionSeventy__VALUE)
            {
                IList listResult = default;

                listResult = new ArrayList();

                var largest = -1;

                foreach (FunctionFourty item_FUNCTION in FunctionSeventy__VALUE)
                {
                    Boolean isLargerCheck, shouldContinueCheck;

                    isLargerCheck = (item_FUNCTION.Layer > largest) is true;

                    shouldContinueCheck = isLargerCheck is false;

                    if (shouldContinueCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    largest = item_FUNCTION.Layer;

                    continue;
                }

                largest = largest + 1;

                var indexer = 0;

                do
                {
                    Boolean shouldBreakCheck;

                    shouldBreakCheck = largest.Equals(indexer) is true;

                    if (shouldBreakCheck is true)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    FunctionFourty[] functionArrayPrevious, functionArrayNext;

                    functionArrayPrevious = new FunctionFourty[0];

                    functionArrayNext = new FunctionFourty[0];

                    ArrayList listPrevious, listNext;

                    listPrevious = new ArrayList();

                    listNext = new ArrayList();

                    foreach (var item_FUNCTION in FunctionSeventy__VALUE)
                    {
                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = item_FUNCTION.Layer.Equals(indexer) is true;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        listPrevious.Add(item_FUNCTION);

                        continue;
                    }

                    foreach (var item_FUNCTION in FunctionSeventy__VALUE)
                    {
                        var zee = (indexer + 1);

                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = item_FUNCTION.Layer.Equals(zee) is true;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        listNext.Add(item_FUNCTION);

                        continue;
                    }

                    Array.Resize(ref functionArrayPrevious, listPrevious.Count);

                    Array.Resize(ref functionArrayNext, listNext.Count);

                    listPrevious.CopyTo(functionArrayPrevious, 0);

                    listNext.CopyTo(functionArrayNext, 0);

                    Tuple<FunctionFourty[], FunctionFourty[]> tuple;

                    tuple = new Tuple<FunctionFourty[], FunctionFourty[]>(functionArrayPrevious, functionArrayNext);

                    listResult.Add(tuple);

                    indexer = indexer + 1;

                    continue;

                } while (true);

                return listResult;
            }
        }
    }
}
