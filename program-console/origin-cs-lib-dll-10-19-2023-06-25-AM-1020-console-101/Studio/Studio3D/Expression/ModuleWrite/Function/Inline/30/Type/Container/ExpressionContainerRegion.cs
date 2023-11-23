using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial struct ExpressionModuleWrite
    {
        public partial class ExpressionModuleFunctionThirty
        {
            public static ArrayList FunctionRegionContainer(Tuple<Int32, Int32, Expression>[] array_TUPLE, Int32[] RegionStartAddress__ARRAY, Int32[] RegionEndAddress__ARRAY, Int32 ExpressionLength__ITEM)
            {
                ArrayList listResult = default;

                listResult = new ArrayList();

                var indexer = 0;

                do
                {
                    Boolean shouldBreakCheck;

                    shouldBreakCheck = ExpressionLength__ITEM.Equals(indexer) is true;

                    if (shouldBreakCheck is true)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    var Ordinal_ITEM = array_TUPLE[indexer].Item1;

                    var Relate_ITEM = array_TUPLE[indexer].Item2;

                    var RegionStartAddresss___ITEM = RegionStartAddress__ARRAY[indexer];

                    var RegionEndAddress___ITEM = RegionEndAddress__ARRAY[indexer];

                    RegionStartAddresss___ITEM = RegionStartAddresss___ITEM + Expression.BoundaryStart;

                    RegionStartAddresss___ITEM = RegionStartAddresss___ITEM + (ExpressionLength__ITEM * Expression.BoundarySize);

                    RegionEndAddress___ITEM = RegionEndAddress___ITEM + Expression.BoundaryStart;

                    RegionEndAddress___ITEM = RegionEndAddress___ITEM + (ExpressionLength__ITEM * Expression.BoundarySize);

                    var StringIdentity__ITEM = array_TUPLE[indexer].Item3;

                    Tuple<Int32, Int32, Int32, Int32, Expression> tuple;

                    tuple = new Tuple<Int32, Int32, Int32, Int32, Expression>(Ordinal_ITEM, Relate_ITEM, RegionStartAddresss___ITEM, RegionEndAddress___ITEM, StringIdentity__ITEM);

                    listResult.Add(tuple);

                    indexer = indexer + 1;

                    continue;

                } while (true);

                return listResult;
            }
        }
    }
}
