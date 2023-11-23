using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial struct ExpressionModuleWrite
    {
        public partial class ExpressionModuleFunctionTwenty
        {
            public static ArrayList FunctionRelateContainer(Tuple<Int32, Expression>[] array_TUPLE)
            {
                ArrayList listResult = default;

                listResult = new ArrayList();

                foreach (Tuple<Int32, Expression> item_TUPLE in array_TUPLE)
                {
                    var relate = -1;

                    var Ordinal_ITEM = item_TUPLE.Item1;

                    var Expression_ITEM = item_TUPLE.Item2;

                    foreach (Tuple<Int32, Expression> entry_TUPLE in array_TUPLE)
                    {
                        var Ordinal_ENTRY = entry_TUPLE.Item1;

                        var Expression_ENTRY = entry_TUPLE.Item2;             

                        foreach (Expression expressionChild in Expression_ENTRY.ExpressionArrayList)
                        {
                            Boolean isReferenceCheck, shouldContinueCheck;

                            isReferenceCheck = ReferenceEquals(Expression_ITEM, expressionChild) is true;

                            shouldContinueCheck = isReferenceCheck is false;

                            if (shouldContinueCheck is true)
                            {
                                continue;
                            }
                            else
                                "false".ToString();

                            relate = Ordinal_ENTRY;

                            continue;
                        }

                        continue;
                    }

                    Tuple<Int32, Int32, Expression> tuple;

                    tuple = new Tuple<Int32, Int32, Expression>(Ordinal_ITEM, relate, Expression_ITEM);

                    listResult.Add(tuple);

                    continue;
                }

                return listResult;
            }
        }
    }
}
