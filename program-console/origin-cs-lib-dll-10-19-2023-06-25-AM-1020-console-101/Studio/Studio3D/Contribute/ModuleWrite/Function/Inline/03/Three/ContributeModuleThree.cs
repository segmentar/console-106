using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial struct ContributeModuleWriteInline
    {
        public static ContributeModuleWrite ContributeModuleThree(ContributeModuleWrite module, Tuple<Int32, Int32, Int32, Contribute>[] array_TUPLE)
        {
            var TabulationTableA___ARRAY_LIST = new ArrayList();

            var TabulationTableB___ARRAY_LIST = new ArrayList();

            var TabulationTableC___ARRAY_LIST = new ArrayList();

            var TabulationTableD___ARRAY_LIST = new ArrayList();

            foreach (Tuple<Int32, Int32, Int32, Contribute> item_TUPLE in array_TUPLE)
            {
                ContributeCode.TabulationType tabulationType;

                tabulationType = item_TUPLE.Item4.TabulationType;

                switch (tabulationType)
                {
                    case ContributeCode.TabulationType.TabulationA:
                        TabulationTableA___ARRAY_LIST.Add(item_TUPLE);
                        break;

                    case ContributeCode.TabulationType.TabulationB:
                        TabulationTableB___ARRAY_LIST.Add(item_TUPLE);
                        break;

                    case ContributeCode.TabulationType.TabulationC:
                        TabulationTableC___ARRAY_LIST.Add(item_TUPLE);
                        break;

                    case ContributeCode.TabulationType.TabulationD:
                        TabulationTableD___ARRAY_LIST.Add(item_TUPLE);
                        break;

                    default:
                        break;
                }

                continue;
            }

            var reflect__TABULATION_TABLE_A = (Tuple<Int32, Int32, Int32, Contribute>[])(TabulationTableA___ARRAY_LIST.ToArray(typeof(Tuple<Int32, Int32, Int32, Contribute>)) as Array);

            var reflect__TABULATION_TABLE_B = (Tuple<Int32, Int32, Int32, Contribute>[])(TabulationTableB___ARRAY_LIST.ToArray(typeof(Tuple<Int32, Int32, Int32, Contribute>)) as Array);

            var reflect__TABULATION_TABLE_C = (Tuple<Int32, Int32, Int32, Contribute>[])(TabulationTableC___ARRAY_LIST.ToArray(typeof(Tuple<Int32, Int32, Int32, Contribute>)) as Array);

            var reflect__TABULATION_TABLE_D = (Tuple<Int32, Int32, Int32, Contribute>[])(TabulationTableD___ARRAY_LIST.ToArray(typeof(Tuple<Int32, Int32, Int32, Contribute>)) as Array);

            var function = new ContributeModuleThirty();

            function.TupleArrayA = reflect__TABULATION_TABLE_A;

            function.TupleArrayB = reflect__TABULATION_TABLE_B;

            function.TupleArrayC = reflect__TABULATION_TABLE_C;

            function.TupleArrayD = reflect__TABULATION_TABLE_D;

            ContributeModuleThird third;

            third = new ContributeModuleThird(function);

            module.Third = third;

            return module;
        }
    }
}
