using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial struct ExpressionModuleReadIO
    {
        public static ExpressionModuleRead ModuleOwner(ExpressionModuleRead module, Tuple<Int32, Int32, Int32, Int32, String, Byte[], Expression>[] array_TUPLE)
        {
            var list = new ArrayList(array_TUPLE);

            do
            {
                Boolean shouldBreakCheck;

                shouldBreakCheck = list.Count.Equals(1) is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                foreach (Tuple<Int32, Int32, Int32, Int32, String, Byte[], Expression> item_TUPLE in new ArrayList(list))
                {
                    var Relate_ITEM = item_TUPLE.Item2;

                    var Expression_ITEM = item_TUPLE.Item7;

                    foreach (Tuple<Int32, Int32, Int32, Int32, String, Byte[], Expression> entry_TUPLE in array_TUPLE)
                    {
                        var Ordinal_ENTRY = entry_TUPLE.Item1;

                        var Expression_ENTRY = entry_TUPLE.Item7;

                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = Relate_ITEM.Equals(Ordinal_ENTRY) is true;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        Expression_ENTRY.ExpressionArrayList.Add(Expression_ITEM);

                        list.Remove(item_TUPLE);

                        continue;
                    }

                    continue;
                }

                continue;

            } while (true);

            var oth = list[0];

            var reflect = (Tuple<Int32, Int32, Int32, Int32, String, Byte[], Expression>)(oth as Object);

            var expression = reflect.Item7;

            module.Expression = expression;

            return module;
        }
    }
}
