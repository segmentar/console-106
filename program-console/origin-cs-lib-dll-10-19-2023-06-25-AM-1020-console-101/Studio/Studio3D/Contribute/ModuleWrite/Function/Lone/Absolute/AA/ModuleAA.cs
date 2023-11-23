using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial struct ContributeModuleWriteLone
    {
        public static ContributeModuleWrite ModuleAA(ContributeModuleWrite module, Int32 Address_ITEM) 
        {
            var array = module.Third.Function.TupleArrayA;

            var list = new ArrayList();

            foreach (Tuple<Int32, Int32, Int32, Contribute> item_TUPLE in array)
            {
                var Order_ITEM = item_TUPLE.Item1;

                var RegionStart_ITEM = item_TUPLE.Item2;

                var RegionEnd_ITEM = item_TUPLE.Item3;

                var Contribute_ITEM = item_TUPLE.Item4;

                var RegionStartAbsolute___ITEM = (Address_ITEM + RegionStart_ITEM);

                var RegionEndAbsolute___ITEM = (Address_ITEM + RegionEnd_ITEM);

                Tuple<Int32, Int32, Int32, Contribute> tuple;

                tuple = new Tuple<Int32, Int32, Int32, Contribute>(Order_ITEM, RegionStartAbsolute___ITEM, RegionEndAbsolute___ITEM, Contribute_ITEM);

                list.Add(tuple);

                continue;
            }

            var reflect = (Tuple<Int32, Int32, Int32, Contribute>[])(list.ToArray(typeof(Tuple<Int32, Int32, Int32, Contribute>)) as Array);

            module.Third.Function.TupleArrayA = reflect;

            return module;
        }
    }
}
