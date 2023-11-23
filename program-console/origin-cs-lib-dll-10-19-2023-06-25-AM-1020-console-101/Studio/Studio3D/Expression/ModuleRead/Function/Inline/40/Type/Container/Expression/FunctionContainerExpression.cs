using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    public partial struct ExpressionModuleRead
    {
        public partial class ExpressionModuleFunctionFourty
        {
            public static ArrayList FunctionExpressionContainer(Tuple<Int32, Int32, Int32, Int32, String, Byte[]>[] array_TUPLE)
            {
                ArrayList listResult = default;

                listResult = new ArrayList();

                foreach (Tuple<Int32, Int32, Int32, Int32, String, Byte[]> item_TUPLE in array_TUPLE)
                {
                    var Ordinal_ITEM = item_TUPLE.Item1;

                    var Relate_ITEM = item_TUPLE.Item2;

                    var RegionStartAddress___ITEM = item_TUPLE.Item3;

                    var RegionEndAddress___ITEM = item_TUPLE.Item4;

                    var StringIdentity__ITEM = item_TUPLE.Item5;

                    var ObjectIdentity__ITEM = item_TUPLE.Item6;

                    var deflect = Expression.DeflectRegion(StringIdentity__ITEM, ObjectIdentity__ITEM);

                    var expression = new ExpressionSimple(StringIdentity__ITEM, deflect).Result;

                    Tuple<Int32, Int32, Int32, Int32, String, Byte[], Expression> tuple;

                    tuple = new Tuple<Int32, Int32, Int32, Int32, String, Byte[], Expression>(Ordinal_ITEM, Relate_ITEM, RegionStartAddress___ITEM, RegionEndAddress___ITEM, StringIdentity__ITEM, ObjectIdentity__ITEM, expression);

                    listResult.Add(tuple);

                    continue;
                }

                return listResult;
            }
        }
    }
}
