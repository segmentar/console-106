using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class FunctionFourty
        {
            public static IList<FunctionFourty> FunctionDefaultSet(FunctionThirty[] array_FUNCTION)
            {
                ICollection<FunctionFourty> collectionResult = default;

                collectionResult = new Collection<FunctionFourty>();

                foreach (FunctionThirty item_FUNCTION in array_FUNCTION)
                {
                    var layer = 1;

                    foreach (FunctionThirty entry_FUNCTION in array_FUNCTION)
                    {
                        var boolean_safe_CONTAIN_is = true;

                        boolean_safe_CONTAIN_is = boolean_safe_CONTAIN_is && (item_FUNCTION.Left.Position > entry_FUNCTION.Left.Position) is true;

                        boolean_safe_CONTAIN_is = boolean_safe_CONTAIN_is && (item_FUNCTION.Right.Position < entry_FUNCTION.Right.Position) is true;

                        Boolean isContainCheck, shouldContinueCheck;

                        isContainCheck = boolean_safe_CONTAIN_is is true;

                        shouldContinueCheck = isContainCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        layer = layer + 1;

                        continue;
                    }

                    FunctionFourty FunctionSeventy__VALUE;

                    FunctionSeventy__VALUE = new FunctionFourty(item_FUNCTION, layer);

                    collectionResult.Add(FunctionSeventy__VALUE);

                    continue;
                }

                return new List<FunctionFourty>(collectionResult);
            }
        }
    }
}
