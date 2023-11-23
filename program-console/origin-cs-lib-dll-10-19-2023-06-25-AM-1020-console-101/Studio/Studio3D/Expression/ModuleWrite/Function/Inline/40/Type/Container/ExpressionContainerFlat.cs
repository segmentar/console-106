using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial struct ExpressionModuleWrite
    {
        public partial class ExpressionModuleFunctionFourty
        {
            public static ArrayList FunctionFlatContainer(Tuple<Int32, Int32, Int32, Int32, Expression>[] array_TUPLE)
            {
                ArrayList listResult = default;

                listResult = new ArrayList();

                foreach (Tuple<Int32, Int32, Int32, Int32, Expression> item_TUPLE in array_TUPLE)
                {
                    var Ordinal_ITEM = item_TUPLE.Item1;

                    var Relate_ITEM = item_TUPLE.Item2;

                    var RegionStartAddress___ITEM = item_TUPLE.Item3;

                    var RegionEndAddress___ITEM = item_TUPLE.Item4;

                    var StringIdentity__ITEM = item_TUPLE.Item5.StringIdentity.StringValue;

                    Tuple<Int32, Int32, Int32, Int32, String> tuple;

                    tuple = new Tuple<Int32, Int32, Int32, Int32, String>(Ordinal_ITEM, Relate_ITEM, RegionStartAddress___ITEM, RegionEndAddress___ITEM, StringIdentity__ITEM);

                    listResult.Add(tuple);

                    continue;
                }

                return listResult;
            }
        }
    }
}
